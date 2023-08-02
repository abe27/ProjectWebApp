using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("BRANCH")]
    public class Branch
    {
        public Branch()
        {
            corp = new Corp();
        }

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCCORP")]
        [ForeignKey("corp")]
        public string? fccorp { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCNAME2")]
        public string? fcname2 { get; set; }

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }

        [Column("FTSRCUPD")]
        public DateTime? ftsrcupd { get; set; }

        //[Column("FCCORP")]
        [ForeignKey(nameof(fccorp))]
        public virtual Corp? corp { get; set; }
    }
}
