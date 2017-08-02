using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManager
{
    public class Territory
    {
        private string id;
        private string locality;
        private DateTime date;
        public Territory(string id,string locality,DateTime date)
        {
            Id = id;
            Locality = locality;
            Date = date;
        }


        public string Id
        {
            get { return id; }
            set { if (!(value.Length > 2)) {
                    id = value;
                }else
                {
                    value = "none";
                }
            }

        }
        public string Locality { get; set; }

        public DateTime Date { get; set; }
    }
}
    

