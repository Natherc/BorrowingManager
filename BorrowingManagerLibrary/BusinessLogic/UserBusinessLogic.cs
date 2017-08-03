using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Models;
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
                        
                            t.Id = _userDL.Insert(t);
                        result.Succes = true;
                        
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

        public void Update(User t)
        {
            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Lastname) && t.Lastname.Length < 3)
                {
                    if (!string.IsNullOrEmpty(t.Name))
                    {
                        
                            _userDL.Update(t);
                        
                    }
                    else
                    {
                        throw new Exception("Name cannot be empty");
                    }
                }
                else
                {
                    throw new Exception("Lastname cannot be empty");
                }
            }
            else
            {
                throw new Exception("Cannot insert null object");
            }

        }

        public void Delete(int id)
        {
            _userDL.Delete(id);
        }
    }
}
