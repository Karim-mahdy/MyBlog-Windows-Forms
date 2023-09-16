using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabD03.Models
{
    internal class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        public int Age { get; set; }

        public byte[]? Image { get; set; }

        [StringLength(50)]
        [Required]
        public string Password { get; set; }


        [NotMapped]
        [StringLength(50)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
