   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5          Time_Owner.Task   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Time_Owner     5      $
��auto��5   6   $��Stretch=�6C     � 	Resources  5	      9   3Time_Owner.IntNotZeroToVisibilityConverterExtension  5
   
      Keynzc  6>   .��5      � -   5        $
��grid��5      $��0,0,0,0q�6   $��Stretch=�6(   $��Stretch=�6F   ���	#FF393939��6y   ��    Time_Owner.GlobalSettings   ElementTasksWidth �� Source# Z ��6�   ��    ElementTasksHeight# Z .+�5   
   � -   5        $��	otherGrid��5      $��Stretch=�6    $��Stretch=�6<   $��	10,0,13,0q�6Z    � ColumnDefinitions 5      �� 5      $	��27* �6#   �� 5      $
��259* �6#   �� 5      $	��54* �6#    � ContextMenu 5      �� 5      .@�5      m� -   5        $
��Edit��5      6-   m� 5      -   5        $��Delete��5      6/   m� 5      -   5        $
��Copy��5      6-   m� 5      -   5        $��Copy into ...��5      66   5      .+�5      �� -   5         ��Name$ checkBox��5      $��0��6)   $��0,4,0,4q�69   $��Stretch=�6J    J� RenderTransformOrigin$ 0.5,0.5&�6f     myCheckboxStyle#��[ 6�   ��6�   �� *ActualHeight+ �� RelativeSource �� *Self+	 d� 	IsChecked	 6�   �� *IsDone+�� 5      -   5        
 ��Name$
 textName��5   $   $��1��6   $��Stretch=�66   $��3,0,3,0q�6T   $��Stretch=�6�   $��16(�6�   
�������$
��Thin"�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6�   $
��0, 0q�6  $��Center=�6  ��6e   �� *
TaskName+6  ]� 5      -	   5        $��dockPanelTomato��5      $��3��6/   $��Stretch=�6?   ��. $��Stretch=�6r   y�6�   �� *
Tomatoes+  nzc �� 	Converter# [ .+�5         Time_Owner.Tomato  -
   5          Name$ point��5      $��Right=�6.   $	��0,6q�6E   $��Stretch=�6R   $��Stretch=�6p   �� 5      -   5        $
 	textCount��5      $
��Left=�6+   $��Stretch=�6A   $��0,0,0,0q�6_   $��Stretch=�6�   $��18(�6�   
�������$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6�   $��Center=�6   $��Center=�6D  $
��0, 0q�6f  ��6p   ��  �� StringFormat$	 {0}�� �� Path$ Tomatoes�6f  5       5!      5"      5#      