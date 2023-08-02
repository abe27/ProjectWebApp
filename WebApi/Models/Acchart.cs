using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("ACCHART")]
    public class Acchart
    {
        [Column("FCACLINK")]
        // FCACLINK string    `gorm:"column:FCACLINK;" json:"fcaclink"  form:"fcaclink" `
        public string? fcaclink { get; set; }
        [Column("FCADDAPVBY")]
        // FCADDAPVBY string    `gorm:"column:FCADDAPVBY;" json:"fcaddapvby"  form:"fcaddapvby" `
        public string? fcaddapvby { get; set; }
        [Column("FCAPPNAME")]
        // FCAPPNAME string    `gorm:"column:FCAPPNAME;" json:"fcappname"  form:"fcappname" `
        public string? fcappname { get; set; }
        [Column("FCBAKYRHIS")]
        // FCBAKYRHIS string    `gorm:"column:FCBAKYRHIS;" json:"fcbakyrhis"  form:"fcbakyrhis" `
        public string? fcbakyrhis { get; set; }
        [Column("FCCASHACT")]
        // FCCASHACT string    `gorm:"column:FCCASHACT;" json:"fccashact"  form:"fccashact" `
        public string? fccashact { get; set; }
        [Column("FCCATEG")]
        // FCCATEG string    `gorm:"column:FCCATEG;" json:"fccateg"  form:"fccateg" `
        public string? fccateg { get; set; }
        [Column("FCCATEG2")]
        // FCCATEG2 string    `gorm:"column:FCCATEG2;" json:"fccateg2"  form:"fccateg2" `
        public string? fccateg2 { get; set; }
        [Column("FCCODE")]
        // FCCODE string    `gorm:"column:FCCODE;" json:"fccode"  form:"fccode" `
        public string? fccode { get; set; }
        [Column("FCCOLSEND")]
        // FCCOLSEND string    `gorm:"column:FCCOLSEND;" json:"fccolsend"  form:"fccolsend" `
        public string? fccolsend { get; set; }
        [Column("FCCORPCHAR")]
        // FCCORPCHAR string    `gorm:"column:FCCORPCHAR;" json:"fccorpchar"  form:"fccorpchar" `
        public string? fccorpchar { get; set; }
        [Column("FCCORRECTB")]
        // FCCORRECTB string    `gorm:"column:FCCORRECTB;" json:"fccorrectb"  form:"fccorrectb" `
        public string? fccorrectb { get; set; }
        [Column("FCCREATEAP")]
        // FCCREATEAP string    `gorm:"column:FCCREATEAP;" json:"fccreateap"  form:"fccreateap" `
        public string? fccreateap { get; set; }
        [Column("FCCREATEBY")]
        // FCCREATEBY string    `gorm:"column:FCCREATEBY;" json:"fccreateby"  form:"fccreateby" `
        public string? fccreateby { get; set; }
        [Column("FCCREATETY")]
        // FCCREATETY string    `gorm:"column:FCCREATETY;" json:"fccreatety"  form:"fccreatety" `
        public string? fccreatety { get; set; }
        [Column("FCCUACC")]
        // FCCUACC string    `gorm:"column:FCCUACC;" json:"fccuacc"  form:"fccuacc" `
        public string? fccuacc { get; set; }
        [Column("FCDATAIMP")]
        // FCDATAIMP string    `gorm:"column:FCDATAIMP;" json:"fcdataimp"  form:"fcdataimp" `
        public string? fcdataimp { get; set; }
        [Column("FCDATASER")]
        // FCDATASER string    `gorm:"column:FCDATASER;" json:"fcdataser"  form:"fcdataser" `
        public string? fcdataser { get; set; }
        [Column("FCDELAPVBY")]
        // FCDELAPVBY string    `gorm:"column:FCDELAPVBY;" json:"fcdelapvby"  form:"fcdelapvby" `
        public string? fcdelapvby { get; set; }
        [Column("FCDRCR")]
        // FCDRCR string    `gorm:"column:FCDRCR;" json:"fcdrcr"  form:"fcdrcr" `
        public string? fcdrcr { get; set; }
        [Column("FCDTYPE1")]
        // FCDTYPE1 string    `gorm:"column:FCDTYPE1;" json:"fcdtype1"  form:"fcdtype1" `
        public string? fcdtype1 { get; set; }
        [Column("FCDTYPE2")]
        // FCDTYPE2 string    `gorm:"column:FCDTYPE2;" json:"fcdtype2"  form:"fcdtype2" `
        public string? fcdtype2 { get; set; }
        [Column("FCDTYPE3")]
        // FCDTYPE3 string    `gorm:"column:FCDTYPE3;" json:"fcdtype3"  form:"fcdtype3" `
        public string? fcdtype3 { get; set; }
        [Column("FCDTYPE4")]
        // FCDTYPE4 string    `gorm:"column:FCDTYPE4;" json:"fcdtype4"  form:"fcdtype4" `
        public string? fcdtype4 { get; set; }
        [Column("FCDTYPE5")]
        // FCDTYPE5 string    `gorm:"column:FCDTYPE5;" json:"fcdtype5"  form:"fcdtype5" `
        public string? fcdtype5 { get; set; }
        [Column("FCDTYPE6")]
        // FCDTYPE6 string    `gorm:"column:FCDTYPE6;" json:"fcdtype6"  form:"fcdtype6" `
        public string? fcdtype6 { get; set; }
        [Column("FCDTYPE7")]
        // FCDTYPE7 string    `gorm:"column:FCDTYPE7;" json:"fcdtype7"  form:"fcdtype7" `
        public string? fcdtype7 { get; set; }
        [Column("FCDTYPE8")]
        // FCDTYPE8 string    `gorm:"column:FCDTYPE8;" json:"fcdtype8"  form:"fcdtype8" `
        public string? fcdtype8 { get; set; }
        [Column("FCDTYPE9")]
        // FCDTYPE9 string    `gorm:"column:FCDTYPE9;" json:"fcdtype9"  form:"fcdtype9" `
        public string? fcdtype9 { get; set; }
        [Column("FCEAFTERR")]
        // FCEAFTERR string    `gorm:"column:FCEAFTERR;" json:"fceafterr"  form:"fceafterr" `
        public string? fceafterr { get; set; }
        [Column("FCEDTAPVBY")]
        // FCEDTAPVBY string    `gorm:"column:FCEDTAPVBY;" json:"fcedtapvby"  form:"fcedtapvby" `
        public string? fcedtapvby { get; set; }
        [Column("FCFCHR")]
        // FCFCHR string    `gorm:"column:FCFCHR;" json:"fcfchr"  form:"fcfchr" `
        public string? fcfchr { get; set; }
        [Column("FCFILTJOB")]
        // FCFILTJOB string    `gorm:"column:FCFILTJOB;" json:"fcfiltjob"  form:"fcfiltjob" `
        public string? fcfiltjob { get; set; }
        [Column("FCFILTSECT")]
        // FCFILTSECT string    `gorm:"column:FCFILTSECT;" json:"fcfiltsect"  form:"fcfiltsect" `
        public string? fcfiltsect { get; set; }
        [Column("FCGID")]
        // FCGID string    `gorm:"column:FCGID;" json:"fcgid"  form:"fcgid" `
        public string? fcgid { get; set; }
        [Column("FCGROUP")]
        // FCGROUP string    `gorm:"column:FCGROUP;" json:"fcgroup"  form:"fcgroup" `
        public string? fcgroup { get; set; }
        [Column("FCISUSED")]
        // FCISUSED string    `gorm:"column:FCISUSED;" json:"fcisused"  form:"fcisused" `
        public string? fcisused { get; set; }
        [Column("FCLID")]
        // FCLID string    `gorm:"column:FCLID;" json:"fclid"  form:"fclid" `
        public string? fclid { get; set; }
        [Column("FCLUPDAPP")]
        // FCLUPDAPP string    `gorm:"column:FCLUPDAPP;" json:"fclupdapp"  form:"fclupdapp" `
        public string? fclupdapp { get; set; }
        [Column("FCMANFLAG")]
        // FCMANFLAG string    `gorm:"column:FCMANFLAG;" json:"fcmanflag"  form:"fcmanflag" `
        public string? fcmanflag { get; set; }
        [Column("FCNAME")]
        // FCNAME string    `gorm:"column:FCNAME;" json:"fcname"  form:"fcname" `
        public string? fcname { get; set; }
        [Column("FCNAME2")]
        // FCNAME2 string    `gorm:"column:FCNAME2;" json:"fcname2"  form:"fcname2" `
        public string? fcname2 { get; set; }
        [Column("FCORGCODE")]
        // FCORGCODE string    `gorm:"column:FCORGCODE;" json:"fcorgcode"  form:"fcorgcode" `
        public string? fcorgcode { get; set; }
        [Column("FCSELTAG")]
        // FCSELTAG string    `gorm:"column:FCSELTAG;" json:"fcseltag"  form:"fcseltag" `
        public string? fcseltag { get; set; }
        [Key, Column("FCSKID")]
        // FCSKID string    `gorm:"primaryKey;column:FCSKID;size:8;unique;index;" json:"fcskid"  form:"fcskid" `
        public string? fcskid { get; set; }
        [Column("FCSRCUPD")]
        // FCSRCUPD string    `gorm:"column:FCSRCUPD;" json:"fcsrcupd"  form:"fcsrcupd" `
        public string? fcsrcupd { get; set; }
        [Column("FCSTATUS")]
        // FCSTATUS string    `gorm:"column:FCSTATUS;" json:"fcstatus"  form:"fcstatus" `
        public string? fcstatus { get; set; }
        [Column("FCU1ACC")]
        // FCU1ACC string    `gorm:"column:FCU1ACC;" json:"fcu1acc"  form:"fcu1acc" `
        public string? fcu1acc { get; set; }
        [Column("FCU1STATUS")]
        // FCU1STATUS string    `gorm:"column:FCU1STATUS;" json:"fcu1status"  form:"fcu1status" `
        public string? fcu1status { get; set; }
        [Column("FCU2STATUS")]
        // FCU2STATUS string    `gorm:"column:FCU2STATUS;" json:"fcu2status"  form:"fcu2status" `
        public string? fcu2status { get; set; }
        [Column("FCU3STATUS")]
        // FCU3STATUS string    `gorm:"column:FCU3STATUS;" json:"fcu3status"  form:"fcu3status" `
        public string? fcu3status { get; set; }
        [Column("FCU4STATUS")]
        // FCU4STATUS string    `gorm:"column:FCU4STATUS;" json:"fcu4status"  form:"fcu4status" `
        public string? fcu4status { get; set; }
        [Column("FCU5STATUS")]
        // FCU5STATUS string    `gorm:"column:FCU5STATUS;" json:"fcu5status"  form:"fcu5status" `
        public string? fcu5status { get; set; }
        [Column("FCU6STATUS")]
        // FCU6STATUS string    `gorm:"column:FCU6STATUS;" json:"fcu6status"  form:"fcu6status" `
        public string? fcu6status { get; set; }
        [Column("FCU7STATUS")]
        // FCU7STATUS string    `gorm:"column:FCU7STATUS;" json:"fcu7status"  form:"fcu7status" `
        public string? fcu7status { get; set; }
        [Column("FCU8STATUS")]
        // FCU8STATUS string    `gorm:"column:FCU8STATUS;" json:"fcu8status"  form:"fcu8status" `
        public string? fcu8status { get; set; }
        [Column("FCU9STATUS")]
        // FCU9STATUS string    `gorm:"column:FCU9STATUS;" json:"fcu9status"  form:"fcu9status" `
        public string? fcu9status { get; set; }
        [Column("FCUDATE")]
        // FCUDATE string    `gorm:"column:FCUDATE;" json:"fcudate"  form:"fcudate" `
        public string? fcudate { get; set; }
        [Column("FCUTIME")]
        // FCUTIME string    `gorm:"column:FCUTIME;" json:"fcutime"  form:"fcutime" `
        public string? fcutime { get; set; }
        [Column("FDINACTIVE")]
        // FDINACTIVE string    `gorm:"column:FDINACTIVE;" json:"fdinactive"  form:"fdinactive" `
        public string? fdinactive { get; set; }
        [Column("FIMILLISEC")]
        // FIMILLISEC int64     `gorm:"column:FIMILLISEC;" json:"fimillisec"  form:"fimillisec" `
        public int? fimillisec { get; set; }
        [Column("FMERRMSG")]
        // FMERRMSG string    `gorm:"column:FMERRMSG;" json:"fmerrmsg"  form:"fmerrmsg" `
        public string? fmerrmsg { get; set; }
        [Column("FMEXTRATAG")]
        // FMEXTRATAG string    `gorm:"column:FMEXTRATAG;" json:"fmextratag"  form:"fmextratag" `
        public string? fmextratag { get; set; }
        [Column("FNFIXED")]
        // FNFIXED float64   `gorm:"column:FNFIXED;" json:"fnfixed"  form:"fnfixed" `
        public decimal fnfixed { get; set; }
        [Column("FNLEVEL")]
        // FNLEVEL float64   `gorm:"column:FNLEVEL;" json:"fnlevel"  form:"fnlevel" `
        public decimal fnlevel { get; set; }
        [Column("FNU1CNT")]
        // FNU1CNT float64   `gorm:"column:FNU1CNT;" json:"fnu1cnt"  form:"fnu1cnt" `
        public decimal fnu1cnt { get; set; }
        [Column("FNU2CNT")]
        // FNU2CNT float64   `gorm:"column:FNU2CNT;" json:"fnu2cnt"  form:"fnu2cnt" `
        public decimal fnu2cnt { get; set; }
        [Column("FNU3CNT")]
        // FNU3CNT float64   `gorm:"column:FNU3CNT;" json:"fnu3cnt"  form:"fnu3cnt" `
        public decimal fnu3cnt { get; set; }
        [Column("FNU4CNT")]
        // FNU4CNT float64   `gorm:"column:FNU4CNT;" json:"fnu4cnt"  form:"fnu4cnt" `
        public decimal fnu4cnt { get; set; }
        [Column("FNU5CNT")]
        // FNU5CNT float64   `gorm:"column:FNU5CNT;" json:"fnu5cnt"  form:"fnu5cnt" `
        public decimal fnu5cnt { get; set; }
        [Column("FNU6CNT")]
        // FNU6CNT float64   `gorm:"column:FNU6CNT;" json:"fnu6cnt"  form:"fnu6cnt" `
        public decimal fnu6cnt { get; set; }
        [Column("FNU7CNT")]
        // FNU7CNT float64   `gorm:"column:FNU7CNT;" json:"fnu7cnt"  form:"fnu7cnt" `
        public decimal fnu7cnt { get; set; }
        [Column("FNU8CNT")]
        // FNU8CNT float64   `gorm:"column:FNU8CNT;" json:"fnu8cnt"  form:"fnu8cnt" `
        public decimal fnu8cnt { get; set; }
        [Column("FNU9CNT")]
        // FNU9CNT float64   `gorm:"column:FNU9CNT;" json:"fnu9cnt"  form:"fnu9cnt" `
        public decimal fnu9cnt { get; set; }
        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }// FTDATETIME time.Time `gorm:"column:FTDATETIME;" json:"ftdatetime"  form:"ftdatetime" default:"now"`
        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }// FTLASTEDIT time.Time `gorm:"column:FTLASTEDIT;" json:"ftlastedit"  form:"ftlastedit" default:"now"`
        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }// FTLASTUPD time.Time `gorm:"column:FTLASTUPD;" json:"ftlastupd"  form:"ftlastupd" default:"now"`
        [Column("FTSRCUPD")]
        public DateTime? ftsrcupd { get; set; }// FTSRCUPD time.Time `gorm:"column:FTSRCUPD;" json:"ftsrcupd"  form:"ftsrcupd" default:"now"`
    }
}
