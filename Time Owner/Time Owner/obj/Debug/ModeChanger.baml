   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5          Time_Owner.ModeChanger   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Time_Owner     5      -   5        $��element��5        � 	Resources  5	         bc��%   &	        �� 5
   
   6   5      .��5      �  � DataContext 6   ��  �� ElementName$ element�� � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��100* �6   �� 5      $	��50* �6   .+�5   
      Time_Owner.ButtonImage  -   5          Name$ leftBtn��5      $��0��6-   $��4q�6=   $��Stretch=�6H   $��Stretch=�6f      Click ButtonLeft_Click6�      ImageDefault 6�   �� *	LeftImage+   ImagePressed 6�   �� *	LeftImage+ � ToolTip 6�   �� $ element��	 �� Path$	 LeftToolTip�  5   
   -   5        $ rightBtn��5      $��2��6.   $��4q�6>   $��Stretch=�6I   $��Stretch=�6g    ButtonRight_Click6�    6�   �� *
RightImage+ 6�   �� *
RightImage+ 6�   �� $ element��$	 RightToolTip�A� 5   
   -   5        
 A�Name$
 elipseOutside_Left��5      $��1��6.   ���#2b2b2b$��2,4,2,4q�6M   $
��Left=�6^   $��Stretch=�6y   ��6�   �� *ActualHeight+ �� RelativeSource �� *Self+A� 5   
   -   5        $
 elipseOutside_Right��5      $��1��6/   ���#2b2b2b$��2,4,2,4q�6N   $��Right=�6_   $��Stretch=�6{   ��6�   �� *ActualHeight+ �� *Self+�� 5   
   -   5         ��Name$ rectangleCenter��5      $��1��6-   ���#2b2b2b$��2,4,2,4q�6L   $��Center=�6]   $��Stretch=�6z   ��6�   �� $ element��$	 ActualWidth� �� 	Converter $   Time_Owner.PercentageConverter   �� ConverterParameter$
 0,28��A� 5   
   -   5        $
 elipseInside��5      $��1��6(   ���#e7e7e7$��4q�6G   $
��Left=�6R   $��Center=�65  ��6m   �� *ActualHeight+ �� *Self+��6�   �� $ rectangleCenter��$	 ActualHeight�   $	 0,9��65  5      5      