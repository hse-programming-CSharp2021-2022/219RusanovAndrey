   M S B A M L   `   `   `  ����C  ?Task7_12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Task7_12Task7_12  5   	       Task7_12.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Task7_12     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��400��6)   .��5	      � $��Center=�6   
����ح�$��Center=�6?    � ShowGridLines$
 True��6Z   $	��250��6o   $	��250��6�    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��sliderV��5   .   $��0��6   $��0��6    � Minimum$ 0Q�6=    � Maximum$	 200Q�6I    �� Orientation$ Vertical=�6W   $��10q�6o   6{   �� 5   
   -   5        $��canvas��5   .   $��0��6   $��1��6   
�������.+�5      � -   5        $��polyline��5      
���   �$��10��66   6M   5      �� 5   
   -   5        $��sliderH��5   .   $��1��6   $��1��6   $ 0Q�6=   $	 200Q�6L   $ 
Horizontal=�6Z   $��10q�6s   6   �� 5   
   -   5        $��button��5      $��Clear��6   $��1��6D   $��0��6Q   5      5      