namespace mRingo.Web.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalenderMaster")]
    public partial class CalenderMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long datekey { get; set; }

        public DateTime? daydate { get; set; }

        [StringLength(10)]
        public string fulldateworld { get; set; }

        [StringLength(10)]
        public string fulldateusa { get; set; }

        [StringLength(2)]
        public string dayofmonth { get; set; }

        [StringLength(4)]
        public string daysuffix { get; set; }

        [StringLength(9)]
        public string dayname { get; set; }

        [StringLength(1)]
        public string dayofweekusa { get; set; }

        [StringLength(1)]
        public string dayofweekworld { get; set; }

        [StringLength(2)]
        public string dayofweekinmonth { get; set; }

        [StringLength(2)]
        public string dayofweekinyear { get; set; }

        [StringLength(3)]
        public string dayofquarter { get; set; }

        [StringLength(3)]
        public string dayofyear { get; set; }

        [StringLength(1)]
        public string weekofmonth { get; set; }

        [StringLength(2)]
        public string weekofquarter { get; set; }

        [StringLength(2)]
        public string weekofyear { get; set; }

        [StringLength(2)]
        public string month { get; set; }

        [StringLength(9)]
        public string monthname { get; set; }

        [StringLength(2)]
        public string monthofquarter { get; set; }

        [StringLength(1)]
        public string quarter { get; set; }

        [StringLength(9)]
        public string quartername { get; set; }

        [StringLength(4)]
        public string year { get; set; }

        [StringLength(7)]
        public string yearname { get; set; }

        [StringLength(10)]
        public string monthyear { get; set; }

        [StringLength(6)]
        public string mmyyyy { get; set; }

        public DateTime? firstdayofmonth { get; set; }

        public DateTime? lastdayofmonth { get; set; }

        public DateTime? firstdayofquarter { get; set; }

        public DateTime? lastdayofquarter { get; set; }

        public DateTime? firstdayofyear { get; set; }

        public DateTime? lastdayofyear { get; set; }

        public int? isholidayusa { get; set; }

        public int? isweekday { get; set; }

        [StringLength(50)]
        public string holidayusa { get; set; }

        public int? isholidayworld { get; set; }

        [StringLength(50)]
        public string holidayworld { get; set; }

        [StringLength(3)]
        public string fiscaldayofyear { get; set; }

        [StringLength(3)]
        public string fiscalweekofyear { get; set; }

        [StringLength(2)]
        public string fiscalmonth { get; set; }

        [StringLength(1)]
        public string fiscalquarter { get; set; }

        [StringLength(9)]
        public string fiscalquartername { get; set; }

        [StringLength(4)]
        public string fiscalyear { get; set; }

        [StringLength(7)]
        public string fiscalyearname { get; set; }

        [StringLength(10)]
        public string fiscalmonthyear { get; set; }

        [StringLength(6)]
        public string fiscalmmyyyy { get; set; }

        public DateTime? fiscalfirstdayofmonth { get; set; }

        public DateTime? fiscallastdayofmonth { get; set; }

        public DateTime? fiscalfirstdayofquarter { get; set; }

        public DateTime? fiscallastdayofquarter { get; set; }

        public DateTime? fiscalfirstdayofyear { get; set; }

        public DateTime? fiscallastdayofyear { get; set; }
    }
}
