   M S B A M L   `   `   `  ���� E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner      Time_Owner.Settings   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Time_Owner       � Title$  Settings��$	��252��$	��700�����#2b2b2b$��2q�
�������$��Proxima Nova Cn Rg)� � 
ResizeMode$ NoResize=� � Icon$ icon.ico�� � WindowStartupLocation$ CenterOwner=� � WindowStyle$
 None=�.��� $��0,0,0,0q�$��Stretch=�$��Stretch=� � ShowGridLines .   � DataContext ��    Time_Owner.GlobalSettings   dataSettings �� Source# Z 	 � RowDefinitions	 �� $	��32* ��� $	��32* ��� $	��32* ��� $	��32* ��� $	��32* ��� $	��32* ��� $	��32* ��� $	��32* �
 � ColumnDefinitions
 �� $	��20* ��� $	��40* ��� $
��200* ��� $	��50* ��� $
��190* ��� $	��75* ��� $
��125* �.+��� $��0��$��1��$��3��$��Stretch=�$��Stretch=�$��1,1,1,1q�$��Center=�$
��22,0q�$��Mode Pomodoro��$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��14(����#353535
������� J� RenderTransformOrigin$	 0,0&�$��	Condensed&�$��SemiBold"��� $��0��$��5��$��3��$��Stretch=�$��Stretch=�$��1,1,1,1q�$��Center=�$
��22,0q�$��Mode the Timer��$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��14(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"��� $��3��$��1��$��2��$��Stretch=�$��Stretch=�$��1,1,1,1q�$��Center=�$
��10,0q�$��Other��$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��14(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"��� $��3��$��5��$��2��$��Stretch=�$��Stretch=�$��1,1,1,1q�$��Center=�$
��10,0q�$��Progress bar��$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��14(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"��� $��0��$��2��$��3��$��3�����#353535$��0q�$��Stretch=�$��Stretch=�$��0,1,1,1q��� $��0��$��6��$��3��$��2�����#353535$��0q�$��Stretch=�$��Stretch=�$��0,1,1,1q��� $��3��$��2��$��2��$��3�����#353535$��0q�$��Stretch=�$��Stretch=�$��1,1,1,1q��� $��3��$��6��$��2��$��2�����#353535$��0q�$��Stretch=�$��Stretch=�$��1,1,1,1q��� $��5��$��2��$��2��$��6�����#353535$��0q�$��Stretch=�$��Stretch=�$��1,1,1,1q��� $��0��$��0��$��7��$��Stretch=�$��Stretch=�$��0,0,0,1q�$��Settings��$��Center=�$
��22,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"� J� IsHitTestVisible .  �� $��5��$��1��$��2��$��Stretch=�$��Stretch=�$��1,1,1,1q�$��Center=�$
��10,0q�$��Images��$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��14(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"��� -    ��Name$ textTimeOfWork��$��1��$��2��$��Stretch=�$��5,5,5,5q� �� TextWrapping$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)� �� TextAlignment$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *
TimeOfWork+�� $��2��$��2��$��Stretch=� �� Padding$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Time of work��$��Stretch=�$��16(�
������� �� TextAlignment$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textTimeOfRest��$��1��$��3��$��Stretch=�$��5,5,5,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *TimeOfLongBreak+�� $��2��$��3��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Time of break��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textTimeOfLongRest��$��1��$��4��$��Stretch=�$��5,5,5,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *TimeOfLongBreak+�� $��2��$��4��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Time of long break��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -    ��Name$ checkBoxInfo��$��3��$��2��$��Right=�$��	10,5,10,5q�$��Stretch=�$ 0.5,0.5&�   myCheckboxStyle#��[  ���� *ActualHeight+ �� RelativeSource �� *Self+ d� 	IsChecked �� *EnableWindowInfo+�� $��4��$��2��$��Stretch=�$
 5, 2q�$��5,5,0,5q�$
��Wrap=�$��Show the window of info��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ checkBoxRest��$��3��$��3��$��Right=�$��	10,5,10,5q�$��Stretch=�$ 0.5,0.5&�#��[  ���� *ActualHeight+ �� *Self+ �� *EnableWindowBreak+�� $��4��$��3��$��Stretch=�$
 5, 2q�$��5,5,0,5q�$
��Wrap=�$ ��Show the window of a break��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ checkBoxProgressBar��$��3��$��4��$��Right=�$��	10,5,10,5q�$��Stretch=�$ 0.5,0.5&�#��[  ���� *ActualHeight+ �� *Self+ �� *EnableProgressbar+�� $��4��$��4��$��Stretch=�$
 5, 2q�$��5,5,0,5q�$
��Wrap=�$��Show progress bar��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�   Time_Owner.SelectImage  -     Name$ selectImgBreakTime��$��5��$��2��$��2��$��4,4,4,4q�$��Stretch=�$��Stretch=�   Click OpenImageClick   	PathImage �� *PathImgBreakTime+�� $��6��$��3��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��A break time��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�  -   $ selectImgLongBreakTime��$��5��$��4��$��2��$��4,4,4,4q�$��Stretch=�$��Stretch=� OpenImageClick �� *PathImgLongBreakTime+�� $��6��$��5��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��A long break time��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�  -	   $ selectImgProfile��$��5��$��6��$��2��$��4,4,4,4q�$��Stretch=�$��Stretch=� OpenImageClick � ToolTip$# Recommended size is 128 x 128�� �� *PathImgProfile+�� $��6��$��7��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Profile picture��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -
   $ textTimeOfGettingTomato��$��1��$��6��$��Stretch=�$��5,5,5,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *TimeOfGettingTomato+�� $��2��$��6��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Time of getting tomato��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textMaximumTaskTime��$��1��$��7��$��Stretch=�$��5,5,5,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *MaximumTaskTime+�� $��2��$��7��$��Stretch=�$
 0, 2q�$��5,5,0,5q�$
��Wrap=�$��Maximum task time��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textPBWidth��$��3��$��6��$��Stretch=�$��10,5,0,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *ProgressbarWidth+�� $��4��$��6��$��Stretch=�$
 5, 2q�$��5,5,0,5q�$
��Wrap=�$��Width��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textPBHeight��$��3��$��7��$��Stretch=�$��10,5,0,5q�$
 Wrap=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$ Center=�$
��0, 2q�$��Stretch=�$��16(�$
��Bold"����	#FF474747���� *ProgressbarHeight+�� $��4��$��7��$��Stretch=�$
 5, 2q�$��5,5,0,5q�$
��Wrap=�$��Height��$��Stretch=�$��16(�
�������$
 Left=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�]� $��0��$��0��$��8��$��Stretch=���. $��Stretch=�.+��� -    ��Name$ 
PART_CLOSE��$��Right=�$��Stretch=�$��2,9,5,9q�$��Stretch=�$��22������  �� 
TargetType" ��.R���  ��Name$
 img1��$��Images/btnCloseNormal.png�� �� Triggers P�  P� Property � �� P� Value . . ���  �� 
TargetName$
 img1��  �� Property  � ��! �� Value$7! 1pack://application:,,,/Images/btnClosePressed.png���� -   " ��Name$" border��$
��Left=����	#00000000$��0q�$��Stretch=�$��Stretch=�