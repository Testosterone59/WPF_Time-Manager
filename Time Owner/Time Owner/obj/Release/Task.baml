   M S B A M L   `   `   `  ���� E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner      Time_Owner.Task   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:Time_Owner     $
��auto��$��Stretch=�  � 	Resources  9   3Time_Owner.IntNotZeroToVisibilityConverterExtension     Keynzc  .��� -   $
��grid��$��0,0,0,0q�$��Stretch=�$��Stretch=����	#FF393939����    Time_Owner.GlobalSettings   ElementTasksWidth �� Source# Z ����    ElementTasksHeight# Z .+�� -   $��	otherGrid��$��Stretch=�$��Stretch=�$��	10,0,13,0q� � ColumnDefinitions �� $	��27* ��� $
��259* ��� $	��54* � � ContextMenu �� .@�m� -   $
��Edit��m� -   $��Delete��m� -   $
��Copy��m� -   $��Copy into ...��.+��� -    ��Name$ checkBox��$��0��$��0,4,0,4q�$��Stretch=� J� RenderTransformOrigin$ 0.5,0.5&�  myCheckboxStyle#��[ ���� *ActualHeight+ �� RelativeSource �� *Self+	 d� 	IsChecked	 �� *IsDone+�� -   
 ��Name$
 textName��$��1��$��Stretch=�$��3,0,3,0q�$��Stretch=�$��16(�
�������$
��Thin"�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$
��0, 0q�$��Center=����� *
TaskName+]� -	   $��dockPanelTomato��$��3��$��Stretch=���. $��Stretch=�y��� *
Tomatoes+  nzc �� 	Converter# [ .+�   Time_Owner.Tomato  -
     Name$ point��$��Right=�$	��0,6q�$��Stretch=�$��Stretch=��� -   $
 	textCount��$
��Left=�$��Stretch=�$��0,0,0,0q�$��Stretch=�$��18(�
�������$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��Center=�$��Center=�$
��0, 0q�����  �� StringFormat$	 {0}�� �� Path$ Tomatoes�