   M S B A M L   `   `   `  ????A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?? $??Id??6   $
??Left=?6   $??	64,71,0,0q?68   $	??Top=?6K   ?? 5   
   $
??Name??6   $
??Left=?6   $??
64,149,0,0q?6:   $	??Top=?6N   ?? 5   
   $??Phone number??6   $
??Left=?6'   $??
64,229,0,0q?6B   $	??Top=?6V   ?? 5   
   -   5         ??Name$ txtId??5      $
??Left=?6!   $??
171,71,0,0q?6<    ?? TextWrapping$
 Wrap=?6P   $	??Top=?6d   $	??157??6|   $??29??6?   ?? 5   
   -   5        $ txtName??5      $
??Left=?6#   $??171,149,0,0q?6>   $
 Wrap=?6S   $	??Top=?6g   $	??157??6   $??29??6?   ?? 5   
   -   5        $ txtPhoneNumber??5      $
??Left=?6*   $??171,227,0,0q?6E   $
 Wrap=?6Z   $	??Top=?6n   $	??157??6?   $??29??6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid??5      $??353,79,52,194q?6%      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ?? *id+  5      $
 Name??6%   $	 150 63    6?   ?? *Name+  5      $ PhoneNumber??6%   $	 242 6:    6F   ?? *PhoneNumber+5      ?? 5   
   -   5        	 ??Name$	 	btnInsert??5      $??Insert??6$   $
??Left=?65   $??
85,330,0,0q?6P   $	??Top=?6d   $	??112??6|   $??39??6?   6?   ?? 5   
   -   5        $	 	btnDelete??5      $??Delete??6$   $
??Left=?65   $??427,330,0,0q?6P   $	??Top=?6e   $	??112??6}   $??39??6?   6?   ?? 5   
   -   5        $	 	btnUpdate??5      $??Update??6$   $
??Left=?65   $??250,330,0,0q?6P   $	??Top=?6e   $	??112??6}   $??39??6?   6?   ?? 5   
   -   5        $	 btnClear??5      $??Clear??6#   $
??Left=?63   $??595,330,0,0q?6N   $	??Top=?6c   $	??112??6{   $??39??6?   6?   5      5      