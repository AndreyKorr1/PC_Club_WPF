   M S B A M L   `   `   `  ����G  CComputerClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ComputerClubComputerClub  5          ComputerClub.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ComputerClub     5        N� Title$  Login��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��397* �6   �� 5      $
��403* �6    � RowDefinitions 5   
   �� 5      $	��61* �6   �� 5      $	��52* �6   �� 5      $	��75* �6   �� 5      $	��91* �6   �� 5      $	��68* �6   .+�5   
   �� $��Введите логин��6   6+   �� 5   
   $!��Введите пароль��6   $��1��6*   69   �� 5   
   $0��*Введите Номер телефона��6   $��2��62   6A   �� 5   
   $.��(Введите дату рождения��6   $��3��61   6@   �� 5   
   -   5         ��Name$ 	loginText��5      $��0��6%   $��1��62   6D   G� 5   
   -   5         G�Name$ passwordText��5      $��1��6,   $��1��69   6K   �� 5   
   -   5        $ 	phoneText��5      $��2��6%   $��1��62   6D   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ dateText��5      $��3��6%   $��1��62   6D   �� 5    
   -   5        $��BtSignUp��5       $��Регистрация��6!   $��4��6R   6a   �� 5!   
   -   5        $��Вход��5!      $��4��60   $��1��6=   6O   5#      5$      