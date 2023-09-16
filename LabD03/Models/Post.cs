using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabD03.Models
{
    internal class Post
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Bref { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public byte[]? Image { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PostDate { get; set; }

        [Column(TypeName = "time")] 
        public TimeSpan? PostTime { get; set; }


        [ForeignKey(nameof(Author))]
        public int Author_Id { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey(nameof(Catalog))]
        public int Catalog_Id { get; set; }
        public virtual Catalog Catalog { get; set; }
    }
}
