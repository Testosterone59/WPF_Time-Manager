   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5   	       Time_Owner.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Time_Owner     5   	   -   5        $��window��5   �     � Title$  
Time Owner��6	   $	��744��6   $	��900��6)   ���	#00000000��. $��Proxima Nova Cn Rg)�6]    � AllowsTransparency .  � 
ResizeMode$ CanMinimize=�6�    � ShowInTaskbar .  � WindowStyle$
 None=�6�    � TaskbarItemInfo 5	      *  $System.Windows.Shell.TaskbarItemInfo  5
   
    � 	Resources 5         bvc��%   &	        �� 5   
   6'   5      .��5      � -   5         �Name$ gridMain��5      ���#2b2b2b$��Stretch=�62   $��Stretch=�6P    � ShowGridLines .  	 � RowDefinitions	 5   
   �� 5      $	��30* �6   �� 5      $	��29* �6   �� 5      $	��29* �6   �� 5      $
��174* �6   �� 5      $	��29* �6   �� 5      -   5        
 ��Name$
 rowDescription��5      $
��455* �64    � ColumnDefinitions 5   
   �� 5      $
��379* �6   �� 5      $
��323* �6   �� 5      $
��181* �6   �� 5      $	��17* �6   .+�5   
   �� -   5         ��Name$ contentDays��5   A   $��0��6   $��3��6#   $��5��60   $��Stretch=�6V   $��Stretch=�6t   $��0,0,0,0q�6�   ���#2b2b2b$��Visible=�6�   $��Disabled=�6�     ListBoxStyleDay#��[ 6  $��0q�6U  $��	0,-1,0, 0q�6i  ���	#FF353535��.  $��Stretch=�6�  �� 5   
   $��1��6   $��3��6    $��3��64   $��Stretch=�6A   $��Center=�6_   $
��10,0q�6�   $��Stretch=�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6�   ���#353535
�������$��1,1,0,1q�6   J� RenderTransformOrigin$	 0,0&�60  $��	Condensed&�6L  $��SemiBold"�6d  �� 5    
   -   5         ��Name$ taskDescription��5    G   $��1��6   $��3��6&   $��5��6:   $��Stretch=�6`   $��1,1,0,0q�6~   $��10q�6�   $��Stretch=�6�   ���#2b2b2b
�������$5��//Time Owner;component/Fonts/#Proxima Nova Cn Th)�6�   $��16(�6  $��Italic$�6+   �� 
IsReadOnly .  �� SelectionBrush �	#FF353535���	#FF353535$��0q�6�  " �� VerticalScrollBarVisibility$ Visible=�6�  . �5!      /� .T�5"      J� 5#      5$      �� 5%   
   -   5         ��Name$ labelInfoPanel��5%   A   $��1��6   $��3��6    $��2��64   $��1,1,0,1q�6Y   $��Stretch=�6j   $��Center=�6�   $
��15,0q�6�   $��Stretch=�6�   $5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��24(�6  $
��Bold"�6   ���#353535
�������$	 0,0&�6Z  �� 5&   
   -   5        $ labelInfoDay��5&   A   $��1��6   $��3��6    $��2��64   $��Stretch=�6W   $��Center=�6u   $��1,1,0,1q�6�   $
��10,0q�6�   $��Stretch=�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6  ���#353535
�������$	 0,0&�6F  $��	Condensed&�6b  $��SemiBold"�6z  �� 5'   
   $��1��6   $��3��6    $��4��64   $��Task description��6A   $��Stretch=�6\   $��Center=�6z   $
��10,0q�6�   $��Stretch=�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6  ���#353535
�������$��1,1,0,1q�6:  $	 0,0&�6K  $��	Condensed&�6g  $��SemiBold"�6  � 5(   
   -   5        $ gridInfoPanel��5(   ,   $��2��6   $��3��6   $��Stretch=�6C   $��Stretch=�6a    5)      �� 5*      $	��52* �6#   �� 5+      $	��30* �6#   �� 5,      $	��99* �6#   	 5.      �� 5/      $	��11* �6    �� 50      $	��57* �6    �� 51      $	��32* �6    �� 52      $	��32* �6    �� 53      $	��32* �6    .+�55      �� -	   5         ��Name$ textTimerStage��55   I   $��0��6   $��3��6(   $��1��6<   $��Stretch=�6a   $��0,0,0,0q�6   $
��Wrap=�6�   $	��OFF��6�   $��Stretch=�6�   $��51(�6�   
�������$
��Bold"�6�    �� TextAlignment$ Right=�6�   $5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�6  �� 56      -
   5        $ textTimerTime��56   5   $��3��6   $��2��6(   $��Stretch=�6L   $��0,0,0,0q�6j   $
��Wrap=�6{   $��00:00:00��6�   $��Stretch=�6�   $��24(�6�   
�������$
��Bold"�6�   $ Right=�6�   $5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�6  �� 57      -   5        $ textTimerTotalTime��57   I   $��0��6   $��3��6(   $��3��6<   $��Stretch=�6e   $��0,0,0,0q�6�   $
��Wrap=�6�   $��Time in total 00:00:00��6�   $��Stretch=�6�   $��16(�6�   
�������$
��Thin"�6  $ Right=�6   �� Padding$
 0, 5q�6+  $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6:  �� 58      -   5        $ textTimerTotalTimeMode��58   I   $��0��6   $��3��6(   $��4��6<   $��Stretch=�6i   $��0,0,0,0q�6�   $
��Wrap=�6�   $!��Time in total Mode 00:00:00��6�   $��Stretch=�6�   $��16(�6�   
�������$
��Thin"�6  $
 0, 5q�6  $ Right=�6-  $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6C     Time_Owner.ButtonImage  59      -   5          Name$ btnPlay��59   =   $��1��6    $��2��60   $��4,0,4,4q�6N      ImageDefault$ Images/btnPlayNormal.png��6_      ImagePressed$ Images/btnPlayPressed.png��6�   $��Stretch=�6�   $��Stretch=�6�      Click BtnPlayTimer6�     5:      -   5        $ btnStop��5:   =   $��1��6    $��2��60   $��4,0,4,4q�6N   $ Images/btnStopNormal.png��6_   $ Images/btnStopPressed.png��6�   $��Stretch=�6�   $��Stretch=�6�    BtnStopTimer6�   $y�Hidden=�6�   5;      &   System.Windows.Controls.Calendar  5<   
   -   5          Name$ calendar��5<   0   $��2��6   $��3��6#   $y�Hidden=�6B   $��Stretch=�6V   $��Stretch=�6t   $��1,0,0,2q�6�   �� 5=   
   -   5        $
 hand��5=   4   $��0��6   $��4��6    $��0��6C   $��Stretch=�6P   $��Stretch=�6n   $��
0, 0, 0, 1q�6�   $��Center=�6�   $
��10,0q�6�   $5��//Time Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��18(�6  ���#353535
�������$	 0,0&�6B  $��	Condensed&�6^  $
��Bold"�6v  ]� 5>   
   $��0��6   $��3��6$   $��0��68   $��Stretch=�6E   ��. $��Stretch=�6x   $��5,0,0,0q�6�   .+�5?        $��Right=�6    $ Images/btnCloseNormal.png��67   $  Images/btnClosePressed.png��6`    MinimizeToTrayClick6�   $��2,9,2,9q�6�   $��Stretch=�6�   ��6�   �� *ActualHeight+ �� RelativeSource �� *Self+  5@      $��Right=�6    $" Images/btnMinimizeNormal.png��67   $# Images/btnMinimizePressed.png��6c    MinimizeToTaskBarClick6�   $��	2,13,10,6q�6�   $��Stretch=�6�   ��6�   �� *ActualHeight+ �� *Self+�� 5A      $
��Left=�6   $��Stretch=�6*   $��Stretch=�6F   $��Images/btnClock.png��6�   $��0,5,0,5q�6�   $��UniformToFill=�6�   ��6d   �� *ActualHeight+ �� *Self+6�   �� 5B      -   5         ��Name$ PART_TITLEBAR��5B      $
��Left=�6,   $��0q�6B   ���	#00000000$��Stretch=�6m   $��Stretch=�6�   ._�5C      a� $	��100��6   5D      5E      ]� 5F   
   -   5         ]�Name$ dockModePanel��5F   1   $��2��6   $��4��6$   $y�Hidden=�6H   $��Stretch=�6\   ��.  $��Stretch=�6�   .+�5G      �� -   5         ��Name$ comboboxMode��5G      $��2,6,2,5q�6-   $��Stretch=�6>   $��Stretch=�6\   $��12(�6x    �� SelectedIndex$ 0��6�   $��Right=�6�   ��5H      �� 5I        �� EndPoint$	  0,1&�6*   ! �� 
StartPoint$	! 0,0&�69   .��5J      � " � Color$" 	#FFF0F0F0��6'   # � Offset$# 0Q�69   � 5K      $" White��6'   $# 1Q�65   5L      .@�5N      �� $	��Day��6   �� 5O      $
��Week��6   5P      �� 5Q      $��Stretch=�6   $��0,6,5,5q�66   $
��Wrap=�6G   $
��Mode��6[   $��Stretch=�6g   $��16(�6�   
�������$ Right=�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6�   $��Right=�6�   5R      � 5S   
   -   5        $ gridProfile��5S      $��0��6$   $��2��64   $��Stretch=�6A   $��2��6_   $��Stretch=�6p   $ � DataContext$ 6�   ��    Time_Owner.Profile%   data& �� Source#& Z% y�6�   �� *IsVisibleProfile+' �� 	Converter#' [  ( �� ElementName$( window��	 5T      �� 5U      $	��29* �6    �� 5V      $	��58* �6    �� 5W      $	��29* �6    �� 5X      $	��29* �6    �� 5Y      $	��29* �6    �� 5Z      $	��29* �6    .+�5\      �� -   5        $ labelProfile��5\      $��0��6*   $��0��6:   $��Stretch=�6G   $��Stretch=�6e   $��0,1,1,1q�6�   $��Profile��6�   $��Center=�6�   $
��10,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6  ���#353535
�������$	 0,0&�6H  $��	Condensed&�6d  $��SemiBold"�6|  ]� 5]      -   5        $ dockPanelProfile��5]      $��1��62   $��Stretch=�6?   ��. $��Stretch=�6r   .+�5^      �� $
��Left=�6   $��0,1,1,1q�6.   $��Stretch=�6?   $
��Fill=�6[   ��6j   �� *ActualHeight+ �� *Self+$ 6�   ��    Time_Owner.GlobalSettings)   dataSettings#& Z) ��6�   �� *PathImgProfile+� 5_      -   5        $ gridProfileData��5_      $��Stretch=�60   $��Stretch=�6N   $��1q�6j   ���#353535	 5`      �� 5a      $��* �6(   �� 5b      $��* �6(   .+�5d      �� $��0��6#   $��	10,1,0,-1q�60   $
��Left=�6C   * J� IsHitTestVisible* .  ���#2b2b2b$��Bottom=�6�   $��2��6�   ��6�   �� *ActualWidth+$( textBlockExperience���� 5e      $��0��6   $��Stretch=�6)   $��Stretch=�6E   $��Bottom=�6c   $��10,0,0,5q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6�   
�������$��0q�6�   .��5f      �� ��6$   �� *Level++ �� StringFormat$+ Worker Level {0}��5g      �� 5h      $��1��6   $��Stretch=�6)   $��Stretch=�6E   $	��Top=�6c   $��10,5,0,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6�   
�������$��0q�6�   .��5i      �� -   5        $ textBlockExperience��5i   $   ��5j      `� 5k   "   $+ Experience {0}/{1}��6/   .1�5l   &   �� , �� Path$, 
Experience�6.   �� 5m   &   $, ExperienceToNextLevel�6.   5n   #   5p      5q      5r      5s      �� 5t      $��0��6   $��2��6$   $��Stretch=�61   $��Stretch=�6O   $��0,1,1,1q�6k   $��Global goals��6|   $��Center=�6�   $
��10,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6  ���#353535
�������$	 0,0&�67  $��	Condensed&�6S  $��SemiBold"�6k     Time_Owner.GoalProfile  5u      -   Number$- 1��6G   $��3��6R   $��Stretch=�6_   $��Stretch=�6}   $��0,1,1,1q�6�   .   Goal. 6    �� *
Goals[0]+/ �� Mode$/ TwoWay=�6�     5v      $- 2��6G   $��4��6R   $��Stretch=�6_   $��Stretch=�6}   $��0,1,1,1q�6�   . 6    �� *
Goals[1]+$/ TwoWay=�6�     5w      $- 3��6G   $��5��6R   $��Stretch=�6_   $��Stretch=�6}   $��0,1,1,1q�6�   . 6    �� *
Goals[2]+$/ TwoWay=�6�   5x      ]� 5y   
   -   5        $ 
tasksPanel��5y      $��2��6(   ��. $��Stretch=�6J   $��Stretch=�6h   $��0,1,1,1q�6�   ���#353535.+�5z        -   5        $ 	btnDelete��5z       $��Right=�63   $$ Images/btnDeleteTaskNormal.png��6J   $% Images/btnDeleteTaskPressed.png��6x   $��Stretch=�6�   $��Stretch=�6�   $��0,6,29,6q�6�    BtnDeleteTasks6�   ��6
  �� *ActualHeight+ �� *Self+  5{      -   5        $ btnEdit��5{       $��Right=�61   $" Images/btnEditTaskNormal.png��6H   $# Images/btnEditTaskPressed.png��6t   $��Stretch=�6�   $��Stretch=�6�   $��0,5,5,5q�6�    BtnEditTask6�   ��6   �� *ActualHeight+ �� *Self+�� 5|      -   5        $ 
labelTasks��5|      $
��Left=�6(   $��Tasks��6>   $��Stretch=�6N   $��Stretch=�6l   $��0,0,0,2q�6�   $��Center=�6�   $
��10,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6  ���#353535
�������$	 0,0&�6=  $��	Condensed&�6Y  $��SemiBold"�6q  $	��378��6�  5}      ]� 5~   
   -   5        $ 	underHead��5~      $��1��6'   $��2��67   $��2��6K   $��Stretch=�6X   ��.  $��Stretch=�6�   .+�5      �� -   5        $��Check Calendar��5      $��Right=�6.   $��Stretch=�6]   $��0,0,0,0q�6{   $��Center=�6�   
�������$��14(�6�   ���#47a556
�������  ButtonRoundCorner#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6  $	��111��6Z  5�      ]� 5�   
   -   5        $ toolbarDockPanel��5�      $��0��6.   $��4��6>   $��1��6R   $��Stretch=�6_   ��.  $��0,1,0,1q�6�   $��Stretch=�6�   ���#353535.+�5�      �� -    5        $
��File��5�      $
��Left=�6$   $��Stretch=�6_   $��10,4,0,2q�6}   $��Center=�6�   
�������$��14(�6�   ���#47a556���#e7e7e7#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6"  $��40��6_  0 � ContextMenu0 5�      �� 5�      ���#e7e7e7.@�5�      m� -!   5        $
��Info��5�   #   ���#353535���#2b2b2b$��1q�6\   6p   m� 5�      -"   5        $
��Exit��5�   #   ���#353535���#2b2b2b$��1q�6\   6p   5�      5�      �� 5�      -#   5        $��Profile��5�      $
��Left=�6'   $��Stretch=�6T   $��5,4,0,2q�6r   $��Center=�6�   
�������$��14(�6�   ���#47a556���#e7e7e7#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6  $��50��6S  �� 5�      -$   5        $��
Statistics��5�      $
��Left=�6*   $��Stretch=�6X   $��5,4,0,2q�6v   $��Center=�6�   
�������$��14(�6�   ���#47a556���#e7e7e7#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6  $��65��6W  �� 5�      -%   5        $��
Timer Mode��5�      $
��Left=�6*   $��Stretch=�6e   $��5,4,0,2q�6�   $��Center=�6�   
�������$��14(�6�   ���#47a556���#e7e7e7#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6'  $��75��6d  0 5�      �� 5�      ���#353535.@�5�      m�   MyMenuItemStyle#��[ 6#   ��5�      �� 5�   "   ���#353535.+�5�   &      Time_Owner.ModeChanger  ���#353535$��0,1,0,1q�6M   1   	LeftImage$1 Images\imgPomodoro.png��6^   2   
RightImage$2 Images\imgTimer.png��6�   3   OnChange3 ChangeModeOfWork6�   4   LeftToolTip$4 Set the Pomodoro mode��6�   5   RightToolTip$5 Set the Timer mode��6�   $��30��6  $	��120��6  5�   #   5�      5�      5�      �� 5�      -&   5        $��Settings��5�      $
��Left=�6(   $��Stretch=�6T   $��5,4,0,2q�6r   $��Center=�6�   
�������$��14(�6�   ���#47a556���#e7e7e7#��[ 6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6  $��55��6S  5�      5�      5�      