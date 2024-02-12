using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string Icon { get; set; }
        [Column]
        public string Type { get; set; }
    }
}
