using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Models;
using BorrowingManagerLibrary.ViewModels;
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
        private UserTerritoryBusinessLogic _userTerritoryBLL = new UserTerritoryBusinessLogic();

        public MainWindow()
        {
            InitializeComponent();

            List<Territory> listTerritory = _territoryBLL.GetAll();
            List<User> listUser = _userBLL.GetAll();
            List<UserTerritory> listUserTerritory = _userTerritoryBLL.GetAll();
   
            dataUser.ItemsSource = listUser;     
            dataTerritory.ItemsSource = listTerritory;
            dataHistory.ItemsSource = _userTerritoryBLL.ConvertToViewModel(listUserTerritory);
            FillAndHideUserGrid();
                  
        }

       private void FillAndHideUserGrid()
        {
            dataUser.ItemsSource = null;
            dataUser.Items.Clear();
            List<User> listUser = _userBLL.GetAll();
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

        private void UpdateUserTerritoryGrid()
        {
            dataHistory.ItemsSource = null;
            dataHistory.Items.Clear();
            List<UserTerritory> listUserTerritory = _userTerritoryBLL.GetAll();
            dataHistory.ItemsSource = listUserTerritory;
            dataHistory.Items.Refresh();

        }

        private void UpdateUserGrid()
        {
            
            
            FillAndHideUserGrid();

        }

        private void DeleteTerritory_Click(object sender, RoutedEventArgs e)
        {
            Territory territoryToDelete = GetSelectedElement<Territory>(dataTerritory);

            if (MessageBox.Show("Etes-vous sûre de vouloir supprimer ce territoire ?", "Attention", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {

                _territoryBLL.Delete(territoryToDelete.Id);

                UpdateTerritoryGrid();
            }

           

        }

        private void UpdateTerritory_Click(object sender, RoutedEventArgs e)
        {
            using (territoryWindow frm = new territoryWindow())
            {
                Territory territoryToUpdate = GetSelectedElement<Territory>(dataTerritory);

                frm.Owner = this;
                frm.Territory = territoryToUpdate;
                frm.ShowDialog();

                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateTerritoryGrid();

                }

            }
        }

        private T GetSelectedElement<T>(DataGrid dataGrid)
        {
            T itemToUpdate =(T) dataGrid.SelectedCells[0].Item;

            

            return itemToUpdate;
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
            User userToDelete = GetSelectedElement<User>(dataUser);

            if (MessageBox.Show("Etes-vous sûre de vouloir supprimer cet utilisateur ?","Attention",MessageBoxButton.YesNo,MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
            {              
                _userBLL.Delete(userToDelete.Id);

                UpdateUserGrid();
            }
            
        }

        private void UpdateItemUser_Click(object sender, RoutedEventArgs e)
        {
            using (UserWindow frm = new UserWindow())
            {
                User userToUpdate = GetSelectedElement<User>(dataUser);

                frm.Owner = this;
                frm.User = userToUpdate;
                frm.ShowDialog();

                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateUserGrid();

                }

            }
        }

        private void dataTerritory_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var row = e.Row;
        }

        private void BorrowItem_Click(object sender, RoutedEventArgs e)
        {
            using (BorrowWindow frm = new BorrowWindow())
            {
                frm.selectedUser = GetSelectedElement<User>(dataUser);
                frm.Owner = this;
                frm.ShowDialog();
                if (frm.HasClosedAfterHitButtonSave)
                {
                    UpdateUserTerritoryGrid();

                }
            }
        }
    }
}
