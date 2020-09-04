using Microsoft.EntityFrameworkCore;
using Social.Domain.Models;

namespace Social.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TypeDoc> TypeDocs { get; set; }
        public DbSet<EventSocialSession> EventSocialSession { get; set; }
        public DbSet<JournalInterdepartServSocia> JournalInterdepartServSocia { get; set; }
        public DbSet<JournalInterdepartSocial> JournalInterdepartSocial { get; set; }
        public DbSet<PersonsSocial> PersonsSocial { get; set; }
        public DbSet<PersonsSocialDoc> PersonsSocialDoc { get; set; }
        public DbSet<PersonsSocialDocFile> PersonsSocialDocFile { get; set; }
        public DbSet<PersonsSocialLegalRepresent> PersonsSocialLegalRepresent { get; set; }
        public DbSet<PersonsSocialRepresent> PersonsSocialRepresent { get; set; }
        public DbSet<ServisesSocial> ServisesSocial { get; set; }
        public DbSet<ServisesSocialDoc> ServisesSocialDoc { get; set; }
        public DbSet<ServisesSocialFamilyCat> ServisesSocialFamilyCat { get; set; }
        public DbSet<ServisesSocialHistorys> ServisesSocialHistorys { get; set; }
        public DbSet<ServisesSocialPersonDoc> ServisesSocialPersonDoc { get; set; }
        public DbSet<SocialDelivery> SocialDelivery { get; set; }
        public DbSet<SocialPeriod> SocialPeriod { get; set; }
        public DbSet<SocialPlace> SocialPlace { get; set; }
        public DbSet<SocialSession> SocialSession { get; set; }
        public DbSet<SocialWay> SocialWay { get; set; }
        public DbSet<School> School { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:DefaultSchema", "");

            modelBuilder.Entity<EventSocialSession>(entity =>
            {
                entity.ToTable("EVENT_SOCIAL_SESSION");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_EVENT_SOC_SESSION_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Event)
                    .HasColumnName("EVENT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SESSION_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.EventSocialSession)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVENT_SOC_SESSION_LIST_ID");
            });

            modelBuilder.Entity<JournalInterdepartServSocia>(entity =>
            {
                entity.ToTable("JOURNAL_INTERDEPART_SERV_SOCIA");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_JI_SERVICE_SOC_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateFinished)
                    .HasColumnName("DATE_FINISHED")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.FlagFms)
                    .HasColumnName("FLAG_FMS")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdJiRest)
                    .HasColumnName("ID_JI_REST")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdService)
                    .HasColumnName("ID_SERVICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.InterdepartStatus)
                    .HasColumnName("INTERDEPART_STATUS")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PersonBplace)
                    .HasColumnName("PERSON_BPLACE")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.PersonDr)
                    .HasColumnName("PERSON_DR")
                    .HasColumnType("DATE");

                entity.Property(e => e.PersonFm)
                    .HasColumnName("PERSON_FM")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.PersonIm)
                    .HasColumnName("PERSON_IM")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.PersonOt)
                    .HasColumnName("PERSON_OT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.IdJiRestNavigation)
                    .WithMany(p => p.JournalInterdepartServSocia)
                    .HasForeignKey(d => d.IdJiRest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JI_SERVICE_SOC_JOURNAL_ID");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.JournalInterdepartServSocia)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JI_SERVICE_SOC_SERVICE_ID");
            });

            modelBuilder.Entity<JournalInterdepartSocial>(entity =>
            {
                entity.ToTable("JOURNAL_INTERDEPART_SOCIAL");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_JL_INTERDEPART_SOC_ID")
                    .IsUnique();

                entity.HasIndex(e => e.JournalNumber)
                    .HasName("UK_JL_INTERDEPART_SOC_NUM")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("DATE_CREATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateFinished)
                    .HasColumnName("DATE_FINISHED")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.JournalNumber)
                    .HasColumnName("JOURNAL_NUMBER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.JournalStatus)
                    .HasColumnName("JOURNAL_STATUS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MaxDocDate)
                    .HasColumnName("MAX_DOC_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MinDocDate)
                    .HasColumnName("MIN_DOC_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.ServiesCount)
                    .HasColumnName("SERVIES_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql(@"0
");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<PersonsSocial>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK_PERSON_SOC_ID");

                entity.ToTable("PERSONS_SOCIAL");

                entity.HasIndex(e => new { e.PersonId, e.Snils, e.Sex })
                    .HasName("I_PERSON_REST2_TEMP");

                entity.HasIndex(e => new { e.Bdate, e.Surname, e.Name, e.Patronymic })
                    .HasName("I_PERSON_REST2_BDATE_FIO");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Adate)
                    .HasColumnName("ADATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.AddressId)
                    .HasColumnName("ADDRESS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Anum)
                    .HasColumnName("ANUM")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Apartment)
                    .HasColumnName("APARTMENT")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Bdate)
                    .HasColumnName("BDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Birthplace)
                    .HasColumnName("BIRTHPLACE")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("167 ");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Ddate)
                    .HasColumnName("DDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IsLegalRepresent)
                    .HasColumnName("IS_LEGAL_REPRESENT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsRepresent)
                    .HasColumnName("IS_REPRESENT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Patronymic)
                    .HasColumnName("PATRONYMIC")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("PHONE_HOME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("PHONE_MOBILE")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("PHONE_WORK")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.PostId)
                    .HasColumnName("POST_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Snils)
                    .HasColumnName("SNILS")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.WorkId)
                    .HasColumnName("WORK_ID")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<PersonsSocialDoc>(entity =>
            {
                entity.ToTable("PERSONS_SOCIAL_DOC");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PERSONS_SOC_DOC_ID")
                    .IsUnique();

                entity.HasIndex(e => e.PersonId)
                    .HasName("I_PERSON_REST2_DOC_PERS_ID");

                entity.HasIndex(e => e.TypeDocId)
                    .HasName("I_PERSON_REST2_DOC_TYPE_DOC_ID");

                entity.HasIndex(e => new { e.PersonId, e.TypeDocId, e.DateInsert })
                    .HasName("I_PERSON_REST2_DOC_TEMP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Bdate)
                    .HasColumnName("BDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateIn)
                    .HasColumnName("DATE_IN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateOut)
                    .HasColumnName("DATE_OUT")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Get)
                    .HasColumnName("GET")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.GetDate)
                    .HasColumnName("GET_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.NumSheet)
                    .HasColumnName("NUM_SHEET")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Ser)
                    .HasColumnName("SER")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.TypeDocId)
                    .HasColumnName("TYPE_DOC_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.VersionDoc)
                    .HasColumnName("VERSION_DOC")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonsSocialDoc)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PERSONS_SOC_ID");
            });

            modelBuilder.Entity<PersonsSocialDocFile>(entity =>
            {
                entity.ToTable("PERSONS_SOCIAL_DOC_FILE");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PERSONS_SOC_DOC_FILE_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateFileCreate)
                    .HasColumnName("DATE_FILE_CREATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasColumnType("VARCHAR2(256)");

                entity.Property(e => e.FileBody)
                    .HasColumnName("FILE_BODY")
                    .HasColumnType("BLOB");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("FILE_NAME")
                    .HasColumnType("VARCHAR2(256)");

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.IdPersonsDoc)
                    .HasColumnName("ID_PERSONS_DOC")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.IdPersonsDocNavigation)
                    .WithMany(p => p.PersonsSocialDocFile)
                    .HasForeignKey(d => d.IdPersonsDoc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PERSONS_SOC_DOC_FILE_PD");
            });

            modelBuilder.Entity<PersonsSocialLegalRepresent>(entity =>
            {
                entity.ToTable("PERSONS_SOCIAL_LEGAL_REPRESENT");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PERSON_SOC_LEGAL_REPRESENT")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdLegalRepresent)
                    .HasColumnName("ID_LEGAL_REPRESENT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdPerson)
                    .HasColumnName("ID_PERSON")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.IdLegalRepresentNavigation)
                    .WithMany(p => p.PersonsSocialLegalRepresentIdLegalRepresentNavigation)
                    .HasForeignKey(d => d.IdLegalRepresent)
                    .HasConstraintName("FK_PERSON_SOC_LEGAL_REPRESENT1");

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.PersonsSocialLegalRepresentIdPersonNavigation)
                    .HasForeignKey(d => d.IdPerson)
                    .HasConstraintName("FK_PERSON_SOC_LEGAL_REPRESENT2");
            });

            modelBuilder.Entity<PersonsSocialRepresent>(entity =>
            {
                entity.ToTable("PERSONS_SOCIAL_REPRESENT");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PERSON_SOC_REPRESENT")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdPerson)
                    .HasColumnName("ID_PERSON")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdRepresent)
                    .HasColumnName("ID_REPRESENT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.PersonsSocialRepresentIdPersonNavigation)
                    .HasForeignKey(d => d.IdPerson)
                    .HasConstraintName("FK_PERSON_SOC_REPRESENT2");

                entity.HasOne(d => d.IdRepresentNavigation)
                    .WithMany(p => p.PersonsSocialRepresentIdRepresentNavigation)
                    .HasForeignKey(d => d.IdRepresent)
                    .HasConstraintName("FK_PERSON_SOC_REPRESENT1");
            });

            modelBuilder.Entity<ServisesSocial>(entity =>
            {
                entity.ToTable("SERVISES_SOCIAL");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SERVISES_INV_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Class)
                    .HasColumnName("CLASS")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateReg)
                    .HasColumnName("DATE_REG")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Delivery).HasColumnName("DELIVERY");

                entity.Property(e => e.DocNum)
                    .HasColumnName("DOC_NUM")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.IdContrUpdate)
                    .HasColumnName("ID_CONTR_UPDATE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdCurrLegalRepresent)
                    .HasColumnName("ID_CURR_LEGAL_REPRESENT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdCurrRepresent)
                    .HasColumnName("ID_CURR_REPRESENT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdOperInsert)
                    .HasColumnName("ID_OPER_INSERT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IdServiceHistorys)
                    .HasColumnName("ID_SERVICE_HISTORYS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PERSON_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RoomCoupon)
                    .HasColumnName("ROOM_COUPON")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.SchoolId)
                    .HasColumnName("SCHOOL_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SESSION_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.IdCurrLegalRepresentNavigation)
                    .WithMany(p => p.ServisesSocialIdCurrLegalRepresentNavigation)
                    .HasForeignKey(d => d.IdCurrLegalRepresent)
                    .HasConstraintName("FK_SERVISES_INV_LEG_REPR_ID");

                entity.HasOne(d => d.IdCurrRepresentNavigation)
                    .WithMany(p => p.ServisesSocialIdCurrRepresentNavigation)
                    .HasForeignKey(d => d.IdCurrRepresent)
                    .HasConstraintName("FK_SERVISES_INV_REPR_ID");

                entity.HasOne(d => d.IdServiceHistorysNavigation)
                    .WithMany(p => p.ServisesSocial)
                    .HasForeignKey(d => d.IdServiceHistorys)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SERVISES_INV_HISTORY_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ServisesSocialPerson)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_SERVISES_INV_PERSON_ID");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.ServisesSocial)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_SERVISES_INV_SESSION_ID");

                entity.Property(d => d.Reserve)
                    .HasColumnName("RESERVE")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(d => d.Unic_Code)
                    .HasColumnName("UNIC_CODE")
                    .HasColumnType("VARCHAR2(255)");

                //entity.Property(d => d.InfoIpAdress)
                //    .HasColumnName("INFO_IP_ADRESS")
                //    .HasColumnType("VARCHAR2(20)");

                //entity.Property(d => d.InfoBrowser)
                //    .HasColumnName("INFO_BROWSER")
                //    .HasColumnType("VARCHAR2(250)");
            });

            modelBuilder.Entity<ServisesSocialDoc>(entity =>
            {
                entity.ToTable("SERVISES_SOCIAL_DOC");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SERVISES_INV_DOC_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateFileCreate)
                    .HasColumnName("DATE_FILE_CREATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.FileBody)
                    .HasColumnName("FILE_BODY")
                    .HasColumnType("BLOB");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("FILE_NAME")
                    .HasColumnType("VARCHAR2(256)");

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.NumSheet)
                    .HasColumnName("NUM_SHEET")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ServisesId)
                    .HasColumnName("SERVISES_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TypeServiceDoc)
                    .IsRequired()
                    .HasColumnName("TYPE_SERVICE_DOC")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.Servises)
                    .WithMany(p => p.ServisesSocialDoc)
                    .HasForeignKey(d => d.ServisesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SERVISE_INV_DOC_SERVISES_ID");
            });

            modelBuilder.Entity<ServisesSocialFamilyCat>(entity =>
            {
                entity.ToTable("SERVISES_SOCIAL_FAMILY_CAT");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SERVIS_SOC_FAMILY_CAT_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CategoryFamilyId)
                    .HasColumnName("CATEGORY_FAMILY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateAttribute)
                    .HasColumnName("DATE_ATTRIBUTE")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NumAttribute)
                    .HasColumnName("NUM_ATTRIBUTE")
                    .HasColumnType("NVARCHAR2(50)");

                entity.Property(e => e.ServisesSocialId)
                    .HasColumnName("SERVISES_SOCIAL_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.ServisesSocial)
                    .WithMany(p => p.ServisesSocialFamilyCat)
                    .HasForeignKey(d => d.ServisesSocialId)
                    .HasConstraintName("FK_SERVISES_SOC_ID");
            });

            modelBuilder.Entity<ServisesSocialHistorys>(entity =>
            {
                entity.ToTable("SERVISES_SOCIAL_HISTORYS");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SERV_SOC_HIST_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.HistoryDate)
                    .HasColumnName("HISTORY_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.HistoryText)
                    .HasColumnName("HISTORY_TEXT")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("ID_STATUS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdTypeFailure)
                    .HasColumnName("ID_TYPE_FAILURE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ServisesId)
                    .HasColumnName("SERVISES_ID")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.Servises)
                    .WithMany(p => p.ServisesSocialHistorys)
                    .HasForeignKey(d => d.ServisesId)
                    .HasConstraintName("FK_SERV_SOC_HIST_SERVISES_ID");
            });

            modelBuilder.Entity<ServisesSocialPersonDoc>(entity =>
            {
                entity.ToTable("SERVISES_SOCIAL_PERSON_DOC");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SERV_SOC_PERSON_DOC_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdTypeDoc)
                    .HasColumnName("ID_TYPE_DOC")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PersonsDocId)
                    .HasColumnName("PERSONS_DOC_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ServisesId)
                    .HasColumnName("SERVISES_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.HasOne(d => d.Servises)
                    .WithMany(p => p.ServisesSocialPersonDoc)
                    .HasForeignKey(d => d.ServisesId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SERV_SOC_PERS_DOC_SERVISE");
            });

            modelBuilder.Entity<SocialDelivery>(entity =>
            {
                entity.ToTable("SOCIAL_DELIVERY");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SOC_DELIVERY_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Method).HasColumnName("METHOD");

                entity.Property(e => e.SocialSessionId)
                    .HasColumnName("SOCIAL_SESSION_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.SocialSession)
                    .WithMany(p => p.SocialDelivery)
                    .HasForeignKey(d => d.SocialSessionId)
                    .HasConstraintName("FK_SOC_DELIVERY_SESSION_ID");
            });

            modelBuilder.Entity<SocialPeriod>(entity =>
            {
                entity.ToTable("SOCIAL_PERIOD");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SOC_PERIOD_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.GetDocBegin)
                    .HasColumnName("GET_DOC_BEGIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.GetDocEnd)
                    .HasColumnName("GET_DOC_END")
                    .HasColumnType("DATE");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.PeriodBegin)
                    .HasColumnName("PERIOD_BEGIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.PeriodEnd)
                    .HasColumnName("PERIOD_END")
                    .HasColumnType("DATE");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SocialPlace>(entity =>
            {
                entity.ToTable("SOCIAL_PLACE");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SOC_PLACE_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.SocialWayId)
                    .HasColumnName("SOCIAL_WAY_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.SocialWay)
                    .WithMany(p => p.SocialPlace)
                    .HasForeignKey(d => d.SocialWayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOC_PLACE_WAY_ID");
            });

            modelBuilder.Entity<SocialSession>(entity =>
            {
                entity.ToTable("SOCIAL_SESSION");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SOC_SESSION_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.Count)
                    .HasColumnName("COUNT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateBegin)
                    .HasColumnName("DATE_BEGIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("DATE_END")
                    .HasColumnType("DATE");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdEventSession)
                    .HasColumnName("ID_EVENT_SESSION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.NumSession)
                    .HasColumnName("NUM_SESSION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SocialPlaceId)
                    .HasColumnName("SOCIAL_PLACE_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdEventSessionNavigation)
                    .WithMany(p => p.SocialSession)
                    .HasForeignKey(d => d.IdEventSession)
                    .HasConstraintName("FK_SOC_SESSION_EVENT_ID");

                entity.HasOne(d => d.SocialPlace)
                    .WithMany(p => p.SocialSession)
                    .HasForeignKey(d => d.SocialPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOC_SESSION_PLACE_ID");
            });

            modelBuilder.Entity<SocialWay>(entity =>
            {
                entity.ToTable("SOCIAL_WAY");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_SOC_WAY_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.SignTerritory).HasColumnName("SIGN_TERRITORY");

                entity.Property(e => e.SocialPeriodId)
                    .HasColumnName("SOCIAL_PERIOD_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.SocialPeriod)
                    .WithMany(p => p.SocialWay)
                    .HasForeignKey(d => d.SocialPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SOC_WAY_PERIOD_ID");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("SCHOOL");

                entity.HasIndex(e => e.Id)
                    .HasName("SCHOOL_PK")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("SCHOOL_UK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AbbName)
                    .HasColumnName("ABB_NAME")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.DateInsert)
                    .HasColumnName("DATE_INSERT")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("DATE_UPDATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_USER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.HasSequence("JIS_SEQUENCE");

            modelBuilder.HasSequence("S_NEW_ACCESS_ROLE_ID");

            modelBuilder.HasSequence("S_NEW_ACCESS_USER_ID");

            modelBuilder.HasSequence("S_NEW_ACCOUNT_ID");

            modelBuilder.HasSequence("S_NEW_ADDRESS_POSTCODE_ID");

            modelBuilder.HasSequence("S_NEW_CATEGORY_DOC_ID");

            modelBuilder.HasSequence("S_NEW_JINTERDEP_NUM");

            modelBuilder.HasSequence("S_NEW_JIRS");

            modelBuilder.HasSequence("S_NEW_NAVIGATOR_ID");

            modelBuilder.HasSequence("S_NEW_NUM");

            modelBuilder.HasSequence("S_NEW_PERSON_ID");

            modelBuilder.HasSequence("S_NEW_PERSONS_DOC_ID");

            modelBuilder.HasSequence("S_NEW_PERSONS_HISTORYS_ID");

            modelBuilder.HasSequence("S_NEW_ROLE_OBJECTS_ID");

            modelBuilder.HasSequence("S_NEW_SERVISES_DOC_ID");

            modelBuilder.HasSequence("S_NEW_SERVISES_HISTORYS_ID");

            modelBuilder.HasSequence("S_NEW_SERVISES_ID");

            modelBuilder.HasSequence("S_NEW_SERVISES_NUM");

            modelBuilder.HasSequence("S_NEW_SERVISES_REST_NUM");

            modelBuilder.HasSequence("S_NEW_SHO_ID");

            modelBuilder.HasSequence("S_NEW_USER_ID");

            modelBuilder.HasSequence("S_NEW_ZAGS_DATA_ID");

            modelBuilder.HasSequence("UID_SEQUENCE");
        }

    }
}
