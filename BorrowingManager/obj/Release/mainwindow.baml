   M S B A M L   `   `   `  ���� K  GBorrowingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BorrowingManagerBorrowingManager  !    BorrowingManager.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:BorrowingManager     -     �Name$  MainWindow1�� � Title$ BorrowManager��$��579.2��$��1251.6��$
��Left=�$	��Top=����	#FF403C3C���	#FFB19C9C���� .��� -    �Name$ 
windowGrid��$��10,0,15.6,-0.4q� � ColumnDefinitions �� $
��529* ��� $	��35* ��� $	��39* ��� $��0* �.+�&   System.Windows.Controls.DataGrid  -     Name$ dataTerritory��$��-7,41,786.6,0q���. $
��Auto=�$
��Auto=�   AutoGenerateColumns .     EnableRowVirtualization .     CanUserAddRows .  $	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 *    
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Id�  $		 N°��$
 *  �� $ Number�  $	 	Localité��$
 *  �� $ Locality� � ContextMenu �� .@�m� -   $��	Supprimer���� m� -   $��Ajouter���� m� -   $��Modifier���� m� -   $��Détails���� -    ��Name$ connectLabel��$�� ��$
��Left=�$��
10,447,0,0q�$	��Top=�$	��858��$��Sitka Small)�$��30��  -	   $ dataUser��$��288,41,406.6,0q� J� RenderTransformOrigin$ 0.5,0.5&���. $
��Auto=�$
��Auto=� .   .  $	��Top=�   $	 Id��$
 * $ Hidden=� �� $ Id�  $		 Nom��$
 *  �� $ Lastname�  $	 Prénom��$
 *  �� $
 Name�  $	 Email��$
 *  �� $
 Mail� �� .@�m� -
   $��	Supprimer���� m� -   $��Ajouter���� m� -   $��Modifier���� m� -   $��	Emprunter��  -   $ dataHistory��$��668,41,-11.8,9q�$ 0.5,0.5&���. $
��Auto=�$
��Auto=� .  $��4�� .  $	��Top=�
����������	#FF6CACEA   $		 N°��$
 *  �� $ TerritoryNumber�  $	 Id��$
 * $ Hidden=� �� $ Id�  $		 Nom��$
 *  �� $ UserLastname�  $	 Prénom��$
 *  �� $ UserName�  $	 Début��$
 *  �� $ BeginBorrowing� �� StringFormat$ {0:dd/MM/yyyy}��  $		 Fin��$
 *  �� $ EndBorrowing�$ {0:dd/MM/yyyy}�� �� .@�m� -   $��Rendre���� m� -   $��Modifier���� -    ��Name$ addTerritoryButton��$��Ajouter Territoire��$
��Left=�$��
183,11,0,0q�$	��Top=�$	��100��$ 0.067,0.183&�$��20���� -   $ addUserButton��$��Ajouter Utilisateur��$
��Left=�$��
557,11,0,0q�$	��Top=�$	��100��$ 0.067,0.183&�$��20��