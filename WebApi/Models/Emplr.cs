using System.ComponentModel.DataAnnotations;
using WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("EMPLR")]
    public class Emplr
    {
        [Key, Column("FCSKID")]
        public string? Fcskid { get; set; }

        [Column("FCLOGIN"), Required]
        public string? Fclogin { get; set; }

        [Column("FCPW"), Required]
        public string? Fcpw { get; set; }

        [Column("FTLASTUPD")]
        public DateTime? Ftlastupd { get; set; }

        [Column("FTLASTEDIT")]
        public DateTime? Ftlastedit { get; set; }

        [Column("FDLSTCHGPA")]
        public DateTime? Fdlstchgpa { get; set; }

        [Column("FDLSTLOGIN")]
        public DateTime? Fdlstlogin { get; set; }
    }
}
