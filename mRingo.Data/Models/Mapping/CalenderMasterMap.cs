using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace mRingo.Data.Models.Mapping
{
    public class CalenderMasterMap : EntityTypeConfiguration<CalenderMaster>
    {
        public CalenderMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.datekey);

            // Properties
            this.Property(t => t.datekey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.fulldateworld)
                .HasMaxLength(10);

            this.Property(t => t.fulldateusa)
                .HasMaxLength(10);

            this.Property(t => t.dayofmonth)
                .HasMaxLength(2);

            this.Property(t => t.daysuffix)
                .HasMaxLength(4);

            this.Property(t => t.dayname)
                .HasMaxLength(9);

            this.Property(t => t.dayofweekusa)
                .HasMaxLength(1);

            this.Property(t => t.dayofweekworld)
                .HasMaxLength(1);

            this.Property(t => t.dayofweekinmonth)
                .HasMaxLength(2);

            this.Property(t => t.dayofweekinyear)
                .HasMaxLength(2);

            this.Property(t => t.dayofquarter)
                .HasMaxLength(3);

            this.Property(t => t.dayofyear)
                .HasMaxLength(3);

            this.Property(t => t.weekofmonth)
                .HasMaxLength(1);

            this.Property(t => t.weekofquarter)
                .HasMaxLength(2);

            this.Property(t => t.weekofyear)
                .HasMaxLength(2);

            this.Property(t => t.month)
                .HasMaxLength(2);

            this.Property(t => t.monthname)
                .HasMaxLength(9);

            this.Property(t => t.monthofquarter)
                .HasMaxLength(2);

            this.Property(t => t.quarter)
                .HasMaxLength(1);

            this.Property(t => t.quartername)
                .HasMaxLength(9);

            this.Property(t => t.year)
                .HasMaxLength(4);

            this.Property(t => t.yearname)
                .HasMaxLength(7);

            this.Property(t => t.monthyear)
                .HasMaxLength(10);

            this.Property(t => t.mmyyyy)
                .HasMaxLength(6);

            this.Property(t => t.holidayusa)
                .HasMaxLength(50);

            this.Property(t => t.holidayworld)
                .HasMaxLength(50);

            this.Property(t => t.fiscaldayofyear)
                .HasMaxLength(3);

            this.Property(t => t.fiscalweekofyear)
                .HasMaxLength(3);

            this.Property(t => t.fiscalmonth)
                .HasMaxLength(2);

            this.Property(t => t.fiscalquarter)
                .HasMaxLength(1);

            this.Property(t => t.fiscalquartername)
                .HasMaxLength(9);

            this.Property(t => t.fiscalyear)
                .HasMaxLength(4);

            this.Property(t => t.fiscalyearname)
                .HasMaxLength(7);

            this.Property(t => t.fiscalmonthyear)
                .HasMaxLength(10);

            this.Property(t => t.fiscalmmyyyy)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("CalenderMaster");
            this.Property(t => t.datekey).HasColumnName("datekey");
            this.Property(t => t.daydate).HasColumnName("daydate");
            this.Property(t => t.fulldateworld).HasColumnName("fulldateworld");
            this.Property(t => t.fulldateusa).HasColumnName("fulldateusa");
            this.Property(t => t.dayofmonth).HasColumnName("dayofmonth");
            this.Property(t => t.daysuffix).HasColumnName("daysuffix");
            this.Property(t => t.dayname).HasColumnName("dayname");
            this.Property(t => t.dayofweekusa).HasColumnName("dayofweekusa");
            this.Property(t => t.dayofweekworld).HasColumnName("dayofweekworld");
            this.Property(t => t.dayofweekinmonth).HasColumnName("dayofweekinmonth");
            this.Property(t => t.dayofweekinyear).HasColumnName("dayofweekinyear");
            this.Property(t => t.dayofquarter).HasColumnName("dayofquarter");
            this.Property(t => t.dayofyear).HasColumnName("dayofyear");
            this.Property(t => t.weekofmonth).HasColumnName("weekofmonth");
            this.Property(t => t.weekofquarter).HasColumnName("weekofquarter");
            this.Property(t => t.weekofyear).HasColumnName("weekofyear");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.monthname).HasColumnName("monthname");
            this.Property(t => t.monthofquarter).HasColumnName("monthofquarter");
            this.Property(t => t.quarter).HasColumnName("quarter");
            this.Property(t => t.quartername).HasColumnName("quartername");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.yearname).HasColumnName("yearname");
            this.Property(t => t.monthyear).HasColumnName("monthyear");
            this.Property(t => t.mmyyyy).HasColumnName("mmyyyy");
            this.Property(t => t.firstdayofmonth).HasColumnName("firstdayofmonth");
            this.Property(t => t.lastdayofmonth).HasColumnName("lastdayofmonth");
            this.Property(t => t.firstdayofquarter).HasColumnName("firstdayofquarter");
            this.Property(t => t.lastdayofquarter).HasColumnName("lastdayofquarter");
            this.Property(t => t.firstdayofyear).HasColumnName("firstdayofyear");
            this.Property(t => t.lastdayofyear).HasColumnName("lastdayofyear");
            this.Property(t => t.isholidayusa).HasColumnName("isholidayusa");
            this.Property(t => t.isweekday).HasColumnName("isweekday");
            this.Property(t => t.holidayusa).HasColumnName("holidayusa");
            this.Property(t => t.isholidayworld).HasColumnName("isholidayworld");
            this.Property(t => t.holidayworld).HasColumnName("holidayworld");
            this.Property(t => t.fiscaldayofyear).HasColumnName("fiscaldayofyear");
            this.Property(t => t.fiscalweekofyear).HasColumnName("fiscalweekofyear");
            this.Property(t => t.fiscalmonth).HasColumnName("fiscalmonth");
            this.Property(t => t.fiscalquarter).HasColumnName("fiscalquarter");
            this.Property(t => t.fiscalquartername).HasColumnName("fiscalquartername");
            this.Property(t => t.fiscalyear).HasColumnName("fiscalyear");
            this.Property(t => t.fiscalyearname).HasColumnName("fiscalyearname");
            this.Property(t => t.fiscalmonthyear).HasColumnName("fiscalmonthyear");
            this.Property(t => t.fiscalmmyyyy).HasColumnName("fiscalmmyyyy");
            this.Property(t => t.fiscalfirstdayofmonth).HasColumnName("fiscalfirstdayofmonth");
            this.Property(t => t.fiscallastdayofmonth).HasColumnName("fiscallastdayofmonth");
            this.Property(t => t.fiscalfirstdayofquarter).HasColumnName("fiscalfirstdayofquarter");
            this.Property(t => t.fiscallastdayofquarter).HasColumnName("fiscallastdayofquarter");
            this.Property(t => t.fiscalfirstdayofyear).HasColumnName("fiscalfirstdayofyear");
            this.Property(t => t.fiscallastdayofyear).HasColumnName("fiscallastdayofyear");
        }
    }
}
