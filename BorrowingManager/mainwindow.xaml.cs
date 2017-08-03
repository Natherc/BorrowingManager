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

        private void InsertUser()
        {
            User u = new User();
            u.Lastname = txtFirstName.Text;
            ResultViewModel r = _userBLL.Insert(u);
            if (!r.Succes)
            {
                MessageBox.Show(r.ErrorMessage);
            }
        }

        private void InsertTerritory()
        {
            Territory t = new Territory();
            
            ResultViewModel r = _territoryBLL.Insert(t);
            if (!r.Succes)
            {
                MessageBox.Show(r.ErrorMessage);
            }
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

            _territoryBLL.Delete(toDeleteFromBindedList.Id);

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
    }
}
