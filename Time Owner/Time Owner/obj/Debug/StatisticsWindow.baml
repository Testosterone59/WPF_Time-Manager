   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   !    Time_Owner.StatisticsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Time_Owner     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   -   5        $��window��5	   "     � Title$  StatisticsWindow��6	    � ShowInTaskbar .  $	��450��6F   $	��950��6S    � 
ResizeMode$ NoResize=�6_    � Icon$ icon.ico��6u    � WindowStartupLocation$ CenterOwner=�6�    � WindowStyle$
 None=�6�   ���#2b2b2b$��2q�6�   
�������.��5      �  � ColumnDefinitions 5   
   �� 5      $
��613* �6   �� 5      $
��140* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $
��420* �6   .+�5   
   �� $��
Statistics��6   $��0��6%   $��0��65   $��2��6B   $��Stretch=�6V   $��Stretch=�6r   $
��10,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��Center=�6�   $��16(�6�   ���#353535
�������$��0,1,0,1q�64  ]� 5   
   -   5         ]�Name$
 head��5      $��0��6"   $��0��62   $��2��6?   $��Stretch=�6S   ��. $��Stretch=�6�   $��0,0,0,0q�6�   .+�5         Time_Owner.ButtonImage  $��Right=�6    	   ImageDefault$	 Images/btnCloseNormal.png��67   
   ImagePressed$ 
 Images/btnClosePressed.png��6`      Click 
CloseClick6�   $��
0,10,10,10q�6�   $��Stretch=�6�   ��6�   �� *ActualHeight+ �� RelativeSource �� *Self+�� 5      -   5         ��Name$ PART_TITLEBAR��5      $
��Left=�6,   $��0q�6B   ���	#00000000$��Stretch=�6m   $��Stretch=�6�   6�   5      ]� 5   
   -   5        $ 
rightPanel��5      $��1��6(   $��1��68   $��1q�6E   $��Stretch=�6P   ��.  $��Stretch=�6�   ���#353535.+�5         Time_Owner.MonthCalendar  -   5          Name$ calendar��5   "   $	��Top=�64   $��8q�6I   $	��Top=�6T   $��Stretch=�6l      OnChange Recalculate6�      MaxElementsSelected$ 3��6�   ��6�   �� *ActualWidth+ �� *Self+6�   �� 5      -   5        $��comboBoxType��5      $	��Top=�6+   $	��Top=�6@   $��Stretch=�6X   $��
25,10,25,0q�6v    �� SelectedValuePath$ Value��6   �� DisplayMemberPath$ Value��65  ��6�   ��  �� Source %   Time_Owner.EnumerationExtension  *M� *local:StatisticType++ �� SelectedValue 6�   ��  �� ElementName$ window�� �� Path$ StatisticType�65  �� 5      -   5        $��Recalculate��5      $��Bottom=�6+   $��Center=�6C   $	��Top=�6`   $	��100��6x   $��5q�6�   ���	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�6�   $��16(�6�   
�������6  �� 5      -   5        $��listBoxTotalTime��5      $��0q�6.   $	��Top=�6B   $	��100��6W   $��Center=�6d   $��10,20q�6   
�������
������ ��6�   �� *Months+��5      �� 5      .R�5       �� 
�������$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�67   ��5!      `� 5"   "    �� StringFormat$ {0} Total is {1}h��6/   .1�5#   &   �� $ Title�6.   6=   �� 5$   &   $ 	TotalTime�6.    �� 	Converter 6?   8   2Time_Owner.TimeSpanHoursToStringConverterExtension  6t   5%   #   5'      5(      5*      5+      #  LiveCharts.Wpf.CartesianChart  5,   
   -	   5        $��chart��5,      $��1��6N   $��5q�6[   &   LiveCharts.Wpf.Charts.Base.Chart   	Hoverable .  $��Stretch=�6x   $��Stretch=�6�      Series 6*   �� *SeriesCollection+   AxisX 5.        LiveCharts.Wpf.Axis     Title$
 Date��6      Labels 6(   �� *Labels+6D      AxisY 51        $ Hours��6      LabelFormatter 6)   �� *	Formatter+6P   53      54      55      