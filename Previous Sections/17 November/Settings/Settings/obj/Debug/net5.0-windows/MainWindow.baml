   M S B A M L   `   `   `  ����C  ?Settings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SettingsSettings  5   	       Settings.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Settings     5   	     � Title$#  Super Anime Fun Time Settings��5   	   $	��450��6/   $	��800��6<   .��5	      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��4��6   $��40,75,40,75q�6&   .+�5      �� -   5        $��
Settings 1��5      $�� 25,25,25,25q�6A   $��50��6W   $	��100��6c   �� 5      -   5        $��
Settings 2��5      $�� 25,25,25,25q�6B   $��50��6X   $	��100��6d   �� 5      -   5        $��
Settings 3��5      $��25,25,25,50q�6B   $��50��6W   $	��100��6c   5      �� 5   
   $��1��6   $��0��6    $��
Brightness��6-   �� 5   
   $��1��6   $��1��6    $��
Difficulty��6-   �� 5    
   $��1��6   $��2��6    $��Hints��6-   �� 5$   
   -   5         ��Name$ slider1��5$      $��2��6"   $��0��62    �� IsSnapToTickEnabled$
 True��6?    � Minimum$ 0Q�6Z    � Maximum$	 100Q�6f    � Value 6t   �� *Brightness0+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5'   
   -   5        
 ��Name$
 stack1��5'      $��2��6&   $��1��66    �� Orientation$ 
Horizontal=�6C   $��10,10,10,10q�6\   .+�5(      	� $��2��6   $��1��6+   $
��Easy��68   $��10,10,10,10q�6G    d� 	IsChecked 6\   �� *DifficultyE0+$ TwoWay=�$	 PropertyChanged=�	� 5)      $��2��6   $��1��6*   $��Medium��67   $��10,10,10,10q�6H    6]   �� *DifficultyM0+$ TwoWay=�$	 PropertyChanged=�	� 5*      $��2��6   $��1��6*   $
��Hard��67   $��10,10,10,10q�6G    6\   �� *DifficultyH0+$ TwoWay=�$	 PropertyChanged=�5,      �� 5.   
   -   5         ��Name$ check1��5.      $��2��6#   $��2��60   $�� ��6@   $��10,10,10,10q�6K    6`   �� *Hints0+$ TwoWay=�$	 PropertyChanged=�5L      5M      