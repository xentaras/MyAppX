   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyApp.ViewsMyApp.Views  5          MyApp.Views.OfferingView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MyApp.Views     5      
�������$	��300��5      $	��150��5      .��5      �   � RowDefinitions  5   
   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��5      $��Your offer:��5      �� 5   
   $��1��6   $��0��5      $��Account:��5      �� 5!   
   $��1��6   $��1��5"      $��Cards:��5#      �� 5%   
   $��2��6   $��0��5&      ��5'      �� *
Accounts+��5(      �� 5)      .R�5*      �  � ToolTip 6   �� *WhyNot+.+�5+      	�  	� 	GroupName$ Account��6&   ��5,   "   �� *Name+ d� 	IsChecked 5-   "   ��  �� Path$ 
IsSelected� �� Mode$ TwoWay=�{�5.   "   �� $ IsApplicable�5/      50      51      ��53      �� 54      .R�55      ��  �� Orientation$ Vertical=�6!   56      58      �� 5:   
   -   5         ��Name$ 	cardsList��5:      $��2��5;      $��1��5<      ��5=      �� *CreditCards+��5>      �� 5?      .R�5@      �  6   �� *WhyNot+.+�5A      �� ��6#   �� *Name+ 5B   #   �� *
IsSelected+{�5C   #   �� *IsApplicable+5D      5E      5F      ��5H      �� 5I      .R�5J      �� $ Vertical=�6!   5K      5M      �� 5O   
   $��3��6   $��2��5P      $��Right=�5Q      $��Bottom=�5R      $��OK��5S      ��5T      �� *ConfirmCommand+5V      5W      