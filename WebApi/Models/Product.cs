using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Table("PROD")]
    public class Product
    {
        [Column("FCACCBCASH")]// string    `gorm:"column:FCACCBCASH;" json:"fcaccbcash"  form:"fcaccbcash" `
        public string? fcaccbcash { get; set; }

        [Column("FCACCBCRED")]// string    `gorm:"column:FCACCBCRED;" json:"fcaccbcred"  form:"fcaccbcred" `
        public string? fcaccbcred { get; set; }

        [Column("FCACCCONSP")]// string    `gorm:"column:FCACCCONSP;" json:"fcaccconsp"  form:"fcaccconsp" `
        public string? fcaccconsp { get; set; }

        [Column("FCACCEXP1")]// string    `gorm:"column:FCACCEXP1;" json:"fcaccexp1"  form:"fcaccexp1" `
        public string? fcaccexp1 { get; set; }

        [Column("FCACCITEM")]// string    `gorm:"column:FCACCITEM;" json:"fcaccitem"  form:"fcaccitem" `
        public string? fcaccitem { get; set; }

        [Column("FCACCSCASH")]// string    `gorm:"column:FCACCSCASH;" json:"fcaccscash"  form:"fcaccscash" `
        public string? fcaccscash { get; set; }

        [Column("FCACCSCOST")]// string    `gorm:"column:FCACCSCOST;" json:"fcaccscost"  form:"fcaccscost" `
        public string? fcaccscost { get; set; }

        [Column("FCACCSCRED")]// string    `gorm:"column:FCACCSCRED;" json:"fcaccscred"  form:"fcaccscred" `
        public string? fcaccscred { get; set; }

        [Column("FCACCVER")]// string    `gorm:"column:FCACCVER;" json:"fcaccver"  form:"fcaccver" `
        public string? fcaccver { get; set; }

        [Column("FCACCWIP")]// string    `gorm:"column:FCACCWIP;" json:"fcaccwip"  form:"fcaccwip" `
        public string? fcaccwip { get; set; }

        [Column("FCACCWR1")]// string    `gorm:"column:FCACCWR1;" json:"fcaccwr1"  form:"fcaccwr1" `
        public string? fcaccwr1 { get; set; }

        [Column("FCACCWR2")]// string    `gorm:"column:FCACCWR2;" json:"fcaccwr2"  form:"fcaccwr2" `
        public string? fcaccwr2 { get; set; }

        [Column("FCADDAPVBY")]// string    `gorm:"column:FCADDAPVBY;" json:"fcaddapvby"  form:"fcaddapvby" `
        public string? fcaddapvby { get; set; }

        [Column("FCAPPNAME")]// string    `gorm:"column:FCAPPNAME;" json:"fcappname"  form:"fcappname" `
        public string? fcappname { get; set; }

        [Column("FCAPPROVEB")]// string    `gorm:"column:FCAPPROVEB;" json:"fcapproveb"  form:"fcapproveb" `
        public string? fcapproveb { get; set; }

        [Column("FCAUTOGW1")]// string    `gorm:"column:FCAUTOGW1;" json:"fcautogw1"  form:"fcautogw1" `
        public string? fcautogw1 { get; set; }

        [Column("FCBAKYRHIS")]// string    `gorm:"column:FCBAKYRHIS;" json:"fcbakyrhis"  form:"fcbakyrhis" `
        public string? fcbakyrhis { get; set; }

        [Column("FCBARCODE")]// string    `gorm:"column:FCBARCODE;" json:"fcbarcode"  form:"fcbarcode" `
        public string? fcbarcode { get; set; }

        [Column("FCBRANCH")]// string    `gorm:"column:FCBRANCH;" json:"fcbranch"  form:"fcbranch" `
        public string? fcbranch { get; set; }

        [Column("FCBUDCHART")]// string    `gorm:"column:FCBUDCHART;" json:"fcbudchart"  form:"fcbudchart" `
        public string? fcbudchart { get; set; }

        [Column("FCBVATISOU")]// string    `gorm:"column:FCBVATISOU;" json:"fcbvatisou"  form:"fcbvatisou" `
        public string? fcbvatisou { get; set; }

        [Column("FCBWHOUSE")]// string    `gorm:"column:FCBWHOUSE;" json:"fcbwhouse"  form:"fcbwhouse" `
        public string? fcbwhouse { get; set; }

        [Column("FCCODE")]// string    `gorm:"column:FCCODE;" json:"fccode"  form:"fccode" `
        public string? fccode { get; set; }

        [Column("FCCOLSEND")]// string    `gorm:"column:FCCOLSEND;" json:"fccolsend"  form:"fccolsend" `
        public string? fccolsend { get; set; }

        [Column("FCCOPYREMA")]// string    `gorm:"column:FCCOPYREMA;" json:"fccopyrema"  form:"fccopyrema" `
        public string? fccopyrema { get; set; }

        [Column("FCCORP")]// string    `gorm:"column:FCCORP;" json:"fccorp"  form:"fccorp" `
        public string? fccorp { get; set; }

        [Column("FCCORRECTB")]// string    `gorm:"column:FCCORRECTB;" json:"fccorrectb"  form:"fccorrectb" `
        public string? fccorrectb { get; set; }

        [Column("FCCOSTBASE")]// string    `gorm:"column:FCCOSTBASE;" json:"fccostbase"  form:"fccostbase" `
        public string? fccostbase { get; set; }

        [Column("FCCREATEAP")]// string    `gorm:"column:FCCREATEAP;" json:"fccreateap"  form:"fccreateap" `
        public string? fccreateap { get; set; }

        [Column("FCCREATEBY")]// string    `gorm:"column:FCCREATEBY;" json:"fccreateby"  form:"fccreateby" `
        public string? fccreateby { get; set; }

        [Column("FCCREATETY")]// string    `gorm:"column:FCCREATETY;" json:"fccreatety"  form:"fccreatety" `
        public string? fccreatety { get; set; }

        [Column("FCCTRLSTOC")]// string    `gorm:"column:FCCTRLSTOC;" json:"fcctrlstoc"  form:"fcctrlstoc" `
        public string? fcctrlstoc { get; set; }

        [Column("FCCUACC")]// string    `gorm:"column:FCCUACC;" json:"fccuacc"  form:"fccuacc" `
        public string? fccuacc { get; set; }

        [Column("FCCURR1")]// string    `gorm:"column:FCCURR1;" json:"fccurr1"  form:"fccurr1" `
        public string? fccurr1 { get; set; }

        [Column("FCCURR2")]// string    `gorm:"column:FCCURR2;" json:"fccurr2"  form:"fccurr2" `
        public string? fccurr2 { get; set; }

        [Column("FCCURRENCY")]// string    `gorm:"column:FCCURRENCY;" json:"fccurrency"  form:"fccurrency" `
        public string? fccurrency { get; set; }

        [Column("FCCUST")]// string    `gorm:"column:FCCUST;" json:"fccust"  form:"fccust" `
        public string? fccust { get; set; }

        [Column("FCDATAIMP")]// string    `gorm:"column:FCDATAIMP;" json:"fcdataimp"  form:"fcdataimp" `
        public string? fcdataimp { get; set; }

        [Column("FCDATASER")]// string    `gorm:"column:FCDATASER;" json:"fcdataser"  form:"fcdataser" `
        public string? fcdataser { get; set; }

        [Column("FCDELAPVBY")]// string    `gorm:"column:FCDELAPVBY;" json:"fcdelapvby"  form:"fcdelapvby" `
        public string? fcdelapvby { get; set; }

        [Column("FCDFAUMRAT")]// string    `gorm:"column:FCDFAUMRAT;" json:"fcdfaumrat"  form:"fcdfaumrat" `
        public string? fcdfaumrat { get; set; }

        [Column("FCDISCSTR")]// string    `gorm:"column:FCDISCSTR;" json:"fcdiscstr"  form:"fcdiscstr" `
        public string? fcdiscstr { get; set; }

        [Column("FCDTYPE1")]// string    `gorm:"column:FCDTYPE1;" json:"fcdtype1"  form:"fcdtype1" `
        public string? fcdtype1 { get; set; }

        [Column("FCDTYPE2")]// string    `gorm:"column:FCDTYPE2;" json:"fcdtype2"  form:"fcdtype2" `
        public string? fcdtype2 { get; set; }

        [Column("FCDTYPE3")]// string    `gorm:"column:FCDTYPE3;" json:"fcdtype3"  form:"fcdtype3" `
        public string? fcdtype3 { get; set; }

        [Column("FCDTYPE4")]// string    `gorm:"column:FCDTYPE4;" json:"fcdtype4"  form:"fcdtype4" `
        public string? fcdtype4 { get; set; }

        [Column("FCDTYPE5")]// string    `gorm:"column:FCDTYPE5;" json:"fcdtype5"  form:"fcdtype5" `
        public string? fcdtype5 { get; set; }

        [Column("FCDTYPE6")]// string    `gorm:"column:FCDTYPE6;" json:"fcdtype6"  form:"fcdtype6" `
        public string? fcdtype6 { get; set; }

        [Column("FCDTYPE7")]// string    `gorm:"column:FCDTYPE7;" json:"fcdtype7"  form:"fcdtype7" `
        public string? fcdtype7 { get; set; }

        [Column("FCDTYPE8")]// string    `gorm:"column:FCDTYPE8;" json:"fcdtype8"  form:"fcdtype8" `
        public string? fcdtype8 { get; set; }

        [Column("FCDTYPE9")]// string    `gorm:"column:FCDTYPE9;" json:"fcdtype9"  form:"fcdtype9" `
        public string? fcdtype9 { get; set; }

        [Column("FCEAFTERR")]// string    `gorm:"column:FCEAFTERR;" json:"fceafterr"  form:"fceafterr" `
        public string? fceafterr { get; set; }

        [Column("FCEDPRICE")]// string    `gorm:"column:FCEDPRICE;" json:"fcedprice"  form:"fcedprice" `
        public string? fcedprice { get; set; }

        [Column("FCEDTAPVBY")]// string    `gorm:"column:FCEDTAPVBY;" json:"fcedtapvby"  form:"fcedtapvby" `
        public string? fcedtapvby { get; set; }

        [Column("FCEXPCUR1")]// string    `gorm:"column:FCEXPCUR1;" json:"fcexpcur1"  form:"fcexpcur1" `
        public string? fcexpcur1 { get; set; }

        [Column("FCEXPCUR2")]// string    `gorm:"column:FCEXPCUR2;" json:"fcexpcur2"  form:"fcexpcur2" `
        public string? fcexpcur2 { get; set; }

        [Column("FCFCHR")]// string    `gorm:"column:FCFCHR;" json:"fcfchr"  form:"fcfchr" `
        public string? fcfchr { get; set; }

        [Column("FCFCHRS")]// string    `gorm:"column:FCFCHRS;" json:"fcfchrs"  form:"fcfchrs" `
        public string? fcfchrs { get; set; }

        [Column("FCFORMULAS")]// string    `gorm:"column:FCFORMULAS;" json:"fcformulas"  form:"fcformulas" `
        public string? fcformulas { get; set; }

        [Column("FCGID")]// string    `gorm:"column:FCGID;" json:"fcgid"  form:"fcgid" `
        public string? fcgid { get; set; }

        [Column("FCHASSALE")]// string    `gorm:"column:FCHASSALE;" json:"fchassale"  form:"fchassale" `
        public string? fchassale { get; set; }

        [Column("FCISUSED")]// string    `gorm:"column:FCISUSED;" json:"fcisused"  form:"fcisused" `
        public string? fcisused { get; set; }

        [Column("FCIUM")]// string    `gorm:"column:FCIUM;" json:"fcium"  form:"fcium" `
        public string? fcium { get; set; }

        [Column("FCLASTUM")]// string    `gorm:"column:FCLASTUM;" json:"fclastum"  form:"fclastum" `
        public string? fclastum { get; set; }

        [Column("FCLID")]// string    `gorm:"column:FCLID;" json:"fclid"  form:"fclid" `
        public string? fclid { get; set; }

        [Column("FCLOCATION")]// string    `gorm:"column:FCLOCATION;" json:"fclocation"  form:"fclocation" `
        public string? fclocation { get; set; }

        [Column("FCLUPDAPP")]// string    `gorm:"column:FCLUPDAPP;" json:"fclupdapp"  form:"fclupdapp" `
        public string? fclupdapp { get; set; }

        [Column("FCMANFLAG")]// string    `gorm:"column:FCMANFLAG;" json:"fcmanflag"  form:"fcmanflag" `
        public string? fcmanflag { get; set; }

        [Column("FCMANUFAC")]// string    `gorm:"column:FCMANUFAC;" json:"fcmanufac"  form:"fcmanufac" `
        public string? fcmanufac { get; set; }

        [Column("FCMCTRLSTO")]// string    `gorm:"column:FCMCTRLSTO;" json:"fcmctrlsto"  form:"fcmctrlsto" `
        public string? fcmctrlsto { get; set; }

        [Column("FCMEASURE")]// string    `gorm:"column:FCMEASURE;" json:"fcmeasure"  form:"fcmeasure" `
        public string? fcmeasure { get; set; }

        [Column("FCMFUM")]// string    `gorm:"column:FCMFUM;" json:"fcmfum"  form:"fcmfum" `
        public string? fcmfum { get; set; }

        [Column("FCMRPXFER")]// string    `gorm:"column:FCMRPXFER;" json:"fcmrpxfer"  form:"fcmrpxfer" `
        public string? fcmrpxfer { get; set; }

        [Column("FCNAME")]// string    `gorm:"column:FCNAME;" json:"fcname"  form:"fcname" `
        public string? fcname { get; set; }

        [Column("FCNAME2")]// string    `gorm:"column:FCNAME2;" json:"fcname2"  form:"fcname2" `
        public string? fcname2 { get; set; }

        [Column("FCORGCODE")]// string    `gorm:"column:FCORGCODE;" json:"fcorgcode"  form:"fcorgcode" `
        public string? fcorgcode { get; set; }

        [Column("FCPDCAT")]// string    `gorm:"column:FCPDCAT;" json:"fcpdcat"  form:"fcpdcat" `
        public string? fcpdcat { get; set; }

        [Column("FCPDGRP")]// string    `gorm:"column:FCPDGRP;" json:"fcpdgrp"  form:"fcpdgrp" `
        public string? fcpdgrp { get; set; }

        [Column("FCPLANT")]// string    `gorm:"column:FCPLANT;" json:"fcplant"  form:"fcplant" `
        public string? fcplant { get; set; }

        [Column("FCPRCGRP")]// string    `gorm:"column:FCPRCGRP;" json:"fcprcgrp"  form:"fcprcgrp" `
        public string? fcprcgrp { get; set; }

        [Column("FCPROCURE")]// string    `gorm:"column:FCPROCURE;" json:"fcprocure"  form:"fcprocure" `
        public string? fcprocure { get; set; }

        [Column("FCPRTYPE")]// string    `gorm:"column:FCPRTYPE;" json:"fcprtype"  form:"fcprtype" `
        public string? fcprtype { get; set; }

        [Column("FCSECT")]// string    `gorm:"column:FCSECT;" json:"fcsect"  form:"fcsect" `
        public string? fcsect { get; set; }

        [Column("FCSELTAG")]// string    `gorm:"column:FCSELTAG;" json:"fcseltag"  form:"fcseltag" `
        public string? fcseltag { get; set; }

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]// string    `gorm:"primaryKey;column:FCSKID;size:8;unique;index;" json:"fcskid"  form:"fcskid" `
        public string? fcskid { get; set; }

        [Column("FCSNAME")]// string    `gorm:"column:FCSNAME;" json:"fcsname"  form:"fcsname" `
        public string? fcsname { get; set; }

        [Column("FCSNAME2")]// string    `gorm:"column:FCSNAME2;" json:"fcsname2"  form:"fcsname2" `
        public string? fcsname2 { get; set; }

        [Column("FCSOURCE")]// string    `gorm:"column:FCSOURCE;" json:"fcsource"  form:"fcsource" `
        public string? fcsource { get; set; }

        [Column("FCSRCUPD")]// string    `gorm:"column:FCSRCUPD;" json:"fcsrcupd"  form:"fcsrcupd" `
        public string? fcsrcupd { get; set; }

        [Column("FCSTATUS")]// string    `gorm:"column:FCSTATUS;" json:"fcstatus"  form:"fcstatus" `
        public string? fcstatus { get; set; }

        [Column("FCSTCTRLST")]// string    `gorm:"column:FCSTCTRLST;" json:"fcstctrlst"  form:"fcstctrlst" `
        public string? fcstctrlst { get; set; }

        [Column("FCSTEP")]// string    `gorm:"column:FCSTEP;" json:"fcstep"  form:"fcstep" `
        public string? fcstep { get; set; }

        [Column("FCSTIUM")]// string    `gorm:"column:FCSTIUM;" json:"fcstium"  form:"fcstium" `
        public string? fcstium { get; set; }

        [Column("FCSTUM")]// string    `gorm:"column:FCSTUM;" json:"fcstum"  form:"fcstum" `
        public string? fcstum { get; set; }

        [Column("FCSTUM1")]// string    `gorm:"column:FCSTUM1;" json:"fcstum1"  form:"fcstum1" `
        public string? fcstum1 { get; set; }

        [Column("FCSTUM2")]// string    `gorm:"column:FCSTUM2;" json:"fcstum2"  form:"fcstum2" `
        public string? fcstum2 { get; set; }

        [Column("FCSTUM3")]// string    `gorm:"column:FCSTUM3;" json:"fcstum3"  form:"fcstum3" `
        public string? fcstum3 { get; set; }

        [Column("FCSTUM4")]// string    `gorm:"column:FCSTUM4;" json:"fcstum4"  form:"fcstum4" `
        public string? fcstum4 { get; set; }

        [Column("FCSUBSTITU")]// string    `gorm:"column:FCSUBSTITU;" json:"fcsubstitu"  form:"fcsubstitu" `
        public string? fcsubstitu { get; set; }

        [Column("FCSUPP")]// string    `gorm:"column:FCSUPP;" json:"fcsupp"  form:"fcsupp" `
        public string? fcsupp { get; set; }

        [Column("FCSUPPBOI")]// string    `gorm:"column:FCSUPPBOI;" json:"fcsuppboi"  form:"fcsuppboi" `
        public string? fcsuppboi { get; set; }

        [Column("FCSWHOUSE")]// string    `gorm:"column:FCSWHOUSE;" json:"fcswhouse"  form:"fcswhouse" `
        public string? fcswhouse { get; set; }

        [Column("FCTAXTYPE")]// string    `gorm:"column:FCTAXTYPE;" json:"fctaxtype"  form:"fctaxtype" `
        public string? fctaxtype { get; set; }

        [Column("FCTYPE")]// string    `gorm:"column:FCTYPE;" json:"fctype"  form:"fctype" `
        public string? fctype { get; set; }

        [Column("FCU1ACC")]// string    `gorm:"column:FCU1ACC;" json:"fcu1acc"  form:"fcu1acc" `
        public string? fcu1acc { get; set; }

        [Column("FCU1STATUS")]// string    `gorm:"column:FCU1STATUS;" json:"fcu1status"  form:"fcu1status" `
        public string? fcu1status { get; set; }

        [Column("FCU2STATUS")]// string    `gorm:"column:FCU2STATUS;" json:"fcu2status"  form:"fcu2status" `
        public string? fcu2status { get; set; }

        [Column("FCU3STATUS")]// string    `gorm:"column:FCU3STATUS;" json:"fcu3status"  form:"fcu3status" `
        public string? fcu3status { get; set; }

        [Column("FCU4STATUS")]// string    `gorm:"column:FCU4STATUS;" json:"fcu4status"  form:"fcu4status" `
        public string? fcu4status { get; set; }

        [Column("FCU5STATUS")]// string    `gorm:"column:FCU5STATUS;" json:"fcu5status"  form:"fcu5status" `
        public string? fcu5status { get; set; }

        [Column("FCU6STATUS")]// string    `gorm:"column:FCU6STATUS;" json:"fcu6status"  form:"fcu6status" `
        public string? fcu6status { get; set; }

        [Column("FCU7STATUS")]// string    `gorm:"column:FCU7STATUS;" json:"fcu7status"  form:"fcu7status" `
        public string? fcu7status { get; set; }

        [Column("FCU8STATUS")]// string    `gorm:"column:FCU8STATUS;" json:"fcu8status"  form:"fcu8status" `
        public string? fcu8status { get; set; }

        [Column("FCU9STATUS")]// string    `gorm:"column:FCU9STATUS;" json:"fcu9status"  form:"fcu9status" `
        public string? fcu9status { get; set; }

        [Column("FCUDATE")]// string    `gorm:"column:FCUDATE;" json:"fcudate"  form:"fcudate" `
        public string? fcudate { get; set; }

        [Column("FCUM")]// string    `gorm:"column:FCUM;" json:"fcum"  form:"fcum" `
        public string? fcum { get; set; }

        [Column("FCUM1")]// string    `gorm:"column:FCUM1;" json:"fcum1"  form:"fcum1" `
        public string? fcum1 { get; set; }

        [Column("FCUM2")]// string    `gorm:"column:FCUM2;" json:"fcum2"  form:"fcum2" `
        public string? fcum2 { get; set; }

        [Column("FCUM3")]// string    `gorm:"column:FCUM3;" json:"fcum3"  form:"fcum3" `
        public string? fcum3 { get; set; }

        [Column("FCUM4")]// string    `gorm:"column:FCUM4;" json:"fcum4"  form:"fcum4" `
        public string? fcum4 { get; set; }

        [Column("FCUSEPDSER")]// string    `gorm:"column:FCUSEPDSER;" json:"fcusepdser"  form:"fcusepdser" `
        public string? fcusepdser { get; set; }

        [Column("FCUTIME")]// string    `gorm:"column:FCUTIME;" json:"fcutime"  form:"fcutime" `
        public string? fcutime { get; set; }

        [Column("FCVATISOUT")]// string    `gorm:"column:FCVATISOUT;" json:"fcvatisout"  form:"fcvatisout" `
        public string? fcvatisout { get; set; }

        [Column("FCVATTYPE")]// string    `gorm:"column:FCVATTYPE;" json:"fcvattype"  form:"fcvattype" `
        public string? fcvattype { get; set; }

        [Column("FCWHATPRIC")]// string    `gorm:"column:FCWHATPRIC;" json:"fcwhatpric"  form:"fcwhatpric" `
        public string? fcwhatpric { get; set; }

        [Column("FDADD")]// string    `gorm:"column:FDADD;" json:"fdadd"  form:"fdadd" `
        public DateTime? fdadd { get; set; }

        [Column("FDINACTIVE")]// string    `gorm:"column:FDINACTIVE;" json:"fdinactive"  form:"fdinactive" `
        public DateTime? fdinactive { get; set; }

        [Column("FDLASTBUYD")]// string    `gorm:"column:FDLASTBUYD;" json:"fdlastbuyd"  form:"fdlastbuyd" `
        public DateTime? fdlastbuyd { get; set; }

        [Column("FDLASTSELL")]// string    `gorm:"column:FDLASTSELL;" json:"fdlastsell"  form:"fdlastsell" `
        public DateTime? fdlastsell { get; set; }

        [Column("FIMILLISEC")]// int64     `gorm:"column:FIMILLISEC;" json:"fimillisec"  form:"fimillisec" `
        public int? fimillisec { get; set; }

        [Column("FMERRMSG")]// string    `gorm:"column:FMERRMSG;" json:"fmerrmsg"  form:"fmerrmsg" `
        public string? fmerrmsg { get; set; }

        [Column("FMEXTRATAG")]// string    `gorm:"column:FMEXTRATAG;" json:"fmextratag"  form:"fmextratag" `
        public string? fmextratag { get; set; }

        [Column("FMINACTIVE")]// string    `gorm:"column:FMINACTIVE;" json:"fminactive"  form:"fminactive" `
        public string? fminactive { get; set; }

        [Column("FMPICNAME")]// string    `gorm:"column:FMPICNAME;" json:"fmpicname"  form:"fmpicname" `
        public string? fmpicname { get; set; }

        [Column("FNAGELONG")]// float64   `gorm:"column:FNAGELONG;" json:"fnagelong"  form:"fnagelong" `
        public decimal? fnagelong { get; set; }

        [Column("FNAVGCOST")]// float64   `gorm:"column:FNAVGCOST;" json:"fnavgcost"  form:"fnavgcost" `
        public decimal? fnavgcost { get; set; }

        [Column("FNBATCHSIZ")]// float64   `gorm:"column:FNBATCHSIZ;" json:"fnbatchsiz"  form:"fnbatchsiz" `
        public decimal? fnbatchsiz { get; set; }

        [Column("FNCOMMISSI")]// float64   `gorm:"column:FNCOMMISSI;" json:"fncommissi"  form:"fncommissi" `
        public decimal? fncommissi { get; set; }

        [Column("FNDLCOST")]// float64   `gorm:"column:FNDLCOST;" json:"fndlcost"  form:"fndlcost" `
        public decimal? fndlcost { get; set; }

        [Column("FNDMCOST")]// float64   `gorm:"column:FNDMCOST;" json:"fndmcost"  form:"fndmcost" `
        public decimal? fndmcost { get; set; }

        [Column("FNDUTYPCN")]// float64   `gorm:"column:FNDUTYPCN;" json:"fndutypcn"  form:"fndutypcn" `
        public decimal? fndutypcn { get; set; }

        [Column("FNEOQTY")]// float64   `gorm:"column:FNEOQTY;" json:"fneoqty"  form:"fneoqty" `
        public decimal? fneoqty { get; set; }

        [Column("FNEXPFAC")]// float64   `gorm:"column:FNEXPFAC;" json:"fnexpfac"  form:"fnexpfac" `
        public decimal? fnexpfac { get; set; }

        [Column("FNFIXCOST")]// float64   `gorm:"column:FNFIXCOST;" json:"fnfixcost"  form:"fnfixcost" `
        public decimal? fnfixcost { get; set; }

        [Column("FNGROSSWG")]// float64   `gorm:"column:FNGROSSWG;" json:"fngrosswg"  form:"fngrosswg" `
        public decimal? fngrosswg { get; set; }

        [Column("FNHEIGHT")]// float64   `gorm:"column:FNHEIGHT;" json:"fnheight"  form:"fnheight" `
        public decimal? fnheight { get; set; }

        [Column("FNISCONSUM")]// float64   `gorm:"column:FNISCONSUM;" json:"fnisconsum"  form:"fnisconsum" `
        public decimal? fnisconsum { get; set; }

        [Column("FNIUMQTY")]// float64   `gorm:"column:FNIUMQTY;" json:"fniumqty"  form:"fniumqty" `
        public decimal? fniumqty { get; set; }

        [Column("FNLASTBUYP")]// float64   `gorm:"column:FNLASTBUYP;" json:"fnlastbuyp"  form:"fnlastbuyp" `
        public decimal? fnlastbuyp { get; set; }

        [Column("FNLENGTH")]// float64   `gorm:"column:FNLENGTH;" json:"fnlength"  form:"fnlength" `
        public decimal? fnlength { get; set; }

        [Column("FNLTDMFG")]// float64   `gorm:"column:FNLTDMFG;" json:"fnltdmfg"  form:"fnltdmfg" `
        public decimal? fnltdmfg { get; set; }

        [Column("FNLTDPO")]// float64   `gorm:"column:FNLTDPO;" json:"fnltdpo"  form:"fnltdpo" `
        public decimal? fnltdpo { get; set; }

        [Column("FNLTDPPARE")]// float64   `gorm:"column:FNLTDPPARE;" json:"fnltdppare"  form:"fnltdppare" `
        public decimal? fnltdppare { get; set; }

        [Column("FNLTDQC")]// float64   `gorm:"column:FNLTDQC;" json:"fnltdqc"  form:"fnltdqc" `
        public decimal? fnltdqc { get; set; }

        [Column("FNLTDSUBC")]// float64   `gorm:"column:FNLTDSUBC;" json:"fnltdsubc"  form:"fnltdsubc" `
        public decimal? fnltdsubc { get; set; }

        [Column("FNMAXPRICE")]// float64   `gorm:"column:FNMAXPRICE;" json:"fnmaxprice"  form:"fnmaxprice" `
        public decimal? fnmaxprice { get; set; }

        [Column("FNMFUMQTY")]// float64   `gorm:"column:FNMFUMQTY;" json:"fnmfumqty"  form:"fnmfumqty" `
        public decimal? fnmfumqty { get; set; }

        [Column("FNMINPRICE")]// float64   `gorm:"column:FNMINPRICE;" json:"fnminprice"  form:"fnminprice" `
        public decimal? fnminprice { get; set; }

        [Column("FNOHCOST")]// float64   `gorm:"column:FNOHCOST;" json:"fnohcost"  form:"fnohcost" `
        public decimal? fnohcost { get; set; }

        [Column("FNPRICE")]// float64   `gorm:"column:FNPRICE;" json:"fnprice"  form:"fnprice" `
        public decimal? fnprice { get; set; }

        [Column("FNREORDERP")]// float64   `gorm:"column:FNREORDERP;" json:"fnreorderp"  form:"fnreorderp" `
        public decimal? fnreorderp { get; set; }

        [Column("FNSAFETYQT")]// float64   `gorm:"column:FNSAFETYQT;" json:"fnsafetyqt"  form:"fnsafetyqt" `
        public decimal? fnsafetyqt { get; set; }

        [Column("FNSALEPRIC")]// float64   `gorm:"column:FNSALEPRIC;" json:"fnsalepric"  form:"fnsalepric" `
        public decimal? fnsalepric { get; set; }

        [Column("FNSCOSTKE1")]// float64   `gorm:"column:FNSCOSTKE1;" json:"fnscostke1"  form:"fnscostke1" `
        public decimal? fnscostke1 { get; set; }

        [Column("FNSCOSTKE2")]// float64   `gorm:"column:FNSCOSTKE2;" json:"fnscostke2"  form:"fnscostke2" `
        public decimal? fnscostke2 { get; set; }

        [Column("FNSTDCOST")]// float64   `gorm:"column:FNSTDCOST;" json:"fnstdcost"  form:"fnstdcost" `
        public decimal? fnstdcost { get; set; }

        [Column("FNSTIUMQTY")]// float64   `gorm:"column:FNSTIUMQTY;" json:"fnstiumqty"  form:"fnstiumqty" `
        public decimal? fnstiumqty { get; set; }

        [Column("FNSTUMQTY1")]// float64   `gorm:"column:FNSTUMQTY1;" json:"fnstumqty1"  form:"fnstumqty1" `
        public decimal? fnstumqty1 { get; set; }

        [Column("FNSTUMQTY2")]// float64   `gorm:"column:FNSTUMQTY2;" json:"fnstumqty2"  form:"fnstumqty2" `
        public decimal? fnstumqty2 { get; set; }

        [Column("FNSTUMQTY3")]// float64   `gorm:"column:FNSTUMQTY3;" json:"fnstumqty3"  form:"fnstumqty3" `
        public decimal? fnstumqty3 { get; set; }

        [Column("FNSTUMQTY4")]// float64   `gorm:"column:FNSTUMQTY4;" json:"fnstumqty4"  form:"fnstumqty4" `
        public decimal? fnstumqty4 { get; set; }

        [Column("FNTRANSEXP")]// float64   `gorm:"column:FNTRANSEXP;" json:"fntransexp"  form:"fntransexp" `
        public decimal? fntransexp { get; set; }

        [Column("FNU1CNT")]// float64   `gorm:"column:FNU1CNT;" json:"fnu1cnt"  form:"fnu1cnt" `
        public decimal? fnu1cnt { get; set; }

        [Column("FNU2CNT")]// float64   `gorm:"column:FNU2CNT;" json:"fnu2cnt"  form:"fnu2cnt" `
        public decimal? fnu2cnt { get; set; }

        [Column("FNU3CNT")]// float64   `gorm:"column:FNU3CNT;" json:"fnu3cnt"  form:"fnu3cnt" `
        public decimal? fnu3cnt { get; set; }

        [Column("FNU4CNT")]// float64   `gorm:"column:FNU4CNT;" json:"fnu4cnt"  form:"fnu4cnt" `
        public decimal? fnu4cnt { get; set; }

        [Column("FNU5CNT")]// float64   `gorm:"column:FNU5CNT;" json:"fnu5cnt"  form:"fnu5cnt" `
        public decimal? fnu5cnt { get; set; }

        [Column("FNU6CNT")]// float64   `gorm:"column:FNU6CNT;" json:"fnu6cnt"  form:"fnu6cnt" `
        public decimal? fnu6cnt { get; set; }

        [Column("FNU7CNT")]// float64   `gorm:"column:FNU7CNT;" json:"fnu7cnt"  form:"fnu7cnt" `
        public decimal? fnu7cnt { get; set; }

        [Column("FNU8CNT")]// float64   `gorm:"column:FNU8CNT;" json:"fnu8cnt"  form:"fnu8cnt" `
        public decimal? fnu8cnt { get; set; }

        [Column("FNU9CNT")]// float64   `gorm:"column:FNU9CNT;" json:"fnu9cnt"  form:"fnu9cnt" `
        public decimal? fnu9cnt { get; set; }

        [Column("FNUMQTY1")]// float64   `gorm:"column:FNUMQTY1;" json:"fnumqty1"  form:"fnumqty1" `
        public decimal? fnumqty1 { get; set; }

        [Column("FNUMQTY2")]// float64   `gorm:"column:FNUMQTY2;" json:"fnumqty2"  form:"fnumqty2" `
        public decimal? fnumqty2 { get; set; }

        [Column("FNUMQTY3")]// float64   `gorm:"column:FNUMQTY3;" json:"fnumqty3"  form:"fnumqty3" `
        public decimal? fnumqty3 { get; set; }

        [Column("FNUMQTY4")]// float64   `gorm:"column:FNUMQTY4;" json:"fnumqty4"  form:"fnumqty4" `
        public decimal? fnumqty4 { get; set; }

        [Column("FNUMRATIO")]// float64   `gorm:"column:FNUMRATIO;" json:"fnumratio"  form:"fnumratio" `
        public decimal? fnumratio { get; set; }

        [Column("FNUMRATIOA")]// float64   `gorm:"column:FNUMRATIOA;" json:"fnumratioa"  form:"fnumratioa" `
        public decimal? fnumratioa { get; set; }

        [Column("FNUMRATIOB")]// float64   `gorm:"column:FNUMRATIOB;" json:"fnumratiob"  form:"fnumratiob" `
        public decimal? fnumratiob { get; set; }

        [Column("FNVARCOST")]// float64   `gorm:"column:FNVARCOST;" json:"fnvarcost"  form:"fnvarcost" `
        public decimal? fnvarcost { get; set; }

        [Column("FNVATRATE")]// float64   `gorm:"column:FNVATRATE;" json:"fnvatrate"  form:"fnvatrate" `
        public decimal? fnvatrate { get; set; }

        [Column("FNVOLUME")]// float64   `gorm:"column:FNVOLUME;" json:"fnvolume"  form:"fnvolume" `
        public decimal? fnvolume { get; set; }

        [Column("FNWIDTH")]// float64   `gorm:"column:FNWIDTH;" json:"fnwidth"  form:"fnwidth" `
        public decimal? fnwidth { get; set; }

        [Column("FNWTAXRATE")]// float64   `gorm:"column:FNWTAXRATE;" json:"fnwtaxrate"  form:"fnwtaxrate" `
        public decimal? fnwtaxrate { get; set; }

        [Column("FTDATETIME")]// time.Time `gorm:"column:FTDATETIME;" json:"ftdatetime"  form:"ftdatetime" `
        public DateTime? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]// time.Time `gorm:"column:FTLASTEDIT;" json:"ftlastedit"  form:"ftlastedit" `
        public DateTime? ftlastedit { get; set; }

        [Column("FTLASTUPD")]// time.Time `gorm:"column:FTLASTUPD;" json:"ftlastupd"  form:"ftlastupd" `
        public DateTime? ftlastupd { get; set; }

        [Column("FTSRCUPD")]// time.Time `gorm:"column:FTSRCUPD;" json:"ftsrcupd"  form:"ftsrcupd" `
        public DateTime? ftsrcupd { get; set; }

        //UM         *Unit     `gorm:"foreignKey:FCUM;references:FCSKID;" json:"unit"`
        [ForeignKey(nameof(fcum))]
        public Unit unit { get; set; }
    }
}
