   M S B A M L   `   `   `  ����Q  MEntityFrameworkCRUDWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EntityFrameworkCRUDWPFEntityFrameworkCRUDWPF  5   	   '    !EntityFrameworkCRUDWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EntityFrameworkCRUDWPF     5   	     � Title$"  Entity Framework Main Screen��5   	   $	��450��6.   $	��800��6;   .��5	      � ���	#FF565454 � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      �� 5      $��2* �6   �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      �� 5      �� 5      $��50 �6   .+�5   
   �� $��1��6   $��3��6    $��0��64   $%��Entity Framework & Data-Binding��6A   $��Center=�6o   $	��Top=�6�   $��0,20,0,0q�6�   $��24(�6�   $
��Bold"�6�   $	��400��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridPeople��5      $��1��6+   $��1��6;   $��3��6H   $��2��6\      GridLinesVisibility$
 None=�6m      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6H   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *Id+6H     5      $ 
First name��6%   $	 100 6W   	 69   �� *	FirstName+6W     5      $ 	Last name��6%   $	 100 6U   	 68   �� *
LastName+6U     5      $	 Age��6%   $ 50 6J   	 62   �� *Age+6J     5      $ Fav Programming Language��6%   $	 200 6o   	 6G   �� *ProgrammingLanguage+6o     5       $ Date Created��6%   	 6;   �� *DateCreated+5"      �� 5#   
   -   5        
 ��Name$
 	BtnCreate��5#      $��1��6$   $��3��64   $��35��6A   $	��120��6M   $��Create��6Y   $��Bottom=�6j   $��0,0,0,5q�6�   6�   �� 5$   
   -   5        $
 	BtnUpdate��5$      $��2��6$   $��3��64   $��35��6A   $	��120��6M   $��Update��6Y   $��Bottom=�6j   $��0,0,0,5q�6�   6�   �� 5%   
   -   5        $
 	BtnDelete��5%      $��3��6$   $��3��64   $��35��6A   $	��120��6M   $��Delete��6Y   $��Bottom=�6j   $��0,0,0,5q�6�   6�   �� 5'   
   $��4��6   $��5��6   $&�� Harkins Development Copyright ©��61   $��Center=�6[   $��Bottom=�6x   $��0,0,0,10q�6�   5(      5)      