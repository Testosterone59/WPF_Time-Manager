   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5          Time_Owner.GoalProfile   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Time_Owner     5      -   5        $��goalProfile��5   6   .��5	      � $��5,0,0,0q�6   .+�5
   
   ]� -   5          ]�Name$  dockPanelMain��5
      $��Stretch=�6+   ��. $��Stretch=�6^   .+�5      � $��1q�6   $
��Left=�6   $��Stretch=�64   $
��Left=�6P   ��6k   �� *ActualHeight+ �� RelativeSource �� *Self+.+�5      A� $��2q�6   
�������6%   �� 5      $��Stretch=�6   $��Center=�66   $��Center=�6Z   $��Stretch=�6|   
�������$��14(�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   .��5      ��  �� TextAlignment$ Center=�6Q   ��6    �� *Number+ �� ElementName$ goalProfile��6Q   5      5      � 5      -   5         �Name$ gridMain��5      $
��Left=�6%   $��Stretch=�6;   $��Stretch=�6W   .+�5      ]� -   5        $  dockPanelEmpty��5      ���#353535$��Stretch=�6I   ��. $��Stretch=�6|   $y�Visible=�6�   $��1,0,0,0q�6�   .+�5         Time_Owner.ButtonImage  $��Right=�6(      ImageDefault$! Images\btnAddTaskNormal.png��6?      ImagePressed$" Images\btnAddTaskPressed.png��6j      Click
 BtnAdd6�   $��Stretch=�6�   $��0,6,5,6q�6  ��6�   �� *ActualHeight+ �� *Self+6  �� 5      $��Empty��6   $
��Left=�6,   $��Stretch=�6B   $��Stretch=�6`   $
��Left=�6|   $��Center=�6�   $
��10,0q�6�   
�������$��14(�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   5      ]� 5      -   5        $  	dockPanel��5      ���#353535$��Stretch=�6D   ��. $��Stretch=�6w   $��1,0,0,0q�6�   $y�Hidden=�6�   .+�5        $��Right=�6(   $$ Images\btnDeleteTaskNormal.png��6?   $% Images\btnDeleteTaskPressed.png��6m    	BtnRemove6�   $��Stretch=�6�   $��0,6,5,6q�6  ��6�   �� *ActualHeight+ �� *Self+6  �� 5      -   5         ��Name$ 	labelTime��5      $��Right=�6/   $��0,0,10,0q�6�   $��Stretch=�6�   $��Stretch=�6�   $
��Left=�6�   $��Center=�6�   $
��10,0q�6  
�������$��14(�68  $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6F  ��6F   �� *Goal.remainingTime+$ goalProfile��6F  �� 5      $��Right=�6   $��0,6,3,6q�63   $��Stretch=�6D   $��Stretch=�6b   $��Images/btnClock.png��6~   $
��Fill=�6�   ��6�   �� *ActualHeight+ �� *Self+�� 5      -   5        $ 	labelName��5      $��Right=�6/   $��0,0,5,0q�6}   $��Stretch=�6�   $��Stretch=�6�   $
��Left=�6�   $��Center=�6�   $
��10,0q�6  
�������$��14(�6.  $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6<  ��6F   �� *	Goal.Name+$ goalProfile��6<  5      	 � ContextMenu	 5      �� 5      .@�5      m� -   5        $
��Edit��5   #   61   5      5!      5"      5#      5$      