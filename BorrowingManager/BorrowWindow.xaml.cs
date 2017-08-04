using BorrowingManagerLibrary.BusinessLogic;
using BorrowingManagerLibrary.Models;
using BorrowingManagerLibrary.ViewModels;
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
    /// Interaction logic for BorrowWindow.xaml
    /// </summary>
    public partial class BorrowWindow : Window, IDisposable
    {
        public bool HasClosedAfterHitButtonSave { get; set; }
        public UserTerritory UserTerritory { get; set; }
        public User selectedUser { get; set; }
        public UserTerritoryViewModel UserTerritoryViewModel { get; set; }
        public UserTerritoryBusinessLogic _userTerritoryBll = new UserTerritoryBusinessLogic();
        public bool IsUpdate
        {
            get
            {
                if (UserTerritory != null)
                    return true;

                return false;
            }
        }
        public BorrowWindow()
        {
            DateTime selectedDate;
            InitializeComponent();
            dateBorrowBegin.SelectedDate = DateTime.Now;
            selectedDate = (DateTime)dateBorrowBegin.SelectedDate;
            lblBorrowActualBegin.Content = selectedDate.ToString("dd/MM/yy");
        }

        private void BorrowWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            List<UserTerritory> userTerrList;
            List<UserTerritoryViewModel> userTerrViewModelList;
            userTerrList = _userTerritoryBll.GetAll();
            userTerrViewModelList = _userTerritoryBll.ConvertToViewModel(userTerrList);
            comboBorrowTerritory.ItemsSource = userTerrViewModelList;

        }

        private void btnBorrowConfirm_Click(object sender, RoutedEventArgs e)
        {
            UserTerritoryBusinessLogic bll = new UserTerritoryBusinessLogic();

            ResultViewModel result = new ResultViewModel(); ;

            if (IsUpdate)
            {
                FillUserTerritoryProperties();

                result = bll.Update(UserTerritory);

            }
            else
            {
                UserTerritory = new UserTerritory();

                FillUserTerritoryProperties();

                result = bll.Insert(UserTerritory);
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

        private void FillUserTerritoryProperties()
        {
            UserTerritoryViewModel selected = (UserTerritoryViewModel)comboBorrowTerritory.SelectedItem;
            UserTerritory.TerritoryId = selected.TerritoryId;
            UserTerritory.UserId = selected.UserId;
            UserTerritory.IsDeleted = selected.IsDeleted;
            UserTerritory.BeginBorrowing = dateBorrowBegin.SelectedDate;
            UserTerritory.EndBorrowing = dateBorrowEnd.SelectedDate;
        }

        public void Dispose()
        {

        }

        private void dateBorrowBegin_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime selectDate = (DateTime)dateBorrowBegin.SelectedDate;
            lblBorrowActualBegin.Content = selectDate.ToString("dd/MM/yy");
        }

        private void dateBorrowEnd_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DateTime selectDate = (DateTime)dateBorrowEnd.SelectedDate;
            lblBorrowActualEnd.Content = selectDate.ToString("dd/MM/yy");
        }
    }
}
