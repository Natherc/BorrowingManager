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

        public Territory Insert(Territory t)
        {
            if(t != null)
            {
                if (!string.IsNullOrEmpty(t.Number))
                {
                    if (!string.IsNullOrEmpty(t.Locality))
                    {
                        if(t.LastBorrowing != DateTime.MinValue)
                        {
                            t.Id = _territoryDL.Insert(t);
                        }else
                        {
                            throw new Exception("LastBorrowing cannot be empty");
                        }
                    }else
                    {
                        throw new Exception("Locality cannot be empty");
                    }
                }else
                {
                    throw new Exception("Number cannot be empty");
                }
            }else
            {
                throw new Exception("Cannot insert null object");
            }
            return t;
        }

        public void Update(Territory t)
        {
            if (t != null)
            {
                if (!string.IsNullOrEmpty(t.Number) && t.Number.Length < 3)
                {
                    if (!string.IsNullOrEmpty(t.Locality))
                    {
                        if (t.LastBorrowing != DateTime.MinValue)
                        {
                             _territoryDL.Update(t);
                        }
                        else
                        {
                            throw new Exception("LastBorrowing cannot be empty");
                        }
                    }
                    else
                    {
                        throw new Exception("Locality cannot be empty");
                    }
                }
                else
                {
                    throw new Exception("Number cannot be empty");
                }
            }
            else
            {
                throw new Exception("Cannot insert null object");
            }
            
        }

        public void Delete(int id)
        {
            _territoryDL.Delete(id);
        }

    }
}
