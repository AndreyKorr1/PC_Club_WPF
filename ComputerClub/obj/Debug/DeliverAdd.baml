   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.DeliverAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5        N� Title$  
DeliverAdd��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��ID Поставщика��6   6+   �� 5   
   $��ID продукта��6   $��1��6'   66   �� 5   
   $'��!Количество товара��6   $��2��6-   �� 5   
   -   5         ��Name$ ComboProvider��5   G   $��1��67    �� DisplayMemberPath$ 
ProviderID��6^    �� SelectedItem 6   �� *
ProviderID+6   �� 5   
   -   5        $ ComboProduct��5   S   $��1��66   $��1��6F   $ 	ProductID��6i    6   �� *	ProductID+6�   �� 5   
    �� 	MaxLength$ 18��63   $��2��6B   $��1��6O   ��6   �� *ProductQuantity+6O   �� 5   
   -   5        $��BtSave��5   C   $��Сохранить��6   $��3��6%   $��0��62   6g   �� 5   
   -   5        $��BtBack��5   >   $��
Назад��6   $��3��6!   $��1��6.   6L   5      5      