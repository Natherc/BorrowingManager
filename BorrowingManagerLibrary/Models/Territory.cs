using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.Models
{
    public class Territory
    {
        public Territory()
        {
        }
        
        public string Number{get;set;}
        public string Locality { get; set; }
        public DateTime CreationDate{ get; set; }
        public int Id { get; set; }
    }
}
    

