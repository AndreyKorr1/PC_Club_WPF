   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.Rates   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5      -   5          N� Title$  Rates��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��379* �6   �� 5      $	��56* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrate��5         AutoGenerateColumns .     
IsReadOnly . $��4��6Q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер Тарифа��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *RateID+6b     5      $# Название тарифа��6%   $ * 6[   	 6>   �� *
RateName+6g     5      $ Цена тарифа��6%   $ * 6X   	 6:   �� *	RatePrice+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      �� $
��BtEd��6=   -   5        $ ��Редактировать��5   %   6^   5      5!      5#      �� 5$   
   -   5        $��BtAdd��5$   $   $��Добавить��6   $��0��6H   $��1��6Y   �� 5%   
   -   5        $��BtDel��5%   #   $��Удалить��6   $��1��6E   $��1��6V   �� 5&   
   -   5        $��BtBack��5&   "   $��
Назад��6   $��3��6F   $��1��6V   �� 5'   
   -   5        $��BtOtch��5'   +   $"��Отчет о тарифах��6   $��2��6N   $��1��6^   5(      5)      