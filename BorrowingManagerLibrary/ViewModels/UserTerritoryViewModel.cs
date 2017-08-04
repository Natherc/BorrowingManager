using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.ViewModels
{
    public class UserTerritoryViewModel
    {
        public int Id { get; set; }
        public int TerritoryId { get; set; }
        public int UserId { get; set; }
        public DateTime? BeginBorrowing { get; set; }
        public DateTime? EndBorrowing { get; set; }
        public bool IsDeleted { get; set; }
        public string TerritoryName { get; set; }
        public string TerritoryNumber { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public string UserLastname { get; set; }


    }
}
