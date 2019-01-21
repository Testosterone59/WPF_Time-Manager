using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Owner
{
    static class FileManager
    {

        public static void SaveWeek(DataWeek week, string path)
        {
            if (week == null)
                return;

            string filePath = $"{path}{week.days[DayOfWeek.Monday].date.day} {week.days[DayOfWeek.Monday].date.month} {week.days[DayOfWeek.Monday].date.year}" +
                $"-{week.days[DayOfWeek.Sunday].date.day} {week.days[DayOfWeek.Sunday].date.month} {week.days[DayOfWeek.Sunday].date.year}.week";

            // If an all tasks of week is empty then removing the file
            if (week.isEmpty && File.Exists(filePath))
            {
                File.Delete(filePath);
                return;
            }

            // Writing a days of week to file
            StreamWriter stream = new StreamWriter(filePath);

            foreach (var d in week.days)
                if (d.Value.tasks.Count > 0)
                {
                    string text = $"{d.Key.ToString()}=";

                    foreach(var t in d.Value.tasks)
                        text += $"{t.TaskName}!{t.Info}!{t.Tomatoes}!{t.IsDone}!{(int)t.TotalTime.TotalSeconds}*";

                    stream.WriteLine(Crypt(text));
                }

            stream.Close();
        }

        public static DataWeek LoadWeek(DateTime dateTime, string path)
        {
            // Getting a days of selected week
            DateOfWeek[] dates = GetWeek(dateTime);

            string filePath = $"{path}{dates[0].date.day} {dates[0].date.month} {dates[0].date.year}" +
                $"-{dates[6].date.day} {dates[6].date.month} {dates[6].date.year}.week";

            // Creating a array days of week
            DataWeek dataWeek = new DataWeek();

            // Set default values
            foreach (var d in dates)
            {
                DataDay newDay = new DataDay(d.date);
                newDay.dayOfWeek = d.dayOfWeek;
                dataWeek.days.Add(d.dayOfWeek, newDay);
            }

            return LoadWeek(filePath, dataWeek);
        }

        static DataWeek LoadWeek(string filePath, DataWeek dataWeek = null)
        {
            if (dataWeek == null)
            {
                dataWeek = new DataWeek();
                dataWeek.FillDefault(
                    GetStartDateForFilePath(filePath));
            }

            // If file of data is exist then read file and fill the array of tasks
            if (File.Exists(filePath))
            {
                string[] dataDays = File.ReadAllLines(filePath);

                foreach (var dataDay in dataDays)
                {
                    if (dataDay == string.Empty)
                        continue;

                    // Split the value up half by char '=' (index 0 is a day name, index 1 is data of tasks)
                    var data = Crypt(dataDay).Split('=');

                    DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), data[0], true);

                    DataDay day = dataWeek.days[dayOfWeek];

                    // Split the value up on a tasks by char '*'
                    var dataTasks = data[1].Split('*');

                    foreach (var task in dataTasks)
                    {
                        if (task == string.Empty)
                            continue;

                        // Split the value up by char '!' and get the array of values of class 'DateTask'
                        var values = task.Split('!');

                        DataTask newTask = new DataTask(values[0], values[1], int.Parse(values[4]), int.Parse(values[2]), bool.Parse(values[3]));

                        day.tasks.Add(newTask);
                    }
                }
            }

            return dataWeek;
        }

        /// <summary>
        /// Find and get information about a saved files exist in folder(month and year)
        /// </summary>
        public static List<Date> GetMonthsInFolder(string path)
        {
            List<Date> dates = new List<Date>();

            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.week");

            // Look for files
            foreach (FileInfo file in Files)
            {
                // Create array of two date from name of file
                var twoDates = file.Name.Replace(".week", "").Split('-');

                foreach (var date in twoDates)
                {
                    var arrDate = date.Split(' ');

                    int month = int.Parse(arrDate[1]);
                    int year = int.Parse(arrDate[2]);

                    if (!dates.Exists((v) => v.month == month && v.year == year))
                        dates.Add(new Date() { month = month, year = year });
                }
            }

            return dates;
        }

        public static DateMonth LoadDataMonth(string path, int month, int year)
        {
            DateMonth newDateMonth = new DateMonth(month, year);

            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.week");

            List<string> fileNames = new List<string>();

            // Look for files needly
            foreach (FileInfo file in Files)
            {
                // Create array of two date from name of file
                var twoDates = file.Name.Replace(".week", "").Split('-');

                foreach(var date in twoDates)
                {
                    var arrDate = date.Split(' ');

                    // If a month number and a year number were in name of file then adding it
                    if (int.Parse(arrDate[1]) == month && int.Parse(arrDate[2]) == year)
                    {
                        fileNames.Add(file.FullName);
                        break;
                    }
                }
            }

            if (fileNames.Count == 0)
                return newDateMonth;

            List<DataWeek> weeks = new List<DataWeek>();

            // Load weeks from files
            foreach (var fileName in fileNames)
                weeks.Add(LoadWeek(fileName));

            // Filling 'DateMonth' with help an array of weeks
            foreach (var w in weeks)
            {
                var values = w.days.Values;

                foreach (var v in values)
                {
                    //Check whether a day is part of month and year which need
                    if (v.date.month != month || v.date.year != year)
                        continue;

                    DateMonth.DayMonth dayMonth = new DateMonth.DayMonth(v.dayOfWeek, v.CalculateAllTime());
                    newDateMonth.values.Add(v.date.day, dayMonth);
                }
            }

            newDateMonth.CalculateTotalTime();

            return newDateMonth;
        }

        private static DateTime GetStartDateForFilePath(string path)
        {
            int start = path.LastIndexOf('\\');
            int end = path.LastIndexOf('-');

            string val = path.Substring(start + 1, end - start - 1);
            var values = val.Split(' ');

            return new DateTime(int.Parse(values[2]), int.Parse(values[1]), int.Parse(values[0]));
        }

        private static int CalculateTomatoes(DataDay day)
        {
            int val = 0;

            foreach (var t in day.tasks)
                val += t.Tomatoes;

            return val;
        }

        private static TimeSpan CalculateTotalTime(DataDay day)
        {
            TimeSpan time = new TimeSpan();

            foreach (var t in day.tasks)
                time = time.Add(t.TotalTime);

            return time;
        }

        private static DateOfWeek[] GetWeek(DateTime dateTime)
        {
            int indexDay = (int)dateTime.DayOfWeek;
            int dayOffset = 0;

            if (indexDay > 1)
                dayOffset = indexDay - 1;
            else if (indexDay == 0)
                dayOffset = 6;

            DateOfWeek[] dates = new DateOfWeek[7];
            DateTime current = dateTime.AddDays(-dayOffset);
            for (int i = 0; i < 7; i++)
            {
                dates[i] = new DateOfWeek(current.DayOfWeek, new Date(current));
                current = current.AddDays(1);
            }
            return dates;
        }

        public static void SaveLog(Exception e, string path)
        {
            if (string.IsNullOrEmpty(path))
                return;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var d = DateTime.Now;
            string fileName = $"{d.Day}_{d.Month}_{d.Year}({d.Hour}_{d.Minute}).log";
            StreamWriter streamWr = new StreamWriter(path + fileName);
            streamWr.Write(e.ToString());
            streamWr.Close();
        }

        /// <summary>
        /// Save a profile data
        /// </summary>
        public static void SaveProfile()
        {
            string path = $"{Directory.GetCurrentDirectory()}/Profile.data";

            StreamWriter streamWr = new StreamWriter(path);

            string text = $"Level={Profile.data.Level}#Exp={Profile.data.Experience}#";

            for(int i=0; i<Profile.data.Goals.Count; i++)
            {
                var t = Profile.data.Goals[i];

                if (t == null)
                    continue;

                var date = t.dateEnd.Value;
                text += $"Target={i}!{t.Name}!{date.Year}!{date.Month}!{date.Day}#";
            }

            streamWr.Write(Crypt(text));
            streamWr.Close();
        }

        /// <summary>
        /// Load a profile data
        /// </summary>
        public static void LoadProfile()
        {
            string path = $"{Directory.GetCurrentDirectory()}/Profile.data";

            if (!File.Exists(path))
                return;

            string[] data = Crypt(File.ReadAllText(path)).Split('#');
            if (data == null || data.Length == 0)
                return;

            foreach (var d in data)
            {
                var dataSubject = d.Split('=');

                switch (dataSubject[0])
                {
                    case "Level":
                        Profile.data.Level = int.Parse(dataSubject[1]);
                        break;
                    case "Exp":
                        Profile.data.Experience = int.Parse(dataSubject[1]);
                        break;
                    case "Target":
                        var dataGoal = dataSubject[1].Split('!');

                        DateTime date = new DateTime(int.Parse(dataGoal[2]), int.Parse(dataGoal[3]), int.Parse(dataGoal[4]));
                        Goal newGoal = new Goal()
                        {
                            Name = dataGoal[1],
                            dateEnd = date
                        };

                        Profile.data.Goals[int.Parse(dataGoal[0])] = newGoal;
                        break;
                }
            }
        }

        public static void SaveSettings()
        {
            string path = $"{Directory.GetCurrentDirectory()}/Settings.ini";
            StreamWriter streamWr = new StreamWriter(path);
            streamWr.WriteLine($"TimeOfWork={GlobalSettings.dataSettings.TimeOfWork}");
            streamWr.WriteLine($"TimeOfBreak={GlobalSettings.dataSettings.TimeOfBreak}");
            streamWr.WriteLine($"TimeOfLongBreak={GlobalSettings.dataSettings.TimeOfLongBreak}");
            streamWr.WriteLine($"TimeOfGettingTomato={GlobalSettings.dataSettings.TimeOfGettingTomato}");
            streamWr.WriteLine($"MaximumTaskTime={GlobalSettings.dataSettings.MaximumTaskTime}");
            streamWr.WriteLine($"EnableWindowInfo={GlobalSettings.dataSettings.EnableWindowInfo}");
            streamWr.WriteLine($"EnableWindowBreak={GlobalSettings.dataSettings.EnableWindowBreak}");
            streamWr.WriteLine($"EnableProgressbar={GlobalSettings.dataSettings.EnableProgressbar}");
            streamWr.WriteLine($"ProgressbarWidth={GlobalSettings.dataSettings.ProgressbarWidth}");
            streamWr.WriteLine($"ProgressbarHeight={GlobalSettings.dataSettings.ProgressbarHeight}");

            if (GlobalSettings.dataSettings.PathImgBreakTime != string.Empty)
                streamWr.WriteLine($"PathImageBreakTime={GlobalSettings.dataSettings.PathImgBreakTime}");

            if (GlobalSettings.dataSettings.PathImgLongBreakTime != string.Empty)
                streamWr.WriteLine($"PathImageLongBreakTime={GlobalSettings.dataSettings.PathImgLongBreakTime}");

            if (GlobalSettings.dataSettings.PathImgProfile != string.Empty)
                streamWr.WriteLine($"PathImageProfile={GlobalSettings.dataSettings.PathImgProfile}");

            streamWr.Close();
        }

        public static void LoadSettings()
        {
            string path = $"{Directory.GetCurrentDirectory()}/Settings.ini";
            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);
                if (data == null || data.Length == 0) { return; }
                foreach (var val in data)
                {
                    string[] v = val.Split('=');
                    if (v.Count() < 2 || v[0] == string.Empty || v[1] == string.Empty) { continue; }
                    switch (v[0])
                    {
                        case "TimeOfWork": GlobalSettings.dataSettings.TimeOfWork = int.Parse(v[1]); break;
                        case "TimeOfBreak": GlobalSettings.dataSettings.TimeOfBreak = int.Parse(v[1]); break;
                        case "TimeOfLongBreak": GlobalSettings.dataSettings.TimeOfLongBreak = int.Parse(v[1]); break;
                        case "TimeOfGettingTomato": GlobalSettings.dataSettings.TimeOfGettingTomato = int.Parse(v[1]); break;
                        case "MaximumTaskTime": GlobalSettings.dataSettings.MaximumTaskTime = int.Parse(v[1]); break;
                        case "EnableWindowInfo": GlobalSettings.dataSettings.EnableWindowInfo = bool.Parse(v[1]); break;
                        case "EnableWindowBreak": GlobalSettings.dataSettings.EnableWindowBreak = bool.Parse(v[1]); break;
                        case "EnableProgressbar": GlobalSettings.dataSettings.EnableProgressbar = bool.Parse(v[1]); break;
                        case "ProgressbarWidth": GlobalSettings.dataSettings.ProgressbarWidth = double.Parse(v[1]); break;
                        case "ProgressbarHeight": GlobalSettings.dataSettings.ProgressbarHeight = double.Parse(v[1]); break;
                        case "PathImageBreakTime": GlobalSettings.dataSettings.PathImgBreakTime = v[1]; break;
                        case "PathImageLongBreakTime": GlobalSettings.dataSettings.PathImgLongBreakTime = v[1]; break;
                        case "PathImageProfile": GlobalSettings.dataSettings.PathImgProfile = v[1]; break;
                    }
                }
            }
            else
                SaveSettings();

        }

        public static string OpenImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
                else
                    return string.Empty;
            }
        }

        private static string ExtractValue(ref string line, string pattern, string endChar = "#")
        {
            string value = string.Empty;

            if (line.Trim() != string.Empty)
            {
                value = line;

                int index = value.IndexOf(pattern, StringComparison.Ordinal);

                if (index > -1)
                {
                    value = value.Remove(0, index);
                    int indexEnd = value.IndexOf(endChar, StringComparison.Ordinal);
                    value = value.Remove(indexEnd);
                    line = line.Replace(value + endChar, "");
                    value = value.Remove(0, pattern.Length + 1);
                }
                else
                    value = string.Empty;

            }
            return value;
        }

        private static string Crypt(string text)
        {

            string result = string.Empty;

            foreach (char j in text)
                result += (char)((int)j ^ 49);

            return result;
        }

    }
}
