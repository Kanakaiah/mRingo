using System;
using System.Collections.Generic;

namespace mRingo.Data.Models
{
    public partial class CalenderMaster
    {
        public long datekey { get; set; }
        public Nullable<System.DateTime> daydate { get; set; }
        public string fulldateworld { get; set; }
        public string fulldateusa { get; set; }
        public string dayofmonth { get; set; }
        public string daysuffix { get; set; }
        public string dayname { get; set; }
        public string dayofweekusa { get; set; }
        public string dayofweekworld { get; set; }
        public string dayofweekinmonth { get; set; }
        public string dayofweekinyear { get; set; }
        public string dayofquarter { get; set; }
        public string dayofyear { get; set; }
        public string weekofmonth { get; set; }
        public string weekofquarter { get; set; }
        public string weekofyear { get; set; }
        public string month { get; set; }
        public string monthname { get; set; }
        public string monthofquarter { get; set; }
        public string quarter { get; set; }
        public string quartername { get; set; }
        public string year { get; set; }
        public string yearname { get; set; }
        public string monthyear { get; set; }
        public string mmyyyy { get; set; }
        public Nullable<System.DateTime> firstdayofmonth { get; set; }
        public Nullable<System.DateTime> lastdayofmonth { get; set; }
        public Nullable<System.DateTime> firstdayofquarter { get; set; }
        public Nullable<System.DateTime> lastdayofquarter { get; set; }
        public Nullable<System.DateTime> firstdayofyear { get; set; }
        public Nullable<System.DateTime> lastdayofyear { get; set; }
        public Nullable<int> isholidayusa { get; set; }
        public Nullable<int> isweekday { get; set; }
        public string holidayusa { get; set; }
        public Nullable<int> isholidayworld { get; set; }
        public string holidayworld { get; set; }
        public string fiscaldayofyear { get; set; }
        public string fiscalweekofyear { get; set; }
        public string fiscalmonth { get; set; }
        public string fiscalquarter { get; set; }
        public string fiscalquartername { get; set; }
        public string fiscalyear { get; set; }
        public string fiscalyearname { get; set; }
        public string fiscalmonthyear { get; set; }
        public string fiscalmmyyyy { get; set; }
        public Nullable<System.DateTime> fiscalfirstdayofmonth { get; set; }
        public Nullable<System.DateTime> fiscallastdayofmonth { get; set; }
        public Nullable<System.DateTime> fiscalfirstdayofquarter { get; set; }
        public Nullable<System.DateTime> fiscallastdayofquarter { get; set; }
        public Nullable<System.DateTime> fiscalfirstdayofyear { get; set; }
        public Nullable<System.DateTime> fiscallastdayofyear { get; set; }
    }
}
