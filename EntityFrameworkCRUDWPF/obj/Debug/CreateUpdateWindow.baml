   M S B A M L   `   `   `  ����Q  MEntityFrameworkCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EntityFrameworkCRUDWPFEntityFrameworkCRUDWPF  5   	   /    )EntityFrameworkCRUDWPF.CreateUpdateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EntityFrameworkCRUDWPF     5   	     � Title$  Entity Framework��5   
   $	��450��6#   $	��800��60   .��5	      � ���	#FF565454 � ColumnDefinitions 5
   
   �� 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ 	LblHeader��5      $��0��6#   $��4��60   $��Header for Window��6D   $��Center=�6`   $��0,10,0,0q�6}   $��26(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 
LblIdlabel��5      $��1��6$   $��1��64   $��Database ID: ��6A   $��Right=�6Y   $��Center=�6u   $��18(�6�   �� 5   
   -   5        $ 
LblIdInput��5      $��2��6$   $��1��64   $��2��6A   $��0��6U   $��Center=�6a   $��Center=�6~   $��18(�6�   �� 5   
   $��1��6   $��2��6    $��First Name: ��6-   $��Right=�6D   $��Center=�6`   $��18(�6{   �� 5   
   -   5         ��Name$ TxtFirstName��5      $��2��6(   $��2��68   $��30��6E   $	��200��6Q   �� 5   
   $��1��6   $��3��6    $��Last Name: ��6-   $��Right=�6C   $��Center=�6_   $��18(�6z   �� 5    
   -   5        $ TxtLastName��5       $��2��6'   $��3��67   $��30��6D   $	��200��6P   �� 5!   
   $��1��6   $��4��6    $��Age: ��6-   $��Right=�6=   $��Center=�6Y   $��18(�6t   �� 5"   
   -   5        $ TxtAge��5"      $��2��6"   $��4��62   $��30��6?   $	��200��6K   �� 5#   
   $��1��6   $��5��6    $��Programming Language: ��6-   $��Right=�6N   $��Center=�6j   $��18(�6�   �� 5$   
   -   5        $ TxtProgrammingLanguage��5$      $��2��62   $��5��6B   $��30��6O   $	��200��6[   �� 5%   
   -   5         ��Name$ BtnSave��5%      $
��Save��6"   $��1��61   $��2��6A   $��6��6U   $	��100��6b   $��30��6n   6z   �� 5'   
   $��7��6   $��4��6   $&�� Harkins Development Copyright ©��61   $��Center=�6[   $��Bottom=�6x   $��0,0,0,10q�6�   5(      5)      