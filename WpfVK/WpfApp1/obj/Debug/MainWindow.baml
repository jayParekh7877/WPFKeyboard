   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   1clr-namespace:WpfApp1.ControlWpfApp1.Control  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   3	myControlclr-namespace:WpfApp1.Control     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      %   WpfApp1.Control.MyCustomControl �� 
TargetType �� Property �� Value��%�   '        �� 5   
   "  6   .�5      ��  � ��
 �����6,   �� 5       � ��$ 1q�60   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   .+�5      �� ��6   �� *LogicalKeysFirstRow+��5      5  -System.Windows.Controls.ItemContainerTemplate�  5      .R�5           IsHotKey 64   �� *
IsHotKey+   KeyName 6R   �� *Name+   KeyCapitalName 5   4   �� *CapitalName+	   ClickCommand	 6[   �� *DoSomeImportantMethod+��5    4   �� *Height+��5!   4   �� *Width+5"      ��5$      �� 5%      .R�5&      �� 
 �� Orientation$
 
Horizontal=�6%   5'      5)      5*      � 5+   
   $��1��6   .+�5,      �� ��6   �� *LogicalKeysSecondRow+��5-        5.      .R�5/         64   �� *Name+ 50   4   �� *CapitalName+ 6[   �� *
IsHotKey+��51   4   �� *Height+��52   4   �� *Width+53      ��55      �� 56      .R�57      �� $
 
Horizontal=�6%   58      5:      5;      � 5<   
   $��2��6   .+�5=      �� ��6   �� *LogicalKeysThirdRow+��5>        5?      .R�5@         64   �� *Name+ 5A   4   �� *CapitalName+ 6[   �� *
IsHotKey+��5B   4   �� *Height+��5C   4   �� *Width+5D      ��5F      �� 5G      .R�5H      �� $
 
Horizontal=�6%   5I      5K      5L      5M      5N      