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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window,IDisposable
    {
        #region properties
        public bool HasClosedAfterHitButtonSave { get; set; }
        public User User { get; set; }
        public bool IsUpdate
        {
            get
            {
                if (User != null)
                    return true;

                return false;
            }
        }
        #endregion

        public UserWindow()
        {
            InitializeComponent();
        }

        public void Dispose()
        {
            
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            UserBusinessLogic bll = new UserBusinessLogic();
           
            ResultViewModel result = new ResultViewModel(); ;

            if (IsUpdate)
            {
                FillUserProperties();

                result = bll.Update(User);

            }
            else
            {
                User = new User();

                FillUserProperties();

                result = bll.Insert(User);
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

        private void FillUserProperties()
        {
            User.Lastname = txtLastname.Text;
            User.Name = txtName.Text;
            User.Mail = txtMail.Text;
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            HasClosedAfterHitButtonSave = false;


            if (User != null)
            {
                txtName.Text = User.Name;
                txtLastname.Text = User.Lastname;
                txtMail.Text = User.Mail;
            }
        }
    }
}
