using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.Model
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set;}
        public string Lastname { get; set; }
        public string Name { get; set; }

        public string Mail { get; set; }
    }
}
