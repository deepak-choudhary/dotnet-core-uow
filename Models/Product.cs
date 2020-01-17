using System.ComponentModel.DataAnnotations;
namespace unitofwork.Models
{
    public class Product
    {
        public string UserName { get; set; }
        public string ProductName { get; set; }
        [Key]
        public long ProductId { get;  set; }

       
        public User User { get; set; }
    }
}