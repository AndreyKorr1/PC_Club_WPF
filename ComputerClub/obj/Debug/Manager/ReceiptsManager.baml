   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5      "    ComputerClub.ReceiptsManager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5      -   5          N� Title$  Receipts��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��379* �6   �� 5      $	��56* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGreceiptManager��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер Чека��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
ReciptID+6b     5      $ Номер Сессии��6%   $ * 6Y    6;   �� *	SessionID+6e     5      $ Номер Товара��6%   $ * 6Y    6;   �� *	ProductID+6e     5      $ Номер скидки��6%   $ * 6Z    6;   �� *
DiscountID+6f     5      $ Сумма чека��6%   $ * 6Q    69   �� *Sum+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $
��BtEd��6=   -   5        $ ��Редактировать��5   %   6^   5      5      5      �� 5    
   -   5        $��BtAdd��5    l   $��Добавить��6   $
��Left=�6$   $��
10,10,0,10q�6?   $	��170��6S   $��1��6_   6z   �� 5!   
   -   5        $��BtDel��5!   l   $��Удалить��6   $��Right=�6#   $��
10,10,0,10q�6?   $	��170��6S   $��1��6_   6z   �� 5"   
   -   5        $��BtBack��5"   k   $��
Назад��6   $��Center=�6!   $��1��6>   $��
10,10,0,10q�6K   $	��170��6_   6�   5#      5$      