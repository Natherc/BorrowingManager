   M S B A M L   `   `   `  ����K  GBorrowingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BorrowingManagerBorrowingManager  5   	   !    BorrowingManager.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BorrowingManager     5   	   -   5          � Title$  Utilisateur��5   	   $��190.244��6   $	��300��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ txtLastname��5      $
��Left=�6'   $��23��6B   $��	68,10,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��198��6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��23��6>   $��	68,52,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��198��6�   �� 5   
   -   5        $ txtMail��5      $
��Left=�6#   $��23��6>   $��	68,96,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��198��6�   �� 5   
   -   5         ��Name$ btnSaveUser��5      $��Sauver��6&   $��Center=�67   $��106,132,112.6,0q�6T   $	��Top=�6m   $��75��6�    J� RenderTransformOrigin$ -1.698,0.831&�6�   $��19��6�   �� 5   
   -   5         ��Name$ lblLastname��5      $��Nom :��6%   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $ 0.383,-0.087&�6{   $��58��6�   $��23��6�   $��10(�6�   �� 5   
   -   5        $ lblName��5      $��	Prénom :��6!   $
��Left=�64   $��	10,52,0,0q�6O   $	��Top=�6b   $ 0.383,-0.087&�6z   $��58��6�   $��23��6�   $��10(�6�   �� 5   
   -   5        $ lblMail��5      $��Mail :��6!   $
��Left=�62   $��	10,96,0,0q�6M   $	��Top=�6`   $ 0.383,-0.087&�6x   $��58��6�   $��23��6�   $��10(�6�   5      5      