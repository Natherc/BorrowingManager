using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.Models
{
    public class ResultViewModel
    {
        public bool Succes { get; set; }
        public string ErrorMessage { get; set; }
        public Object Tag { get; set; }
    }
}
