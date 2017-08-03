using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.Models
{
    public class UserTerritory
    {
        public int Id { get; set; }
        public int TerritoryId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginBorrowing { get; set; }
        public DateTime? EndBorrowing { get; set; }
        public bool IsDeleted { get; set; }
    }
}
