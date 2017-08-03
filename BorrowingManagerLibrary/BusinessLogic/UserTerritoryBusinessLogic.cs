using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.BusinessLogic
{
    public class UserTerritoryBusinessLogic
    {
        private UserTerritoryDataLayer _territoryDL = new UserTerritoryDataLayer();

        public UserTerritory GetById(int id)
        {
            return _territoryDL.GetById(id);
        }

        public List<UserTerritory> GetAll()
        {
            return _territoryDL.GetAll();
        }

        public ResultViewModel Insert(UserTerritory t)
        {
            ResultViewModel r = new ResultViewModel();

            if (t != null)
            {
                if (!(t.TerritoryId == 0))
                {
                    if (!(t.UserId == 0))
                    {
                        if(!(t.BeginBorrowing == DateTime.MinValue))
                        {
                            t.BeginBorrowing = DateTime.Now;
                            t.Id = _territoryDL.Insert(t);
                            r.Succes = true;
                        }else
                        {
                            r.ErrorMessage = "BeginBorrowing cannot be empty";
                        }
                        
                    }
                    else
                    {
                        r.ErrorMessage = "UserId cannot be empty";
                    }
                }
                else
                {
                    r.ErrorMessage = "Number cannot be empty";
                }
            }
            else
            {
                r.ErrorMessage = "Cannot insert null object";
            }
            r.Tag = t;
            return r;
        }

        public ResultViewModel Update(UserTerritory t)
        {
            ResultViewModel r = new ResultViewModel();

            if (t != null)
            {
                if (!(t.TerritoryId == 0))
                {
                    if (!(t.UserId == 0))
                    {                       
                            t.Id = _territoryDL.Update(t);
                            r.Succes = true;                      
                    }
                    else
                    {
                        r.ErrorMessage = "UserId cannot be empty";
                    }
                }
                else
                {
                    r.ErrorMessage = "Number cannot be empty";
                }
            }
            else
            {
                r.ErrorMessage = "Cannot insert null object";
            }
            r.Tag = t;
            return r;
        }

        public void Delete(int id)
        {
            _territoryDL.Delete(id);
        }
    }
}
