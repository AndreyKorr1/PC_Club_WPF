   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.ReviewsAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5        N� Title$  
ReviewsAdd��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��21* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� $!��ID Пользователя��6   �� 5   
   $��Рейтинг��6   $��1��6#   62   �� 5   
   $��Коментарий��6   $��2��6&   65   �� 5   
   -   5         ��Name$ 
ComboUsers��5   #   $��1��6    �� DisplayMemberPath$ 	FirstName��67    �� SelectedItem 6U   �� *Users+�� 5   
   $��1��6*   $��1��6:   ��6   �� *Rating+6I   �� 5   
   $��1��6,   $��2��6<   ��6   �� *	Message+6K   �� 5   
   -   5        $��BtSave��5   C   $��Сохранить��6   $��3��6%   $��0��62   6g   �� 5   
   -   5        $��BtBack��5   >   $��
Назад��6   $��3��6!   $��1��6.   6L   5      5      