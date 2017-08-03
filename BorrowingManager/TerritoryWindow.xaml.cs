using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.Models;
using Microsoft.Win32;
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
        public Territory Territory { get; set;}

        public bool IsUpdate
        {
            get
            {
                if (Territory != null)
                    return true;

                return false;
            }
        }

        

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
            

            ResultViewModel result = new ResultViewModel(); ;

            if (IsUpdate)
            {
                FillTerritoryProperties();
                result = bll.Update(Territory);
                
            }
            else
            {
                Territory = new Territory();
                FillTerritoryProperties();
                result = bll.Insert(Territory);
            }




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

        private void FillTerritoryProperties()
        {
            Territory.Number = txtNumber.Text;
            Territory.Locality = txtLocality.Text;
        }

        public void Dispose()
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HasClosedAfterHitButtonSave = false;
            

            if(Territory != null)
            {
                txtLocality.Text = Territory.Locality;
                txtNumber.Text = Territory.Number;
            }
            

        }

        private void btnImageTerritory_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if(op.ShowDialog() == true)
            {
                if (!IsUpdate)
                {
                    Territory = new Territory();
                }
                Territory.PathImage = op.FileName;
            }
           
        }
    }
}
