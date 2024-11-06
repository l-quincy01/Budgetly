using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
	public class Category
	{
        [Key]
		public int CategoryID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public int Icon { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public int Type { get; set; }

    }
}

