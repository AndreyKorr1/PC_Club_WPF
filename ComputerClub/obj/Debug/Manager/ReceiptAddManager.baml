   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5      $    ComputerClub.ReceiptAddManager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5        N� Title$  
ReceiptAdd��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��112* �6   �� 5      $	��67* �6   �� 5      $
��110* �6   �� 5      $	��48* �6   �� 5      $
��113* �6   .+�5   
   �� $��Номер сессии��6   6*   �� 5   
   $!��Номер продукта��6   $��1��6*   �� 5   
   $��Номер скидки��6   $��2��6(   �� 5   
   $��
Сумма��6   $��3��6!   60   �� 5   
   -   5         ��Name$ ComboSession��5   D   $��1��64    �� DisplayMemberPath$ 	SessionID��6Z    �� SelectedItem 6   �� *	Session+6z   �� 5   
   -   5        $ ComboProduct��5   D   $��1��64   $ ProductName��6Z   $��1��6z    6   �� *	Product+6z   �� 5   
   -   5        $ ComboDiscount��5   R   $��1��65   $��2��6E   $ DiscountName��6i    6   �� *
Discount+6�   �� 5   
   $��3��6'   $��1��64   ��6   �� *Sum+6F   �� 5   
   -   5        $��BtSave��5   C   $��Сохранить��6   $��4��6%   $��0��62   $��0,1,0,0q�6e   6x   �� 5    
   -   5        $��BtBack��5    >   $��
Назад��6   $��4��6!   $��1��6.   $��0,1,0,0q�6`   5!      5"      