using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.Model;
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
            FitToContent(dataTerritory);
            FitToContent(dataUser);

         
            

            

          
            
        }

        private void FitToContent(DataGrid dg)
        {
            // where dg is my data grid's name...
            foreach (DataGridColumn column in dg.Columns)
            {
                //if you want to size ur column as per the cell content
                column.Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
                //if you want to size ur column as per the column header
                column.Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToHeader);
                //if you want to size ur column as per both header and cell content
                column.Width = new DataGridLength(1.0, DataGridLengthUnitType.Auto);
            }
        }






        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }
    }
}
