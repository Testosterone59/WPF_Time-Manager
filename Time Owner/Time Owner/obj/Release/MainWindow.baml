   M S B A M L   `   `   `  ���� E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner      Time_Owner.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Time_Owner     -   $��window��  � Title$  
Time Owner��$	��744��$	��900�����	#00000000��. $��Proxima Nova Cn Rg)� � AllowsTransparency .  � 
ResizeMode$ CanMinimize=� � ShowInTaskbar .  � WindowStyle$
 None=� � TaskbarItemInfo *  $System.Windows.Shell.TaskbarItemInfo   � 	Resources    bvc��%   &	        �� .��� -    �Name$ gridMain�����#2b2b2b$��Stretch=�$��Stretch=� � ShowGridLines .  	 � RowDefinitions	 �� $	��30* ��� $	��29* ��� $	��29* ��� $
��174* ��� $	��29* ��� -   
 ��Name$
 rowDescription��$
��455* � � ColumnDefinitions �� $
��379* ��� $
��323* ��� $
��181* ��� $	��17* �.+��� -    ��Name$ contentDays��$��0��$��3��$��5��$��Stretch=�$��Stretch=�$��0,0,0,0q����#2b2b2b$��Visible=�$��Disabled=�  ListBoxStyleDay#��[ $��0q�$��	0,-1,0, 0q����	#FF353535��.  $��Stretch=��� $��1��$��3��$��3��$��Stretch=�$��Center=�$
��10,0q�$��Stretch=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$��1,1,0,1q� J� RenderTransformOrigin$	 0,0&�$��	Condensed&�$��SemiBold"��� -    ��Name$ taskDescription��$��1��$��3��$��5��$��Stretch=�$��1,1,0,0q�$��10q�$��Stretch=����#2b2b2b
�������$5��//Time Owner;component/Fonts/#Proxima Nova Cn Th)�$��16(�$��Italic$� �� 
IsReadOnly .  �� SelectionBrush �	#FF353535���	#FF353535$��0q�" �� VerticalScrollBarVisibility$ Visible=�. �/� .T�J� �� -    ��Name$ labelInfoPanel��$��1��$��3��$��2��$��1,1,0,1q�$��Stretch=�$��Center=�$
��15,0q�$��Stretch=�$5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�$��24(�$
��Bold"����#353535
�������$	 0,0&��� -   $ labelInfoDay��$��1��$��3��$��2��$��Stretch=�$��Center=�$��1,1,0,1q�$
��10,0q�$��Stretch=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"��� $��1��$��3��$��4��$��Task description��$��Stretch=�$��Center=�$
��10,0q�$��Stretch=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$��1,1,0,1q�$	 0,0&�$��	Condensed&�$��SemiBold"�� -   $ gridInfoPanel��$��2��$��3��$��Stretch=�$��Stretch=� �� $	��52* ��� $	��30* ��� $	��99* �	 �� $	��11* ��� $	��57* ��� $	��32* ��� $	��32* ��� $	��32* �.+��� -	    ��Name$ textTimerStage��$��0��$��3��$��1��$��Stretch=�$��0,0,0,0q�$
��Wrap=�$	��OFF��$��Stretch=�$��51(�
�������$
��Bold"� �� TextAlignment$ Right=�$5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)��� -
   $ textTimerTime��$��3��$��2��$��Stretch=�$��0,0,0,0q�$
��Wrap=�$��00:00:00��$��Stretch=�$��24(�
�������$
��Bold"�$ Right=�$5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)��� -   $ textTimerTotalTime��$��0��$��3��$��3��$��Stretch=�$��0,0,0,0q�$
��Wrap=�$��Time in total 00:00:00��$��Stretch=�$��16(�
�������$
��Thin"�$ Right=� �� Padding$
 0, 5q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)��� -   $ textTimerTotalTimeMode��$��0��$��3��$��4��$��Stretch=�$��0,0,0,0q�$
��Wrap=�$!��Time in total Mode 00:00:00��$��Stretch=�$��16(�
�������$
��Thin"�$
 0, 5q�$ Right=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�   Time_Owner.ButtonImage  -     Name$ btnPlay��$��1��$��2��$��4,0,4,4q�   ImageDefault$ Images/btnPlayNormal.png��   ImagePressed$ Images/btnPlayPressed.png��$��Stretch=�$��Stretch=�   Click BtnPlayTimer  -   $ btnStop��$��1��$��2��$��4,0,4,4q�$ Images/btnStopNormal.png��$ Images/btnStopPressed.png��$��Stretch=�$��Stretch=� BtnStopTimer$y�Hidden=�&   System.Windows.Controls.Calendar  -     Name$ calendar��$��2��$��3��$y�Hidden=�$��Stretch=�$��Stretch=�$��1,0,0,2q��� -   $
 hand��$��0��$��4��$��0��$��Stretch=�$��Stretch=�$��
0, 0, 0, 1q�$��Center=�$
��10,0q�$5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�$��18(����#353535
�������$	 0,0&�$��	Condensed&�$
��Bold"�]� $��0��$��3��$��0��$��Stretch=���. $��Stretch=�$��5,0,0,0q�.+�  $��Right=�$ Images/btnCloseNormal.png��$  Images/btnClosePressed.png�� MinimizeToTrayClick$��2,9,2,9q�$��Stretch=����� *ActualHeight+ �� RelativeSource �� *Self+  $��Right=�$" Images/btnMinimizeNormal.png��$# Images/btnMinimizePressed.png�� MinimizeToTaskBarClick$��	2,13,10,6q�$��Stretch=����� *ActualHeight+ �� *Self+�� $
��Left=�$��Stretch=�$��Stretch=�$��Images/btnClock.png��$��0,5,0,5q�$��UniformToFill=����� *ActualHeight+ �� *Self+�� -    ��Name$ PART_TITLEBAR��$
��Left=�$��0q����	#00000000$��Stretch=�$��Stretch=�._�a� $	��100��]� -    ]�Name$ dockModePanel��$��2��$��4��$y�Hidden=�$��Stretch=���.  $��Stretch=�.+��� -    ��Name$ comboboxMode��$��2,6,2,5q�$��Stretch=�$��Stretch=�$��12(� �� SelectedIndex$ 0��$��Right=�����   �� EndPoint$	  0,1&�! �� 
StartPoint$	! 0,0&�.��� " � Color$" 	#FFF0F0F0��# � Offset$# 0Q�� $" White��$# 1Q�.@��� $	��Day���� $
��Week���� $��Stretch=�$��0,6,5,5q�$
��Wrap=�$
��Mode��$��Stretch=�$��16(�
�������$ Right=�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��Right=�� -   $ gridProfile��$��0��$��2��$��Stretch=�$��2��$��Stretch=�$ � DataContext$ ��    Time_Owner.Profile%   data& �� Source#& Z% y��� *IsVisibleProfile+' �� 	Converter#' [  ( �� ElementName$( window��	 �� $	��29* ��� $	��58* ��� $	��29* ��� $	��29* ��� $	��29* ��� $	��29* �.+��� -   $ labelProfile��$��0��$��0��$��Stretch=�$��Stretch=�$��0,1,1,1q�$��Profile��$��Center=�$
��10,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"�]� -   $ dockPanelProfile��$��1��$��Stretch=���. $��Stretch=�.+��� $
��Left=�$��0,1,1,1q�$��Stretch=�$
��Fill=����� *ActualHeight+ �� *Self+$ ��    Time_Owner.GlobalSettings)   dataSettings#& Z) ���� *PathImgProfile+� -   $ gridProfileData��$��Stretch=�$��Stretch=�$��1q����#353535	 �� $��* ��� $��* �.+��� $��0��$��	10,1,0,-1q�$
��Left=�* J� IsHitTestVisible* .  ���#2b2b2b$��Bottom=�$��2������ *ActualWidth+$( textBlockExperience���� $��0��$��Stretch=�$��Stretch=�$��Bottom=�$��10,0,0,5q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(�
�������$��0q�.���� ���� *Level++ �� StringFormat$+ Worker Level {0}���� $��1��$��Stretch=�$��Stretch=�$	��Top=�$��10,5,0,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(�
�������$��0q�.���� -   $ textBlockExperience����`� $+ Experience {0}/{1}��.1��� , �� Path$, 
Experience��� $, ExperienceToNextLevel��� $��0��$��2��$��Stretch=�$��Stretch=�$��0,1,1,1q�$��Global goals��$��Center=�$
��10,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"�   Time_Owner.GoalProfile  -   Number$- 1��$��3��$��Stretch=�$��Stretch=�$��0,1,1,1q�.   Goal. �� *
Goals[0]+/ �� Mode$/ TwoWay=�  $- 2��$��4��$��Stretch=�$��Stretch=�$��0,1,1,1q�. �� *
Goals[1]+$/ TwoWay=�  $- 3��$��5��$��Stretch=�$��Stretch=�$��0,1,1,1q�. �� *
Goals[2]+$/ TwoWay=�]� -   $ 
tasksPanel��$��2����. $��Stretch=�$��Stretch=�$��0,1,1,1q����#353535.+�  -   $ 	btnDelete��$��Right=�$$ Images/btnDeleteTaskNormal.png��$% Images/btnDeleteTaskPressed.png��$��Stretch=�$��Stretch=�$��0,6,29,6q� BtnDeleteTasks���� *ActualHeight+ �� *Self+  -   $ btnEdit��$��Right=�$" Images/btnEditTaskNormal.png��$# Images/btnEditTaskPressed.png��$��Stretch=�$��Stretch=�$��0,5,5,5q� BtnEditTask���� *ActualHeight+ �� *Self+�� -   $ 
labelTasks��$
��Left=�$��Tasks��$��Stretch=�$��Stretch=�$��0,0,0,2q�$��Center=�$
��10,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(����#353535
�������$	 0,0&�$��	Condensed&�$��SemiBold"�$	��378��]� -   $ 	underHead��$��1��$��2��$��2��$��Stretch=���.  $��Stretch=�.+��� -   $��Check Calendar��$��Right=�$��Stretch=�$��0,0,0,0q�$��Center=�
�������$��14(����#47a556
�������  ButtonRoundCorner#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$	��111��]� -   $ toolbarDockPanel��$��0��$��4��$��1��$��Stretch=���.  $��0,1,0,1q�$��Stretch=����#353535.+��� -    $
��File��$
��Left=�$��Stretch=�$��10,4,0,2q�$��Center=�
�������$��14(����#47a556���#e7e7e7#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��40��0 � ContextMenu0 �� ���#e7e7e7.@�m� -!   $
��Info�����#353535���#2b2b2b$��1q�m� -"   $
��Exit�����#353535���#2b2b2b$��1q��� -#   $��Profile��$
��Left=�$��Stretch=�$��5,4,0,2q�$��Center=�
�������$��14(����#47a556���#e7e7e7#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��50���� -$   $��
Statistics��$
��Left=�$��Stretch=�$��5,4,0,2q�$��Center=�
�������$��14(����#47a556���#e7e7e7#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��65���� -%   $��
Timer Mode��$
��Left=�$��Stretch=�$��5,4,0,2q�$��Center=�
�������$��14(����#47a556���#e7e7e7#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��75��0 �� ���#353535.@�m�   MyMenuItemStyle#��[ ���� ���#353535.+�   Time_Owner.ModeChanger  ���#353535$��0,1,0,1q�1   	LeftImage$1 Images\imgPomodoro.png��2   
RightImage$2 Images\imgTimer.png��3   OnChange3 ChangeModeOfWork4   LeftToolTip$4 Set the Pomodoro mode��5   RightToolTip$5 Set the Timer mode��$��30��$	��120���� -&   $��Settings��$
��Left=�$��Stretch=�$��5,4,0,2q�$��Center=�
�������$��14(����#47a556���#e7e7e7#��[ $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��55��