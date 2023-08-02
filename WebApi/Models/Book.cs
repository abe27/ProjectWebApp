using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApi.Models
{
    [Table("BOOK")]
    public class Book
    {
        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCPREFIX")]
        public string? fcprefix { get; set; }

        [Column("FCREFTYPE")]
        [ForeignKey("ref_type")]
        public string? fcreftype { get; set; }

        [Column("FCREFTYPE")]
        [ForeignKey(nameof(fcreftype))]
        public RefType? ref_type { get; set; }
    }
}
