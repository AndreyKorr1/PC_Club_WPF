   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.SessionAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5        N� Title$  
SessionAdd��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Номер клиента��6   6+   �� 5   
   $%��Номер компьютера��6   $��1��6,   6;   �� 5   
   $��Номер тарифа��6   $��2��6(   �� 5   
   -   5         ��Name$ 
ComboUsers��5   B   $��1��62    �� DisplayMemberPath$ 	FirstName��6V    �� SelectedItem 6   �� *Users+6v   �� 5   
   -   5        $ ComboPc��5   L   $��1��6/   $��1��6?   $
 PcID��6]    6   �� *Pc+6y   �� 5   
   -   5        $ 
ComboRates��5   N   $��1��61   $��2��6A   $ RateName��6b    6   �� *Rate+6�   �� 5   
   -   5        $��BtSave��5   C   $��Сохранить��6   $��3��6%   $��0��62   6g   �� 5   
   -   5        $��BtBack��5   >   $��
Назад��6   $��3��6!   $��1��6.   6L   5      5      