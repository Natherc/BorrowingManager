using BorrowingManagerLibrary.DataLayer;
using BorrowingManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.BusinessLogic
{
    public class TerritoryBusinessLogic
    {
        private TerritoryDataLayer _territoryDL = new TerritoryDataLayer();
     
        public Territory GetById(int id)
        {
            return _territoryDL.GetById(id);
        }

        public List<Territory> GetAll()
        {
            return _territoryDL.GetAll();
        }

        public ResultViewModel Insert(Territory t)
        {
            ResultViewModel r = new ResultViewModel();

            if(t != null)
            {
                if (!string.IsNullOrEmpty(t.Number))
                {
                    if (!string.IsNullOrEmpty(t.Locality))
                    {
                        t.CreationDate = DateTime.Now;
                            t.Id = _territoryDL.Insert(t);
                            r.Succes = true;
                        
                    }else
                    {
                        r.ErrorMessage = "Locality cannot be empty";
                    }
                }else
                {
                    r.ErrorMessage = "Number cannot be empty";
                }
            }else
            {
                r.ErrorMessage = "Cannot insert null object";
            }
            r.Tag = t;
            return r;
        }

        public ResultViewModel Update(Territory t)
        {
            ResultViewModel r = new ResultViewModel();

            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Number))
                {
                    if (!string.IsNullOrEmpty(t.Locality))
                    {
                        t.CreationDate = DateTime.Now;
                         _territoryDL.Update(t);
                        r.Succes = true;

                    }
                    else
                    {
                        r.ErrorMessage = "Locality cannot be empty";
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
