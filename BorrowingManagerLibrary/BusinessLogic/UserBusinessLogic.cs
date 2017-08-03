using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Models;
using BorrowingManagerLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.BusinessLogic
{
    public class UserBusinessLogic
    {
        private UserDataLayer _userDL = new UserDataLayer();

        public User GetById(int id)
        {
            return _userDL.GetById(id);
        }

        public List<User> GetAll()
        {
            return _userDL.GetAll();
        }

        public ResultViewModel Insert(User t)
        {
            ResultViewModel result = new ResultViewModel();

            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Lastname))
                {
                    if (!string.IsNullOrEmpty(t.Name))
                    {
                        if (IsValidMail(t.Mail))
                        {
                            t.Id =_userDL.Insert(t);
                            result.Succes = true;
                        }
                        else
                        {
                            result.ErrorMessage = "Invalid mail";
                        }

                    }
                    else
                    {
                        result.ErrorMessage ="Name cannot be empty";
                       
                    }
                }
                else
                {
                    result.ErrorMessage = "Lastname cannot be empty";
                }
            }
            else
            {
                result.ErrorMessage = "Cannot insert null object";
            }
                
            result.Tag = t;
            return result;
        }

        public List<UserViewModel> ConvertToViewModel(List<User> listUser)
        {
            List<UserViewModel> listUserViewModel = new List<UserViewModel>();
            if (listUser != null)
            {
                foreach(User u in listUser)
                {
                    UserViewModel v = new UserViewModel();
                    v.Lastname = u.Lastname;
                    v.Mail = u.Mail;
                    v.Name = u.Name;

                    listUserViewModel.Add(v);
                }
            }
            return listUserViewModel;
        }

        public ResultViewModel Update(User t)
        {
            ResultViewModel result = new ResultViewModel();

            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Lastname))
                {
                    if (!string.IsNullOrEmpty(t.Name))
                    {
                        if (IsValidMail(t.Mail))
                        {
                            _userDL.Update(t);
                            result.Succes = true;
                        }else
                        {
                            result.ErrorMessage = "Invalid mail";
                        }
                        
                        

                    }
                    else
                    {
                        result.ErrorMessage = "Name cannot be empty";

                    }
                }
                else
                {
                    result.ErrorMessage = "Lastname cannot be empty";
                }
            }
            else
            {
                result.ErrorMessage = "Cannot insert null object";
            }

            result.Tag = t;
            return result;

        }

        public void Delete(int id)
        {
            _userDL.Delete(id);
        }

        public bool IsValidMail(string mail)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mail);
                return true;
            }
            catch
            {

            }
            return false;
        }
    }
}
