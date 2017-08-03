using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BorrowingManager
{
    /// <summary>
    /// Interaction logic for territoryWindow.xaml
    /// </summary>
    public partial class territoryWindow : Window, IDisposable
    {
        public bool HasClosedAfterHitButtonSave { get;  set; }

        public territoryWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TerritoryBusinessLogic bll = new TerritoryBusinessLogic();

            Territory t = new Territory();
            t.Number = txtNumber.Text;
            t.Locality = txtLocality.Text;
            ResultViewModel result = bll.Insert(t);
            if (result.Succes)
            {
                HasClosedAfterHitButtonSave = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            
            

        }

        public void Dispose()
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HasClosedAfterHitButtonSave = false;
        }
    }
}
