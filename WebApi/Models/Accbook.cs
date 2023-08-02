using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("ACCBOOK")]
    public class Accbook
    {
        [Key, Column("FCSKID")]
        public string? fcskid { get; set; }//FCSKID string `gorm:"primaryKey;column:FCSKID;size:8;unique;index;" json:"fcskid"  form:"fcskid" `
        [Column("FCCODE")]
        public string? fccode { get; set; }//FCCODE string `gorm:"column:FCCODE;" json:"fccode"  form:"fccode" `
        [Column("FCNAME")]
        public string? fcname { get; set; }//FCNAME string `gorm:"column:FCNAME;" json:"fcname"  form:"fcname" `
        [Column("FCCORP")]
        public string? fccorp { get; set; }//FCCORP string `gorm:"column:FCCORP;" json:"fccorp"  form:"fccorp" `
        [Column("FCNAME2")]
        public string? fcname2 { get; set; }//FCNAME2 string `gorm:"column:FCNAME2;" json:"fcname2"  form:"fcname2" `
    }
}
