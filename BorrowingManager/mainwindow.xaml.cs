using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BorrowingManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TerritoryBusinessLogic _territoryBLL = new TerritoryBusinessLogic();
        private UserBusinessLogic _userBLL = new UserBusinessLogic();

        public MainWindow()
        {
            InitializeComponent();

            List<Territory> listTerritory = _territoryBLL.GetAll();
            List<User> listUser = _userBLL.GetAll();

            dataTerritory.ItemsSource = listTerritory;          
            dataUser.ItemsSource = listUser;
               
        }

       

       

            private void addTerritoryButton_Click(object sender, RoutedEventArgs e)
    {
            using (territoryWindow frm = new territoryWindow())
            {
                frm.Owner = this;
                frm.ShowDialog();
                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateTerritoryGrid();
                    
                }
            }
        }

        private void UpdateTerritoryGrid()
        {
            dataTerritory.ItemsSource = null;
            dataTerritory.Items.Clear();
            List<Territory> listTerritory = _territoryBLL.GetAll();
            dataTerritory.ItemsSource = listTerritory;
            dataTerritory.Items.Refresh();

        }

        private void UpdateUserGrid()
        {
            dataUser.ItemsSource = null;
            dataUser.Items.Clear();
            List<User> listUser = _userBLL.GetAll();
            dataUser.ItemsSource = listUser;
            dataUser.Items.Refresh();

        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;

            //Get the ContextMenu to which the menuItem belongs
            var contextMenu = (ContextMenu)menuItem.Parent;

            //Find the placementTarget
            var item = (DataGrid)contextMenu.PlacementTarget;

            //Get the underlying item, that you cast to your object that is bound
            //to the DataGrid (and has subject and state as property)
            var toDeleteFromBindedList = (Territory)item.SelectedCells[0].Item;

            if (MessageBox.Show("Etes-vous sûre de vouloir supprimer ce territoire ?", "Attention", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {

                _territoryBLL.Delete(toDeleteFromBindedList.Id);

                UpdateTerritoryGrid();
            }

            UpdateTerritoryGrid();

        }

        private void UpdateItem_Click(object sender, RoutedEventArgs e)
        {
            using (territoryWindow frm = new territoryWindow())
            {
                var menuItem = (MenuItem) sender;

                //Get the ContextMenu to which the menuItem belongs
                var contextMenu = (ContextMenu) menuItem.Parent;

                //Find the placementTarget
                var item = (DataGrid) contextMenu.PlacementTarget;

                //Get the underlying item, that you cast to your object that is bound
                //to the DataGrid (and has subject and state as property)
                var territoryToUpdate = (Territory)item.SelectedCells[0].Item;

                frm.Owner = this;
                frm.Territory = territoryToUpdate;
                frm.ShowDialog();

                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateTerritoryGrid();

                }
                
            }
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            using (UserWindow frm = new UserWindow())
            {
                frm.Owner = this;
                frm.ShowDialog();
                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateUserGrid();

                }
            }
        }

        private void DeleteItemUser_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;

            //Get the ContextMenu to which the menuItem belongs
            var contextMenu = (ContextMenu)menuItem.Parent;

            //Find the placementTarget
            var item = (DataGrid)contextMenu.PlacementTarget;

            //Get the underlying item, that you cast to your object that is bound
            //to the DataGrid (and has subject and state as property)
            var toDeleteFromBindedList = (User)item.SelectedCells[0].Item;

            if (MessageBox.Show("Etes-vous sûre de vouloir supprimer cet utilisateur ?","Attention",MessageBoxButton.YesNo,MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {
                
                _userBLL.Delete(toDeleteFromBindedList.Id);

                UpdateUserGrid();
            }
            
        }

        private void UpdateItemUser_Click(object sender, RoutedEventArgs e)
        {
            using (UserWindow frm = new UserWindow())
            {
                var menuItem = (MenuItem)sender;

                //Get the ContextMenu to which the menuItem belongs
                var contextMenu = (ContextMenu)menuItem.Parent;

                //Find the placementTarget
                var item = (DataGrid)contextMenu.PlacementTarget;

                //Get the underlying item, that you cast to your object that is bound
                //to the DataGrid (and has subject and state as property)
                var userToUpdate = (User)item.SelectedCells[0].Item;

                frm.Owner = this;
                frm.User = userToUpdate;
                frm.ShowDialog();

                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateUserGrid();

                }

            }
        }
    }
}
