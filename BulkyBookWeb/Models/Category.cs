using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public  int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrdar { get; set; }
        public DateTime CreatedDateTIme { get; set; } = DateTime.Now;
    }
}
