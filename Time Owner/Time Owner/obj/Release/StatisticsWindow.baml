   M S B A M L   `   `   `  ���� E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf !    Time_Owner.StatisticsWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Time_Owner     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     -   $��window��  � Title$  StatisticsWindow�� � ShowInTaskbar .  $	��450��$	��950�� � 
ResizeMode$ NoResize=� � Icon$ icon.ico�� � WindowStartupLocation$ CenterOwner=� � WindowStyle$
 None=����#2b2b2b$��2q�
�������.���  � ColumnDefinitions �� $
��613* ��� $
��140* � � RowDefinitions �� $	��30* ��� $
��420* �.+��� $��
Statistics��$��0��$��0��$��2��$��Stretch=�$��Stretch=�$
��10,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��Center=�$��16(����#353535
�������$��0,1,0,1q�]� -    ]�Name$
 head��$��0��$��0��$��2��$��Stretch=���. $��Stretch=�$��0,0,0,0q�.+�   Time_Owner.ButtonImage  $��Right=�	   ImageDefault$	 Images/btnCloseNormal.png��
   ImagePressed$ 
 Images/btnClosePressed.png��   Click 
CloseClick$��
0,10,10,10q�$��Stretch=����� *ActualHeight+ �� RelativeSource �� *Self+�� -    ��Name$ PART_TITLEBAR��$
��Left=�$��0q����	#00000000$��Stretch=�$��Stretch=�]� -   $ 
rightPanel��$��1��$��1��$��1q�$��Stretch=���.  $��Stretch=����#353535.+�   Time_Owner.MonthCalendar  -     Name$ calendar��$	��Top=�$��8q�$	��Top=�$��Stretch=�   OnChange Recalculate   MaxElementsSelected$ 3������ *ActualWidth+ �� *Self+�� -   $��comboBoxType��$	��Top=�$	��Top=�$��Stretch=�$��
25,10,25,0q� �� SelectedValuePath$ Value�� �� DisplayMemberPath$ Value������  �� Source %   Time_Owner.EnumerationExtension  *M� *local:StatisticType++ �� SelectedValue ��  �� ElementName$ window�� �� Path$ StatisticType��� -   $��Recalculate��$��Bottom=�$��Center=�$	��Top=�$	��100��$��5q����	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�$��16(�
��������� -   $��listBoxTotalTime��$��0q�$	��Top=�$	��100��$��Center=�$��10,20q�
�������
������ ���� *Months+���� .R��� 
�������$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)���`�  �� StringFormat$ {0} Total is {1}h��.1��� $ Title��� $ 	TotalTime� �� 	Converter 8   2Time_Owner.TimeSpanHoursToStringConverterExtension  #  LiveCharts.Wpf.CartesianChart  -	   $��chart��$��1��$��5q�&   LiveCharts.Wpf.Charts.Base.Chart   	Hoverable .  $��Stretch=�$��Stretch=�   Series �� *SeriesCollection+   AxisX   LiveCharts.Wpf.Axis     Title$
 Date��   Labels �� *Labels+   AxisY   $ Hours��   LabelFormatter �� *	Formatter+