   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5   	       Time_Owner.GoalWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Time_Owner     5   	   -   5          �Name$  window��5       � Title$ 
GoalWindow��6	   $	��130��6,   $	��400��69   ���#353535 � WindowStartupLocation$ CenterScreen=�6Z   $��2q�6   
������� � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      � $��Stretch=�6   $��Stretch=�6)    � ColumnDefinitions 5
   
   �� 5      $
��120* �6   �� 5      $
��200* �6   �� 5      $
��120* �6    � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��25* �6   �� 5      $��6* �6   �� 5      $	��25* �6   �� 5      $	��14* �6   �� 5      $	��25* �6   .+�5   
   �� $
��Name��6   $��0��6   $��1��6/   $��Stretch=�6<   $��Center=�6Z   $��Stretch=�6|   ���#2b2b2b$
��15,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6�   
�������6  �� 5   
   $��Date of end��6   $��0��6&   $��3��66   $��Stretch=�6C   $��Center=�6a   $��Stretch=�6�   ���#2b2b2b$
��15,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6   
�������6  �� 5   
   -   5         ��Name$ goalNameText��5      $��1��6(   $��2��68   $��1��6L   $��Stretch=�6Y   $��Center=�6w   $��5q�6�   $��0,0,10,0q�6�    �� TextWrapping$
 Wrap=�6�   $��Stretch=�6�   ���#2b2b2b
�������	 �� SelectionBrush
	 �����$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Lt)�6A  $��16(�6~  ��6�   �� 
 �� Path$

 Name�6�  �� 5   
   -   5        $��Ok��5      $��0��6   $��5��6.   $��
10,0,30,10q�6;   $��Stretch=�6O   $��Stretch=�6m   ���	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�6�   $��14(�6�   
�������6�   �� 5   
   -   5        $��Cancel��5      $��2��6"   $��5��62   $��Stretch=�6?   $��
30,0,10,10q�6]   $��Stretch=�6q   ���	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�6�   $��14(�6�   
�������6  (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
datePicker��5      $��1��6'   $��3��67   $
��Left=�6x   $��Center=�6�   $��24��6�   $��0,2,0,3q�6�   $	��100��6�   |�.     SelectedDate 6D   �� $
 dateEnd� �� Mode$ TwoWay=�6�   5      5      