   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyApp.ViewsMyApp.Views  5          MyApp.Views.QuestionsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MyApp.Views     5      
�������$	��300��5      $	��150��5      .��5      �   � RowDefinitions  5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      .+�5   
   �� $��0��6   $��0��5      $��Fill information:��5      �� 5   
   $��1��6   $��0��5       $��Your age��5!      �� 5"   
   $��1��6   $��1��5#      ��5$      �� *Age+�� 5&   
   $��2��6   $��0��5'      $��Are you a student?��5(      �� 5)   
   $��2��6   $��1��5*       �� Orientation$ 
Horizontal=�5+      .+�5,      	�  	� 	GroupName$ Student��6    d� 	IsChecked 5-      �� *	IsStudent+�� 5.      $	��Yes��6   	� 5/      $ Student��6    50      �� *
NotStudent+�� 51      $��No��6   52      �� 54   
   $��3��6   $��0��55      $��Your income��56      �� 57   
   $��3��6   $��1��58      ��59      �� *Income+�� 5;   
   $��4��6   $��2��5<      $��Right=�5=      $��Bottom=�5>      $��OK��5?      ��5@      �� *ConfirmCommand+5B      5C      