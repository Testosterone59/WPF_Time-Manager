   M S B A M L   `   `   `  ���� E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner      Time_Owner.GoalWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Time_Owner     -     �Name$  window�� � Title$ 
GoalWindow��$	��130��$	��400�����#353535 � WindowStartupLocation$ CenterScreen=�$��2q�
������� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.��� $��Stretch=�$��Stretch=� � ColumnDefinitions �� $
��120* ��� $
��200* ��� $
��120* � � RowDefinitions �� $��5* ��� $	��25* ��� $��6* ��� $	��25* ��� $	��14* ��� $	��25* �.+��� $
��Name��$��0��$��1��$��Stretch=�$��Center=�$��Stretch=����#2b2b2b$
��15,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(�
��������� $��Date of end��$��0��$��3��$��Stretch=�$��Center=�$��Stretch=����#2b2b2b$
��15,0q�$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�$��16(�
��������� -    ��Name$ goalNameText��$��1��$��2��$��1��$��Stretch=�$��Center=�$��5q�$��0,0,10,0q� �� TextWrapping$
 Wrap=�$��Stretch=����#2b2b2b
�������	 �� SelectionBrush
	 �����$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�$��16(����� 
 �� Path$

 Name��� -   $��Ok��$��0��$��5��$��
10,0,30,10q�$��Stretch=�$��Stretch=����	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�$��14(�
��������� -   $��Cancel��$��2��$��5��$��Stretch=�$��
30,0,10,10q�$��Stretch=����	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�$��14(�
�������(  "System.Windows.Controls.DatePicker  -   $��
datePicker��$��1��$��3��$
��Left=�$��Center=�$��24��$��0,2,0,3q�$	��100��|�.     SelectedDate �� $
 dateEnd� �� Mode$ TwoWay=�