   M S B A M L   `   `   `  ���� K  GBorrowingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BorrowingManagerBorrowingManager  #    BorrowingManager.BorrowWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:BorrowingManager     -     �Name$  BorrowWindow1�� � Title$ BorrowWindow��$��184.258��$	��300��.��� $��
0,0,-0.4,0q�.+�(  "System.Windows.Controls.DatePicker  -     Name$ dateBorrowBegin��$
��Left=�$��
159,53,0,0q�$	��Top=�   Text$ Début :��$��32���� -    ��Name$ comboBorrowTerritory��$
��Left=�$��
159,10,0,0q�$	��Top=�$	��125�� �� SelectedValuePath$ Id�� �� DisplayMemberPath$ Number���� -    ��Name$ lblBorrowTerritory��$#��Sélectionnez un territoire :��$
��Left=�$��	10,10,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.203,-0.459&��� -   $ lblBorrowBegin��$��Début de l'emprunt :��$
��Left=�$��	10,51,0,0q�$	��Top=�$	��149��  -   $ dateBorrowEnd��$
��Left=�$��
159,94,0,0q�$	��Top=�$ Début :��$��32���� -   $ lblBorrowEnd��$��Fin de l'emprunt :��$
��Left=�$��	10,93,0,0q�$	��Top=�$	��108���� -   	 ��Name$	 btnBorrowConfirm��$��	Confirmer��$��Center=�$��196,124,9.6,0q�$	��Top=�$��88��$ 0.484,0.458&��� -	   $ lblBorrowActualBegin��$�� ��$
��Left=�$��
196,52,0,0q�$	��Top=�$��88���� -
   $ lblBorrowActualEnd��$�� ��$
��Left=�$��
196,93,0,0q�$	��Top=�$��88���� -   $	 btnBorrowReset��$��X��$��Center=�$��123,94,146.6,0q�$	��Top=�$��24��$ 0.484,0.458&�$��24��