using NanoidDotNet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("COOR")]
    public class Coor
    {
        [Key, Column("FCSKID")]
        public string Fcskid { get; set; } = Nanoid.Generate(size: 8);

        [Column("FCCODE")]
        public string? Fccode { get; set; }

        [Column("FCNAME")]
        public string? Fcname { get; set; }
    }
}