   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.PCManager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5      -   5          N� Title$  PC��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��364* �6   �� 5      $	��71* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGpcManager��5      $��0��6(      AutoGenerateColumns .     
IsReadOnly . $��3��6c      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Номер комьютера��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *PcID+6c     5      $ Видеокарта��6%   $ * 6X   	 69   �� *
Video_Card+6d     5      $ Процессор��6%   $ * 6P   	 68   �� *CPU+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      �� $
��BtEd��6=   -   5        $ ��Редактировать��5   %   6^   5      5       5"      �� 5#   
   -   5        $��BtAdd��5#   A   $��Добавить��6   $��0��6$   $��1��64   6O   �� 5$   
   -   5        $��BtDel��5$   0   $��Удалить��6   $��1��6#   $��1��6R   �� 5%   
   -   5        $��BtBack��5%   ?   $��
Назад��6   $��2��6"   $��1��62   6N   5&      5'      