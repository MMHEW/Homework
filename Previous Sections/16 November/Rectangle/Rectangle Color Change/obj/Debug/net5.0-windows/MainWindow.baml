   M S B A M L   `   `   `  ����Q  MRectangle Color Change, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Rectangle_Color_ChangeRectangle_Color_Change  5   	   '    !Rectangle_Color_Change.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Rectangle_Color_Change     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ myRectangle��5      $��0��6)   $��0��69   $��2��6F   $	��100��6Z   
���   �$	��100��6u   
���   �6�   �� 5   
   -   5        $ myRectangle1��5      $��2��6*   $��0��6:   $��2��6G   $	��100��6[   
���   �$	��100��6v   ��6�   ��  �� ElementName$ 	textBlock�� �� Path$
 Text��� 5   
   -   5         ��Name$ 	textBlock��5   1   $��0��6   $��1��6$   $�� ��6D   $��
UltraLight"�6L   $��Oblique$�6d   �� 5   
   -   5        $��0��5   %   $��1��65   
���  ��$��Change To Red��6S   6m   �� 5   
   -   5        $��1��5   '   $��1��67   
��� � �$��Change To Green��6W   �� 5   
   -   5        $��2��5   +   $��1��6;   
�������$��Change To Alice Blue��6_   �� 5   
   -   5        $��3��5   &   $��1��66   
�������$��Change To Pink��6U   5      5       