   M S B A M L   `   `   `  ����D  @MVVM_Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVM_Demo	MVVM_Demo  5   	   9!clr-namespace:MVVM_Demo.ViewModelMVVM_Demo.ViewModel  5   	       MVVM_Demo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVM_Demo     5   	   0vm!clr-namespace:MVVM_Demo.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � 	Resources 5      )  #MVVM_Demo.ViewModel.PersonViewModel   PersonViewModel��%   &	          5   
   6   5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��
First Name��61   $��Center=�6C   �� 5   
   $��0��6   $��1��6   $	��100��6Z   $��Center=�6f   ��6/   �� *Person.FName+ �� Mode$ TwoWay=�6f   �� 5   
   $��1��6   $��0��6!   $��	Last Name��61   $��Center=�6B   �� 5   
   $��1��6   $��1��6   $	��100��6Z   $��Center=�6f   ��6/   �� *Person.LName+$ TwoWay=�6f   �� 5    
   $��Submit��6   $��Center=�6D   $��2��6a   $��0��6n   ��6"   �� *SubmitCommand+6n   �� 5!   
   $��3��63   $��1��6@   $
��Auto��6P   ��6   �� *	Persons+ �� View 5"      �� 5#      .P�5$      �� $��
First Name��6%    �� Width$
 Auto��6`   	 �� DisplayMemberBinding	 69   �� *FName+6`   �� 5%      $��	Last Name��6%   $
 Auto��6_   	 68   �� *LName+6_   �� 5&      $��	Full Name��6%   $
 Auto��6b   	 68   �� *
FullName+6b   5'      5)      5*      5+      