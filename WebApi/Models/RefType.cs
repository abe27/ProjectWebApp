using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("REFTYPE")]
    public class RefType
    {
        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCRFTYPE")]
        public string? fcrftype { get; set; }

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }

        //public ICollection<Book>? books { get; set; }
    }
}
