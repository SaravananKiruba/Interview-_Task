using System.ComponentModel.DataAnnotations;

namespace Interview__Task.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }
        
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(200)]
        public string UserAddress { get; set; }
    }
}
