using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Time_Owner
{
    /// <summary>
    /// This converter convert TimeSpan (TotalHours) into string
    /// </summary>
    public class TimeSpanHoursToStringConverterExtension : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TimeSpan span = (TimeSpan)value;
            return Math.Round(span.TotalHours, 2).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
                _converter = new TimeSpanHoursToStringConverterExtension();
            return _converter;
        }

        private static TimeSpanHoursToStringConverterExtension _converter = null;
    }
    /// <summary>
    /// This converter convert int to Visibility (if int > 0)
    /// </summary>
    public class IntNotZeroToVisibilityConverterExtension : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int v = (int)value; 
            return v > 0 ? System.Windows.Visibility.Visible :
                System.Windows.Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
                _converter = new IntNotZeroToVisibilityConverterExtension();
            return _converter;
        }

        private static IntNotZeroToVisibilityConverterExtension _converter = null;
    }

    public class PercentageConverter : MarkupExtension, IValueConverter
    {
        private static PercentageConverter _instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new PercentageConverter());
        }
    }
}
