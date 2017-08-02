using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Model;
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

        public User Insert(User t)
        {
            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Lastname))
                {
                    if (!string.IsNullOrEmpty(t.Name))
                    {
                        
                            t.Id = _userDL.Insert(t);
                        
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
            return t;
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
