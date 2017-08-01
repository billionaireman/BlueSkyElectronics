using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlueSkyElectronics.Models
{
    public partial class BlueSkyElectronicsContext : DbContext
    {
        public virtual DbSet<TFiling> TFiling { get; set; }
        public virtual DbSet<TStates> TStates { get; set; }
        public virtual DbSet<TStatesElectronicFiling> TStatesElectronicFiling { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=10.1.2.17;Database=BlueSkyElectronics;Trusted_Connection=True;");
        //}

        public BlueSkyElectronicsContext(DbContextOptions<BlueSkyElectronicsContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TFiling>(entity =>
            {
                entity.HasKey(e => e.FilingId)
                    .HasName("PK_T_FILING_03101999081718001");

                entity.ToTable("T_FILING");

                entity.Property(e => e.FilingId)
                    .HasColumnName("filing_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckId)
                    .HasColumnName("check_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChequeAmount)
                    .HasColumnName("cheque_amount")
                    .HasColumnType("money");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EffDateCode)
                    .HasColumnName("eff_date_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EnvelopeId).HasColumnName("envelope_id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiry_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeeBasicCode)
                    .HasColumnName("fee_basic_code")
                    .HasColumnType("char(3)");

                entity.Property(e => e.FiledDate)
                    .HasColumnName("filed_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FilingCategoryCode)
                    .HasColumnName("filing_category_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FilingFee)
                    .HasColumnName("filing_fee")
                    .HasColumnType("money");

                entity.Property(e => e.FilingNo).HasColumnName("filing_no");

                entity.Property(e => e.FilingRuleId).HasColumnName("filing_rule_id");

                entity.Property(e => e.FilingTypeId).HasColumnName("filing_type_id");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PermitNo)
                    .HasColumnName("permit_no")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Prospectus)
                    .HasColumnName("prospectus")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RegisteredAmt)
                    .HasColumnName("registered_amt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Renewal)
                    .HasColumnName("renewal")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.SalesFromDate)
                    .HasColumnName("sales_from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesToDate)
                    .HasColumnName("sales_to_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SecurityId).HasColumnName("security_id");

                entity.Property(e => e.SoldAmt)
                    .HasColumnName("sold_amt")
                    .HasColumnType("money");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");
            });

            modelBuilder.Entity<TStates>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_T_STATES_2");

                entity.ToTable("T_STATES");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccptElecFiling)
                    .HasColumnName("accpt_elec_filing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Acptbatchcheck)
                    .HasColumnName("acptbatchcheck")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Addr1Email)
                    .HasColumnName("ADDR1_EMAIL")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Addr1Fax)
                    .HasColumnName("ADDR1_FAX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Addr1Phone)
                    .HasColumnName("ADDR1_PHONE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AddrCity)
                    .HasColumnName("addr_city")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.AddrContact)
                    .HasColumnName("addr_contact")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.AddrCountry)
                    .HasColumnName("addr_country")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.AddrLine1)
                    .HasColumnName("addr_line_1")
                    .HasColumnType("char(200)");

                entity.Property(e => e.AddrLine2)
                    .HasColumnName("addr_line_2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AddrState)
                    .HasColumnName("addr_state")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.AddrZipcode)
                    .HasColumnName("addr_zipcode")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CheckPayee)
                    .HasColumnName("check_payee")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.ConDuplicate)
                    .HasColumnName("con_duplicate")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ConDuplicateNf)
                    .HasColumnName("con_duplicateNF")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ConPermit)
                    .HasColumnName("con_permit")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ConStampedRcpt)
                    .HasColumnName("con_stamped_rcpt")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DiscParValue)
                    .HasColumnName("disc_par_value")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Discrepancies)
                    .HasColumnName("discrepancies")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FeePaymentId).HasColumnName("fee_payment_id");

                entity.Property(e => e.FilingRulePages)
                    .HasColumnName("filing_rule_pages")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.OvrAddrCity)
                    .HasColumnName("ovr_addr_city")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.OvrAddrCountry)
                    .HasColumnName("ovr_addr_country")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.OvrAddrLine1)
                    .HasColumnName("ovr_addr_line_1")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OvrAddrLine2)
                    .HasColumnName("ovr_addr_line_2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OvrAddrState)
                    .HasColumnName("ovr_addr_state")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.OvrAddrZipcode)
                    .HasColumnName("ovr_addr_zipcode")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.OvrContact)
                    .HasColumnName("ovr_contact")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.SignatureId).HasColumnName("signature_id");

                entity.Property(e => e.StClass).HasColumnName("st_class");

                entity.Property(e => e.StCode)
                    .IsRequired()
                    .HasColumnName("st_code")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.StFund).HasColumnName("st_fund");

                entity.Property(e => e.StName)
                    .HasColumnName("st_name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.StNofiling).HasColumnName("st_nofiling");

                entity.Property(e => e.StPortfolio).HasColumnName("st_portfolio");

                entity.Property(e => e.StProspectus).HasColumnName("st_prospectus");

                entity.Property(e => e.U2Designee)
                    .HasColumnName("u2_designee")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.U2DesigneeId).HasColumnName("u2_designee_id");
            });

            modelBuilder.Entity<TStatesElectronicFiling>(entity =>
            {
                entity.ToTable("T_STATES_ELECTRONIC_FILING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasColumnType("varchar(255)");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TStatesElectronicFiling)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_T_STATES_ELECTRONIC_FILING_T_STATES");
            });
        }
    }
}