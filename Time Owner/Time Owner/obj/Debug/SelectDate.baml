   M S B A M L   `   `   `  ����E  ATime_Owner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Time_Owner
Time_Owner  5   	       Time_Owner.SelectDate   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Time_Owner     5   	     � Title$  	SelectDay��5   	   $	��250��6   $	��215��6(   ���#2b2b2b$��2q�6J   
�������$��Proxima Nova Cn Rg)�6r    � 
ResizeMode$ NoResize=�6�    � Icon$ icon.ico��6�    � WindowStartupLocation$ CenterOwner=�6�    � WindowStyle$
 None=�6�   .��5	      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5
   
   �� 5      $	��30* �6   �� 5      $
��180* �6   �� 5      $	��30* �6   .+�5   
   &   System.Windows.Controls.Calendar  -   5        $��calendar��5      $��1��6#   $��Center=�60   $��Center=�6M      SelectionMode$ MultipleRange=�6h      DisplayMode$
 Year=�6�    � ToolTip$Q KYou can select more dates if you're pressing 'Ctrl' while you're selecting.��6�   �� 5   
   -   5        $��Ok��5      $��3��6   $��Center=�6+   $	��0,4q�6H   $��Stretch=�6U   $��75��6q   ���	#FF414141$5��//Time_Owner;component/Fonts/#Proxima Nova Cn Th)�6�   $��16(�6�   
�������6�   �� 5   
   $��0��6   $��Stretch=�6   $��Stretch=�6;   $��Select Date��6W   $��Center=�6m   $
��20,0q�6�   $5��//Time_Owner;component/Fonts/#Proxima Nova Cn Rg)�6�   $��16(�6�   ���#353535
�������	 J� RenderTransformOrigin$		 0,0&�6  $��	Condensed&�6-  $��SemiBold"�6E  
 J� IsHitTestVisible
 .  6[  ]� 5   
   $��0��6   $��Stretch=�6!   ��. $��Stretch=�6T   .+�5      �� -   5         ��Name$ 
PART_CLOSE��5      $��Right=�6)   $��Stretch=�6@   $��2,9,5,9q�6^   $��Stretch=�6�   $��22��6�   ��5      �� 5       �� 
TargetType" ��6&   .R�5      ��  ��Name$
 img1��6    $��Images/btnCloseNormal.png��6.    �� Triggers 5      P� 5       P� Property � �� P� Value . . �5   "   ��  �� 
TargetName$
 img1��6)    �� Property � �� �� Value$7 1pack://application:,,,/Images/btnClosePressed.png��5   %   5      5      5       �� 5!      -   5         ��Name$ border��5!      $
��Left=�6%   ���	#00000000$��0q�6R   $��Stretch=�6f   $��Stretch=�6�   ._�5"         Time_Owner.ButtonImage  $	��100��6$   5#      5$      5&      5'      