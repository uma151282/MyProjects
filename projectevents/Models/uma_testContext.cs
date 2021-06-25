using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace projectevents.Models
{
    public partial class uma_testContext : DbContext
    {

        private readonly IConfiguration _configuration;
        private IDbConnection DbConnection { get; }
        public uma_testContext(DbContextOptions<uma_testContext> options, IConfiguration configuration)
        : base(options)
        {
            this._configuration = configuration;
            DbConnection = new SqlConnection(this._configuration.GetConnectionString("DatabaseConnection"));
        }
        //public uma_testContext(DbContextOptions<uma_testContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<BookingDetails> BookingDetails { get; set; }
        public virtual DbSet<BookingEquipment> BookingEquipment { get; set; }
        public virtual DbSet<BookingFlower> BookingFlower { get; set; }
        public virtual DbSet<BookingFood> BookingFood { get; set; }
        public virtual DbSet<BookingLight> BookingLight { get; set; }
        public virtual DbSet<BookingVenue> BookingVenue { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Dishtypes> Dishtypes { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Flower> Flower { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Light> Light { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<Venue> Venue { get; set; }

        // Unable to generate entity type for table 'dbo.TBL_STUDENT'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(DbConnection.ToString());
                
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

        //    modelBuilder.Entity<BookingDetails>(entity =>
        //    {
        //        entity.HasKey(e => e.BookingId);

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.BookingApproval)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);

        //        entity.Property(e => e.BookingApprovalDate).HasColumnType("datetime");

        //        entity.Property(e => e.BookingCompletedFlag)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);

        //        entity.Property(e => e.BookingDate).HasColumnType("date");

        //        entity.Property(e => e.BookingNo)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<BookingEquipment>(entity =>
        //    {
        //        entity.Property(e => e.BookingEquipmentId).HasColumnName("BookingEquipmentID");

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        //        entity.Property(e => e.EquipmentId).HasColumnName("EquipmentID");
        //    });

        //    modelBuilder.Entity<BookingFlower>(entity =>
        //    {
        //        entity.Property(e => e.BookingFlowerId).HasColumnName("BookingFlowerID");

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        //        entity.Property(e => e.FlowerId).HasColumnName("FlowerID");
        //    });

        //    modelBuilder.Entity<BookingFood>(entity =>
        //    {
        //        entity.HasKey(e => e.BookFoodId);

        //        entity.Property(e => e.BookFoodId).HasColumnName("BookFoodID");

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        //        entity.Property(e => e.FoodType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);

        //        entity.Property(e => e.MealType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<BookingLight>(entity =>
        //    {
        //        entity.HasKey(e => e.BookLightId);

        //        entity.Property(e => e.BookLightId).HasColumnName("BookLightID");

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        //        entity.Property(e => e.LightIdselected).HasColumnName("LightIDSelected");

        //        entity.Property(e => e.LightType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<BookingVenue>(entity =>
        //    {
        //        entity.Property(e => e.BookingVenueId).HasColumnName("BookingVenueID");

        //        entity.Property(e => e.BookingId).HasColumnName("BookingID");

        //        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        //        entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

        //        entity.Property(e => e.VenueId).HasColumnName("VenueID");
        //    });

        //    modelBuilder.Entity<City>(entity =>
        //    {
        //        entity.Property(e => e.CityId).HasColumnName("CityID");

        //        entity.Property(e => e.CityName).HasMaxLength(200);

        //        entity.Property(e => e.StateId).HasColumnName("StateID");
        //    });

        //    modelBuilder.Entity<Country>(entity =>
        //    {
        //        entity.Property(e => e.CountryId).HasColumnName("CountryID");

        //        entity.Property(e => e.Name)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Dishtypes>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasColumnName("ID");

        //        entity.Property(e => e.Dishtype)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Equipment>(entity =>
        //    {
        //        entity.Property(e => e.EquipmentId).HasColumnName("EquipmentID");

        //        entity.Property(e => e.Createdate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.EquipmentFilePath)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EquipmentFilename)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EquipmentName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Event>(entity =>
        //    {
        //        entity.Property(e => e.EventId).HasColumnName("EventID");

        //        entity.Property(e => e.EventType)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Status)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Flower>(entity =>
        //    {
        //        entity.Property(e => e.FlowerId).HasColumnName("FlowerID");

        //        entity.Property(e => e.Createdate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.FlowerFilePath)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FlowerFilename)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FlowerName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Food>(entity =>
        //    {
        //        entity.Property(e => e.FoodId).HasColumnName("FoodID");

        //        entity.Property(e => e.Createdate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.FoodFilePath)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FoodFilename)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FoodName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FoodType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);

        //        entity.Property(e => e.MealType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Light>(entity =>
        //    {
        //        entity.Property(e => e.LightId).HasColumnName("LightID");

        //        entity.Property(e => e.Createdate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.LightFilePath)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LightFilename)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LightName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LightType)
        //            .HasMaxLength(1)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Registration>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasColumnName("ID");

        //        entity.Property(e => e.Address)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Birthdate).HasColumnType("datetime");

        //        entity.Property(e => e.ConfirmPassword)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        //        entity.Property(e => e.EmailId)
        //            .HasColumnName("EmailID")
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Gender)
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Mobileno)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Name)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Password)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.RoleId).HasColumnName("RoleID");

        //        entity.Property(e => e.Username)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Roles>(entity =>
        //    {
        //        entity.HasKey(e => e.RoleId);

        //        entity.Property(e => e.RoleId).HasColumnName("RoleID");

        //        entity.Property(e => e.Rolename)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<States>(entity =>
        //    {
        //        entity.HasKey(e => e.StateId);

        //        entity.Property(e => e.StateId).HasColumnName("StateID");

        //        entity.Property(e => e.CountryId).HasColumnName("CountryID");

        //        entity.Property(e => e.StateName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<TblUser>(entity =>
        //    {
        //        entity.ToTable("TBL_USER");

        //        entity.Property(e => e.Pwd)
        //            .HasColumnName("pwd")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Role).HasMaxLength(10);

        //        entity.Property(e => e.Username)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Venue>(entity =>
        //    {
        //        entity.Property(e => e.VenueId).HasColumnName("VenueID");

        //        entity.Property(e => e.Createdate)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.VenueFilePath)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.VenueFilename)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);

        //        entity.Property(e => e.VenueName)
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });
        //}
    }
}
