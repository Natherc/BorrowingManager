using System;
using System.Collections.Generic;
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
        SqlConnection con;
        public MainWindow()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            connectLabel.Content = "Ouverture de Connexion";
            List<Territory> listTerritory = new List<Territory>();
            DateTime dt = new DateTime(2013,12,1);
            listTerritory.Add(new Territory("A1", "Pecrot", DateTime.Now));
            listTerritory.Add(new Territory("A2", "Grez", dt));
            
            dataTerritory.ItemsSource = listTerritory.OrderBy(x => x.Date);




        }
    }
}
