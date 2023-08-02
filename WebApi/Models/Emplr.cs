using NanoidDotNet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("EMPLR")]
    public class Emplr
    {
        [Key, Column("FCSKID")]
        public string Fcskid { get; set; } = Nanoid.Generate(size: 8);

        [Column("FCLOGIN")]
        public required string Fclogin { get; set; }

        [Column("FCPW")]
        public required string Fcpw { get; set; }

        [Column("FIMILLISEC")]
        public int Fimillisec { get; set; } = DateTime.Now.Millisecond;

        [Column("FTDATETIME")]
        public DateTime? Ftdatetime { get; set; } = DateTime.Now;

        [Column("FTLASTUPD")]
        public DateTime? Ftlastupd { get; set; } = DateTime.Now;

        [Column("FTLASTEDIT")]
        public DateTime? Ftlastedit { get; set; } = DateTime.Now;

        [Column("FDLSTCHGPA")]
        public DateTime? Fdlstchgpa { get; set; } = DateTime.Now;

        [Column("FDLSTLOGIN")]
        public DateTime? Fdlstlogin { get; set; } = DateTime.Now;
    }
}
