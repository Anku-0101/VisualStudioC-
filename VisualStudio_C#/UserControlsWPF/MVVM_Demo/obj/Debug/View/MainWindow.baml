   M S B A M L   `   `   `  ����D  @MVVM_Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MVVM_Demo.UserControlsMVVM_Demo.UserControls  5   	   9!clr-namespace:MVVM_Demo.ViewModelMVVM_Demo.ViewModel  5   	       MVVM_Demo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MVVM_Demo.UserControls     5   	   0vm!clr-namespace:MVVM_Demo.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      )  #MVVM_Demo.ViewModel.PersonViewModel   PersonViewModel �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%�   &	        '��        5   
   6   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 60   �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $��* �6   .+�5%   
   �� $��0��6   $��0��6!   $��
First Name��61   $��Center=�6C   �� 5&   
   $��0��6   $��1��6   $	��100��6v   $��Center=�6�   ��6/   �� *Person.FName+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors . 6�   �� 5'   
   $��1��6   $��0��6!   $��	Last Name��61   $��Center=�6B   �� 5(   
   $��1��6   $��1��6   $	��100��6v   $��Center=�6�   ��6/   �� *Person.LName+$ TwoWay=� . 6�   �� 5)   
   $��Submit��6   $��Center=�6D   $��2��6a   $��0��6n   ��6"   �� *SubmitCommand+6n   %   MVVM_Demo.UserControls.ListView  5*   
   $��3��6   $��1��6&   5+      5,      