   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.Sessions   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5      -   5          N� Title$  Sessions��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��379* �6   �� 5      $	��56* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGsession��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер Сессии��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	SessionID+6e     5      $ Номер Клиента��6%   $ * 6W    6<   �� *UserID+6c     5      $% Номер Компьютера��6%   $ * 6X    6?   �� *PcID+6d     5      $ Номер тарифа��6%   $ * 6V    6;   �� *RateID+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $
��BtEd��6=   -   5        $ ��Редактировать��5   %   6^   5      5      5      �� 5   
   -   5        $��BtAdd��5   l   $��Добавить��6   $
��Left=�6$   $��
10,10,0,10q�6?   $	��170��6S   $��1��6_   6z   �� 5    
   -   5        $��BtDel��5    l   $��Удалить��6   $��Right=�6#   $��
10,10,0,10q�6?   $	��170��6S   $��1��6_   6z   �� 5!   
   -   5        $��BtBack��5!   k   $��
Назад��6   $��Center=�6!   $��1��6>   $��
10,10,0,10q�6K   $	��170��6_   6�   5"      5#      