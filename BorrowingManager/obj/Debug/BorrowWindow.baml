   M S B A M L   `   `   `  ����K  GBorrowingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BorrowingManagerBorrowingManager  5   	   #    BorrowingManager.BorrowWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BorrowingManager     5   	   -   5          �Name$  BorrowWindow1��5   	    � Title$ BorrowWindow��5   	   $��184.258��6   $	��300��6/   .��5	      � $��
0,0,-0.4,0q�6   .+�5
   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ dateBorrowBegin��5
      $
��Left=�6.   $��
159,53,0,0q�6I   $	��Top=�6]      Text$ Début :��6u   $��32��6�   6�   �� 5   
   -   5         ��Name$ comboBorrowTerritory��5      $
��Left=�62   $��
159,10,0,0q�6M   $	��Top=�6a   $	��125��6y    �� SelectedValuePath$ Id��6�    �� DisplayMemberPath$ Number��6�   5      �� 5   
   -   5         ��Name$ lblBorrowTerritory��5      $#��Sélectionnez un territoire :��6,   $
��Left=�6S   $��	10,10,0,0q�6n   $	��Top=�6�    J� RenderTransformOrigin$ -0.203,-0.459&�6�   �� 5   
   -   5        $ lblBorrowBegin��5      $��Début de l'emprunt :��6(   $
��Left=�6G   $��	10,51,0,0q�6b   $	��Top=�6u   $	��149��6�     5   
   -   5        $ dateBorrowEnd��5      $
��Left=�6,   $��
159,94,0,0q�6G   $	��Top=�6[   $ Début :��6s   $��32��6�   6�   �� 5   
   -   5        $ lblBorrowEnd��5      $��Fin de l'emprunt :��6&   $
��Left=�6C   $��	10,93,0,0q�6^   $	��Top=�6q   $	��108��6�   �� 5   
   -   5        	 ��Name$	 btnBorrowConfirm��5      $��	Confirmer��6+   $��Center=�6?   $��196,124,9.6,0q�6\   $	��Top=�6s   $��88��6�   $ 0.484,0.458&�6�   6�   �� 5   
   -	   5        $ lblBorrowActualBegin��5      $�� ��6.   $
��Left=�69   $��
196,52,0,0q�6T   $	��Top=�6h   $��88��6�   �� 5   
   -
   5        $ lblBorrowActualEnd��5      $�� ��6,   $
��Left=�67   $��
196,93,0,0q�6R   $	��Top=�6f   $��88��6~   �� 5   
   -   5        $	 btnBorrowReset��5      $��X��6)   $��Center=�65   $��123,94,146.6,0q�6R   $	��Top=�6j   $��24��6�   $ 0.484,0.458&�6�   $��24��6�   5      5      