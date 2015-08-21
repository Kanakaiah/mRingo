namespace mRingo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtistGenre",
                c => new
                    {
                        artist_genre_id = c.Long(nullable: false),
                        artist_info_id = c.Long(nullable: false),
                        genre_id = c.Long(nullable: false),
                        artist_cost_per_hr = c.Decimal(precision: 18, scale: 2),
                        default_genre_nm = c.String(maxLength: 64),
                        genre_rating_txt = c.String(maxLength: 10),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.DateTime(),
                    })
                .PrimaryKey(t => t.artist_genre_id)
                .ForeignKey("dbo.ArtistMaster", t => t.artist_info_id, cascadeDelete: true)
                .ForeignKey("dbo.GenreMaster", t => t.genre_id, cascadeDelete: true)
                .Index(t => t.artist_info_id)
                .Index(t => t.genre_id);
            
            CreateTable(
                "dbo.ArtistMaster",
                c => new
                    {
                        artist_info_id = c.Long(nullable: false, identity: true),
                        frst_nm = c.String(maxLength: 64),
                        mid_nm = c.String(maxLength: 40),
                        last_nm = c.String(nullable: false, maxLength: 64),
                        nick_nm = c.String(maxLength: 40),
                        addr_ln_1_txt = c.String(nullable: false, maxLength: 100),
                        addr_ln_2_txt = c.String(maxLength: 100),
                        addr_city_nm = c.String(nullable: false, maxLength: 35),
                        addr_state = c.String(nullable: false, maxLength: 35),
                        addr_zip_cde = c.String(nullable: false, maxLength: 20),
                        addr_ctry_nm = c.String(nullable: false, maxLength: 40),
                        day_ph_nbr = c.String(maxLength: 40),
                        evng_ph_nbr = c.String(maxLength: 40),
                        cellph_nbr = c.String(maxLength: 40),
                        pager_nbr = c.String(maxLength: 40),
                        othr_ph_nbr = c.String(maxLength: 40),
                        day_fax_nbr = c.String(maxLength: 40),
                        evng_fax_nbr = c.String(maxLength: 40),
                        login_id_txt = c.String(maxLength: 20),
                        email_addr_txt = c.String(maxLength: 150),
                        alt_email_addr_txt = c.String(maxLength: 150),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.artist_info_id);
            
            CreateTable(
                "dbo.ArtistInstrument",
                c => new
                    {
                        artist_instrument_id = c.Long(nullable: false, identity: true),
                        artist_info_id = c.Long(nullable: false),
                        instrument_id = c.Long(),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.DateTime(),
                    })
                .PrimaryKey(t => t.artist_instrument_id)
                .ForeignKey("dbo.ArtistMaster", t => t.artist_info_id, cascadeDelete: true)
                .ForeignKey("dbo.InstrumentMaster", t => t.instrument_id)
                .Index(t => t.artist_info_id)
                .Index(t => t.instrument_id);
            
            CreateTable(
                "dbo.InstrumentMaster",
                c => new
                    {
                        instrument_id = c.Long(nullable: false, identity: true),
                        instrument_nm = c.String(nullable: false, maxLength: 64),
                        instrument_typ = c.String(nullable: false, maxLength: 40),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.DateTime(),
                    })
                .PrimaryKey(t => t.instrument_id);
            
            CreateTable(
                "dbo.CustomerArtistInfo",
                c => new
                    {
                        cust_artist_id = c.Long(nullable: false, identity: true),
                        cust_info_id = c.Long(nullable: false),
                        artist_info_id = c.Long(nullable: false),
                        review_txt = c.String(maxLength: 1000),
                        suggest_txt = c.String(maxLength: 1000),
                        rating_txt = c.String(maxLength: 10),
                        notes = c.String(maxLength: 1000),
                        booked_when_ts = c.DateTime(),
                        genre_id = c.Long(),
                        artist_cost_per_hr = c.Decimal(precision: 18, scale: 2),
                        discount = c.Decimal(precision: 18, scale: 2),
                        booked_hr = c.Decimal(precision: 18, scale: 2),
                        actual_hr = c.Decimal(precision: 18, scale: 2),
                        total_cost = c.Decimal(precision: 18, scale: 2),
                        actual_cost = c.Decimal(precision: 18, scale: 2),
                        confirmed_flg = c.String(maxLength: 1),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.DateTime(),
                    })
                .PrimaryKey(t => t.cust_artist_id)
                .ForeignKey("dbo.ArtistMaster", t => t.artist_info_id, cascadeDelete: true)
                .Index(t => t.artist_info_id);
            
            CreateTable(
                "dbo.GenreMaster",
                c => new
                    {
                        genre_id = c.Long(nullable: false, identity: true),
                        genre_nm = c.String(nullable: false, maxLength: 64),
                        cat_nm = c.String(maxLength: 40),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.genre_id);
            
            CreateTable(
                "dbo.CalenderMaster",
                c => new
                    {
                        datekey = c.Long(nullable: false, identity: true),
                        daydate = c.DateTime(),
                        fulldateworld = c.String(maxLength: 10),
                        fulldateusa = c.String(maxLength: 10),
                        dayofmonth = c.String(maxLength: 2),
                        daysuffix = c.String(maxLength: 4),
                        dayname = c.String(maxLength: 9),
                        dayofweekusa = c.String(maxLength: 1),
                        dayofweekworld = c.String(maxLength: 1),
                        dayofweekinmonth = c.String(maxLength: 2),
                        dayofweekinyear = c.String(maxLength: 2),
                        dayofquarter = c.String(maxLength: 3),
                        dayofyear = c.String(maxLength: 3),
                        weekofmonth = c.String(maxLength: 1),
                        weekofquarter = c.String(maxLength: 2),
                        weekofyear = c.String(maxLength: 2),
                        month = c.String(maxLength: 2),
                        monthname = c.String(maxLength: 9),
                        monthofquarter = c.String(maxLength: 2),
                        quarter = c.String(maxLength: 1),
                        quartername = c.String(maxLength: 9),
                        year = c.String(maxLength: 4),
                        yearname = c.String(maxLength: 7),
                        monthyear = c.String(maxLength: 10),
                        mmyyyy = c.String(maxLength: 6),
                        firstdayofmonth = c.DateTime(),
                        lastdayofmonth = c.DateTime(),
                        firstdayofquarter = c.DateTime(),
                        lastdayofquarter = c.DateTime(),
                        firstdayofyear = c.DateTime(),
                        lastdayofyear = c.DateTime(),
                        isholidayusa = c.Int(),
                        isweekday = c.Int(),
                        holidayusa = c.String(maxLength: 50),
                        isholidayworld = c.Int(),
                        holidayworld = c.String(maxLength: 50),
                        fiscaldayofyear = c.String(maxLength: 3),
                        fiscalweekofyear = c.String(maxLength: 3),
                        fiscalmonth = c.String(maxLength: 2),
                        fiscalquarter = c.String(maxLength: 1),
                        fiscalquartername = c.String(maxLength: 9),
                        fiscalyear = c.String(maxLength: 4),
                        fiscalyearname = c.String(maxLength: 7),
                        fiscalmonthyear = c.String(maxLength: 10),
                        fiscalmmyyyy = c.String(maxLength: 6),
                        fiscalfirstdayofmonth = c.DateTime(),
                        fiscallastdayofmonth = c.DateTime(),
                        fiscalfirstdayofquarter = c.DateTime(),
                        fiscallastdayofquarter = c.DateTime(),
                        fiscalfirstdayofyear = c.DateTime(),
                        fiscallastdayofyear = c.DateTime(),
                    })
                .PrimaryKey(t => t.datekey);
            
            CreateTable(
                "dbo.CustomerInquiry",
                c => new
                    {
                        inquiry_id = c.Long(nullable: false, identity: true),
                        cust_name = c.String(nullable: false, maxLength: 64),
                        email_addr_txt = c.String(nullable: false, maxLength: 150),
                        ph_nbr = c.String(nullable: false, maxLength: 40),
                        notes = c.String(maxLength: 100),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.DateTime(),
                    })
                .PrimaryKey(t => t.inquiry_id);
            
            CreateTable(
                "dbo.CustomerMaster",
                c => new
                    {
                        cust_info_id = c.Long(nullable: false, identity: true),
                        frst_nm = c.String(nullable: false, maxLength: 64),
                        mid_nm = c.String(maxLength: 40),
                        last_nm = c.String(nullable: false, maxLength: 64),
                        addr_ln_1_txt = c.String(nullable: false, maxLength: 100),
                        addr_ln_2_txt = c.String(maxLength: 100),
                        addr_city_nm = c.String(nullable: false, maxLength: 35),
                        addr_state = c.String(nullable: false, maxLength: 35),
                        addr_zip_cde = c.String(nullable: false, maxLength: 20),
                        addr_ctry_nm = c.String(nullable: false, maxLength: 40),
                        day_ph_nbr = c.String(maxLength: 40),
                        evng_ph_nbr = c.String(maxLength: 40),
                        cellph_nbr = c.String(maxLength: 40),
                        pager_nbr = c.String(maxLength: 40),
                        othr_ph_nbr = c.String(maxLength: 40),
                        day_fax_nbr = c.String(maxLength: 40),
                        evng_fax_nbr = c.String(maxLength: 40),
                        login_id_txt = c.String(maxLength: 20),
                        email_addr_txt = c.String(maxLength: 150),
                        alt_email_addr_txt = c.String(maxLength: 150),
                        rec_crt_ts = c.DateTime(nullable: false),
                        rec_crt_by = c.String(nullable: false, maxLength: 20),
                        rec_upd_by = c.String(maxLength: 20),
                        rec_upd_ts = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.cust_info_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtistGenre", "genre_id", "dbo.GenreMaster");
            DropForeignKey("dbo.ArtistGenre", "artist_info_id", "dbo.ArtistMaster");
            DropForeignKey("dbo.CustomerArtistInfo", "artist_info_id", "dbo.ArtistMaster");
            DropForeignKey("dbo.ArtistInstrument", "instrument_id", "dbo.InstrumentMaster");
            DropForeignKey("dbo.ArtistInstrument", "artist_info_id", "dbo.ArtistMaster");
            DropIndex("dbo.CustomerArtistInfo", new[] { "artist_info_id" });
            DropIndex("dbo.ArtistInstrument", new[] { "instrument_id" });
            DropIndex("dbo.ArtistInstrument", new[] { "artist_info_id" });
            DropIndex("dbo.ArtistGenre", new[] { "genre_id" });
            DropIndex("dbo.ArtistGenre", new[] { "artist_info_id" });
            DropTable("dbo.CustomerMaster");
            DropTable("dbo.CustomerInquiry");
            DropTable("dbo.CalenderMaster");
            DropTable("dbo.GenreMaster");
            DropTable("dbo.CustomerArtistInfo");
            DropTable("dbo.InstrumentMaster");
            DropTable("dbo.ArtistInstrument");
            DropTable("dbo.ArtistMaster");
            DropTable("dbo.ArtistGenre");
        }
    }
}
