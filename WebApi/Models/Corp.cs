using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("CORP")]
    public class Corp
    {
        //public Corp()
        //{
        //    branch = new Branch();
        //}

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCNAME2")]
        public string? fcname2 { get; set; }

        [Column("FCTAXID")]
        public string? fctaxid { get; set; }

        [Column("FCADDR1")]
        public string? fcaddr1 { get; set; }

        [Column("FCADDR12")]
        public string? fcaddr12 { get; set; }

        [Column("FCADDR2")]
        public string? fcaddr2 { get; set; }

        [Column("FCADDR22")]
        public string? fcaddr22 { get; set; }

        [Column("FCTEL")]
        public string? fctel { get; set; }

        [Column("FCFAX")]
        public string? fcfax { get; set; }

        ////[Column("FCCORP")]
        //[ForeignKey(nameof(fcskid))]
        //public virtual Branch? branch { get; set; }
    }
}
