   M S B A M L   `   `   `  ����K  GBorrowingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BorrowingManagerBorrowingManager  5   	   !    BorrowingManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BorrowingManager     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ BorrowManager��5   	   $��579.2��6   $��1251.6��6.   $
��Left=�6=   $	��Top=�6X   ���	#FF403C3C���	#FFB19C9C��5	      �� 5
   
   .��5      � -   5         �Name$ 
windowGrid��5      $��10,0,15.6,-0.4q�6    � ColumnDefinitions 5   
   �� 5      $
��529* �6   �� 5      $	��35* �6   �� 5      $	��39* �6   �� 5      $��0* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataTerritory��5      $��-7,41,786.6,0q�6*   ��. $
��Auto=�6f   $
��Auto=�6�      AutoGenerateColumns .     EnableRowVirtualization .     CanUserAddRows .  $	��Top=�6A     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 61      
Visibility$ Hidden=�6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ Id�6W     5      $		 N°��6%   $
 * 61    6;   �� $ Number�  5      $	 	Localité��6%   $
 * 67    6A   �� $ Locality� � ContextMenu 5      �� 5      .@�5      m� -   5        $��	Supprimer��5      62   �� 5      m� 5      -   5        $��Ajouter��5      60   �� 5      m� 5      -   5        $��Modifier��5      61   �� 5       m� 5!      -   5        $��Détails��5!      60   5"      5$      �� 5%   
   -   5         ��Name$ connectLabel��5%      $�� ��6&   $
��Left=�61   $��
10,447,0,0q�6L   $	��Top=�6`   $	��858��6x   $��Sitka Small)�6�   $��30��6�     5&   
   -	   5        $ dataUser��5&      $��288,41,406.6,0q�6%    J� RenderTransformOrigin$ 0.5,0.5&�6=   ��. $
��Auto=�6�   $
��Auto=�6�    .   .  $	��Top=�6   5'        5(      $	 Id��6%   $
 * 61   $ Hidden=�6W    6;   �� $ Id�6W     5)      $		 Nom��6%   $
 * 62    6<   �� $ Lastname�  5*      $	 Prénom��6%   $
 * 65    6?   �� $
 Name�  5+      $	 Email��6%   $
 * 64    6>   �� $
 Mail� 5-      �� 5.      .@�5/      m� -
   5        $��	Supprimer��5/      62   �� 50      m� 51      -   5        $��Ajouter��51      60   �� 52      m� 53      -   5        $��Modifier��53      61   �� 54      m� 55      -   5        $��	Emprunter��55      62   56      58        59   
   -   5        $ dataHistory��59      $��668,41,-11.8,9q�6(   $ 0.5,0.5&�6@   ��. $
��Auto=�6�   $
��Auto=�6�    .  $��4��6   .  $	��Top=�6.  
����������	#FF6CACEA 5:        5;      $		 N°��6%   $
 * 61    6;   �� $ TerritoryNumber�  5<      $	 Id��6%   $
 * 61   $ Hidden=�6W    6;   �� $ Id�6W     5=      $		 Nom��6%   $
 * 62    6<   �� $ UserLastname�  5>      $	 Prénom��6%   $
 * 65    6?   �� $ UserName�  5?      $	 Début��6%   $
 * 64    6>   �� $ BeginBorrowing� �� StringFormat$ {0:dd/MM/yyyy}��  5@      $		 Fin��6%   $
 * 62    6<   �� $ EndBorrowing�$ {0:dd/MM/yyyy}�� 5B      �� 5C      .@�5D      m� $��	Prévenir��6   �� 5E      m� 5F      -   5        $��Rendre��5F      6/   �� 5G      m� 5H      -   5        $��Modifier��5H      61   5I      5K      �� 5L   
   -   5         ��Name$ addTerritoryButton��5L      $��Ajouter Territoire��6-   $
��Left=�6J   $��
183,11,0,0q�6e   $	��Top=�6y   $	��100��6�   $ 0.067,0.183&�6�   $��20��6�   6�   �� 5M   
   -   5        $ addUserButton��5M      $��Ajouter Utilisateur��6(   $
��Left=�6F   $��
557,11,0,0q�6a   $	��Top=�6u   $	��100��6�   $ 0.067,0.183&�6�   $��20��6�   6�   5N      5O      