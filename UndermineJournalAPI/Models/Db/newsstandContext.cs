using System;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace UndermineJournalAPI.Models.Db
{
    public partial class newsstandContext : DbContext
    {
        public newsstandContext()
        {
        }

        public newsstandContext(DbContextOptions<newsstandContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBonusSet> TblBonusSets { get; set; }
        public virtual DbSet<TblBuild> TblBuilds { get; set; }
        public virtual DbSet<TblDbccurvePoint> TblDbccurvePoints { get; set; }
        public virtual DbSet<TblDbcenchant> TblDbcenchants { get; set; }
        public virtual DbSet<TblDbcitem> TblDbcitems { get; set; }
        public virtual DbSet<TblDbcitemBonu> TblDbcitemBonus { get; set; }
        public virtual DbSet<TblDbcitemNameDescription> TblDbcitemNameDescriptions { get; set; }
        public virtual DbSet<TblDbcitemRandomSuffix> TblDbcitemRandomSuffixes { get; set; }
        public virtual DbSet<TblDbcitemReagent> TblDbcitemReagents { get; set; }
        public virtual DbSet<TblDbcitemSpell> TblDbcitemSpells { get; set; }
        public virtual DbSet<TblDbcitemSubClass> TblDbcitemSubClasses { get; set; }
        public virtual DbSet<TblDbcitemVendorCost> TblDbcitemVendorCosts { get; set; }
        public virtual DbSet<TblDbcpet> TblDbcpets { get; set; }
        public virtual DbSet<TblDbcrandEnchant> TblDbcrandEnchants { get; set; }
        public virtual DbSet<TblDbcskillLine> TblDbcskillLines { get; set; }
        public virtual DbSet<TblDbcspell> TblDbcspells { get; set; }
        public virtual DbSet<TblDbcspellCraft> TblDbcspellCrafts { get; set; }
        public virtual DbSet<TblDbcspellReagent> TblDbcspellReagents { get; set; }
        public virtual DbSet<TblDbctradeSkillCategory> TblDbctradeSkillCategories { get; set; }
        public virtual DbSet<TblHouseCheck> TblHouseChecks { get; set; }
        public virtual DbSet<TblItemBonusesSeen> TblItemBonusesSeens { get; set; }
        public virtual DbSet<TblItemGlobal> TblItemGlobals { get; set; }
        public virtual DbSet<TblItemHistoryDaily> TblItemHistoryDailies { get; set; }
        public virtual DbSet<TblItemHistoryMonthly> TblItemHistoryMonthlies { get; set; }
        public virtual DbSet<TblItemLevelsSeen> TblItemLevelsSeens { get; set; }
        public virtual DbSet<TblItemSummary> TblItemSummaries { get; set; }
        public virtual DbSet<TblPet> TblPets { get; set; }
        public virtual DbSet<TblPetGlobal> TblPetGlobals { get; set; }
        public virtual DbSet<TblPetSummary> TblPetSummaries { get; set; }
        public virtual DbSet<TblRealm> TblRealms { get; set; }

        // Unable to generate entity type for table 'newsstand.tblBuilding' since its primary key could not be scaffolded. Please see the warning messages.
        // Unable to generate entity type for table 'newsstand.tblSnapshot' since its primary key could not be scaffolded. Please see the warning messages.
        // Unable to generate entity type for table 'newsstand.tblWowToken' since its primary key could not be scaffolded. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=newswire.theunderminejournal.com;Database=newsstand;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBonusSet>(entity =>
            {
                entity.HasKey(e => new { e.Set, e.Tagid })
                    .HasName("PRIMARY");

                entity.ToTable("tblBonusSet");

                entity.Property(e => e.Set)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("set");

                entity.Property(e => e.Tagid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("tagid");
            });

            modelBuilder.Entity<TblBuild>(entity =>
            {
                entity.HasKey(e => e.Build)
                    .HasName("PRIMARY");

                entity.ToTable("tblBuilds");

                entity.Property(e => e.Build)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("build");

                entity.Property(e => e.Files)
                    .IsRequired()
                    .HasColumnType("mediumblob")
                    .HasColumnName("files");
            });

            modelBuilder.Entity<TblDbccurvePoint>(entity =>
            {
                entity.HasKey(e => new { e.Curve, e.Step })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCCurvePoint");

                entity.Property(e => e.Curve)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("curve");

                entity.Property(e => e.Step)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("step");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblDbcenchant>(entity =>
            {
                entity.ToTable("tblDBCEnchants");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Effect)
                    .HasMaxLength(64)
                    .HasColumnName("effect");

                entity.Property(e => e.Gem)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("gem");
            });

            modelBuilder.Entity<TblDbcitem>(entity =>
            {
                entity.ToTable("tblDBCItem");

                entity.HasIndex(e => new { e.Class, e.Quality }, "class");

                entity.HasIndex(e => e.Display, "display");

                entity.HasIndex(e => e.Othersideitem, "otherside");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Auctionable)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("auctionable");

                entity.Property(e => e.Binds)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("binds");

                entity.Property(e => e.Buyfromvendor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buyfromvendor");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Display)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("display");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("icon");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.NameDede)
                    .HasMaxLength(250)
                    .HasColumnName("name_dede");

                entity.Property(e => e.NameEnus)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("name_enus");

                entity.Property(e => e.NameEses)
                    .HasMaxLength(250)
                    .HasColumnName("name_eses");

                entity.Property(e => e.NameFrfr)
                    .HasMaxLength(250)
                    .HasColumnName("name_frfr");

                entity.Property(e => e.NameItit)
                    .HasMaxLength(250)
                    .HasColumnName("name_itit");

                entity.Property(e => e.NameKokr)
                    .HasMaxLength(250)
                    .HasColumnName("name_kokr");

                entity.Property(e => e.NamePtbr)
                    .HasMaxLength(250)
                    .HasColumnName("name_ptbr");

                entity.Property(e => e.NameRuru)
                    .HasMaxLength(250)
                    .HasColumnName("name_ruru");

                entity.Property(e => e.NameZhtw)
                    .HasMaxLength(250)
                    .HasColumnName("name_zhtw");

                entity.Property(e => e.Othersideitem)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("othersideitem");

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("quality");

                entity.Property(e => e.Requiredlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("requiredlevel");

                entity.Property(e => e.Requiredside)
                    .IsRequired()
                    .HasColumnType("enum('Alliance','Horde','')")
                    .HasColumnName("requiredside")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Requiredskill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("requiredskill");

                entity.Property(e => e.Selltovendor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("selltovendor");

                entity.Property(e => e.Stacksize)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("stacksize");

                entity.Property(e => e.Subclass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("subclass");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblDbcitemBonu>(entity =>
            {
                entity.ToTable("tblDBCItemBonus");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("level");

                entity.Property(e => e.Levelcurve)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("levelcurve");

                entity.Property(e => e.Levelcurvepriority)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("levelcurvepriority");

                entity.Property(e => e.Nameid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("nameid");

                entity.Property(e => e.Namepriority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("namepriority");

                entity.Property(e => e.Previewlevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("previewlevel");

                entity.Property(e => e.Quality)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("quality");

                entity.Property(e => e.Requiredlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("requiredlevel");

                entity.Property(e => e.Socketmask)
                    .HasColumnType("bit(32)")
                    .HasColumnName("socketmask");

                entity.Property(e => e.Tagid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("tagid");

                entity.Property(e => e.Tagpriority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("tagpriority");
            });

            modelBuilder.Entity<TblDbcitemNameDescription>(entity =>
            {
                entity.ToTable("tblDBCItemNameDescription");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DescDede)
                    .HasMaxLength(120)
                    .HasColumnName("desc_dede");

                entity.Property(e => e.DescEnus)
                    .HasMaxLength(120)
                    .HasColumnName("desc_enus");

                entity.Property(e => e.DescEses)
                    .HasMaxLength(120)
                    .HasColumnName("desc_eses");

                entity.Property(e => e.DescFrfr)
                    .HasMaxLength(120)
                    .HasColumnName("desc_frfr");

                entity.Property(e => e.DescItit)
                    .HasMaxLength(120)
                    .HasColumnName("desc_itit");

                entity.Property(e => e.DescKokr)
                    .HasMaxLength(120)
                    .HasColumnName("desc_kokr");

                entity.Property(e => e.DescPtbr)
                    .HasMaxLength(120)
                    .HasColumnName("desc_ptbr");

                entity.Property(e => e.DescRuru)
                    .HasMaxLength(120)
                    .HasColumnName("desc_ruru");

                entity.Property(e => e.DescZhtw)
                    .HasMaxLength(120)
                    .HasColumnName("desc_zhtw");
            });

            modelBuilder.Entity<TblDbcitemRandomSuffix>(entity =>
            {
                entity.HasKey(e => new { e.Locale, e.Suffix })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCItemRandomSuffix");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale")
                    .IsFixedLength(true);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(120)
                    .HasColumnName("suffix");
            });

            modelBuilder.Entity<TblDbcitemReagent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDBCItemReagents");

                entity.HasIndex(e => e.Item, "itemid");

                entity.HasIndex(e => e.Reagent, "reagentid");

                entity.HasIndex(e => e.Skillline, "skillid");

                entity.HasIndex(e => e.Spell, "spell");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Reagent)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("reagent");

                entity.Property(e => e.Skillline)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skillline");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spell");

                entity.Property(e => e.Subline)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("subline");
            });

            modelBuilder.Entity<TblDbcitemSpell>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.Spell })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCItemSpell");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell");
            });

            modelBuilder.Entity<TblDbcitemSubClass>(entity =>
            {
                entity.HasKey(e => new { e.Class, e.Subclass })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCItemSubClass");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Subclass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("subclass");

                entity.Property(e => e.NameDede)
                    .HasMaxLength(250)
                    .HasColumnName("name_dede");

                entity.Property(e => e.NameEnus)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("name_enus");

                entity.Property(e => e.NameEses)
                    .HasMaxLength(250)
                    .HasColumnName("name_eses");

                entity.Property(e => e.NameFrfr)
                    .HasMaxLength(250)
                    .HasColumnName("name_frfr");

                entity.Property(e => e.NameItit)
                    .HasMaxLength(250)
                    .HasColumnName("name_itit");

                entity.Property(e => e.NameKokr)
                    .HasMaxLength(250)
                    .HasColumnName("name_kokr");

                entity.Property(e => e.NamePtbr)
                    .HasMaxLength(250)
                    .HasColumnName("name_ptbr");

                entity.Property(e => e.NameRuru)
                    .HasMaxLength(250)
                    .HasColumnName("name_ruru");

                entity.Property(e => e.NameZhtw)
                    .HasMaxLength(250)
                    .HasColumnName("name_zhtw");
            });

            modelBuilder.Entity<TblDbcitemVendorCost>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCItemVendorCost");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Copper)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("copper");

                entity.Property(e => e.Npc)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("npc");

                entity.Property(e => e.Npccount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("npccount");
            });

            modelBuilder.Entity<TblDbcpet>(entity =>
            {
                entity.ToTable("tblDBCPet");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("category");

                entity.Property(e => e.Flags)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("icon");

                entity.Property(e => e.NameDede)
                    .HasMaxLength(250)
                    .HasColumnName("name_dede");

                entity.Property(e => e.NameEnus)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("name_enus");

                entity.Property(e => e.NameEses)
                    .HasMaxLength(250)
                    .HasColumnName("name_eses");

                entity.Property(e => e.NameFrfr)
                    .HasMaxLength(250)
                    .HasColumnName("name_frfr");

                entity.Property(e => e.NameItit)
                    .HasMaxLength(250)
                    .HasColumnName("name_itit");

                entity.Property(e => e.NameKokr)
                    .HasMaxLength(250)
                    .HasColumnName("name_kokr");

                entity.Property(e => e.NamePtbr)
                    .HasMaxLength(250)
                    .HasColumnName("name_ptbr");

                entity.Property(e => e.NameRuru)
                    .HasMaxLength(250)
                    .HasColumnName("name_ruru");

                entity.Property(e => e.NameZhtw)
                    .HasMaxLength(250)
                    .HasColumnName("name_zhtw");

                entity.Property(e => e.Npc)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npc");

                entity.Property(e => e.Power)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("power");

                entity.Property(e => e.Speed)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblDbcrandEnchant>(entity =>
            {
                entity.ToTable("tblDBCRandEnchants");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("id");

                entity.Property(e => e.NameDede)
                    .HasMaxLength(64)
                    .HasColumnName("name_dede");

                entity.Property(e => e.NameEnus)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name_enus");

                entity.Property(e => e.NameEses)
                    .HasMaxLength(64)
                    .HasColumnName("name_eses");

                entity.Property(e => e.NameFrfr)
                    .HasMaxLength(64)
                    .HasColumnName("name_frfr");

                entity.Property(e => e.NameItit)
                    .HasMaxLength(64)
                    .HasColumnName("name_itit");

                entity.Property(e => e.NameKokr)
                    .HasMaxLength(64)
                    .HasColumnName("name_kokr");

                entity.Property(e => e.NamePtbr)
                    .HasMaxLength(64)
                    .HasColumnName("name_ptbr");

                entity.Property(e => e.NameRuru)
                    .HasMaxLength(64)
                    .HasColumnName("name_ruru");

                entity.Property(e => e.NameZhtw)
                    .HasMaxLength(64)
                    .HasColumnName("name_zhtw");
            });

            modelBuilder.Entity<TblDbcskillLine>(entity =>
            {
                entity.ToTable("tblDBCSkillLines");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblDbcspell>(entity =>
            {
                entity.ToTable("tblDBCSpell");

                entity.HasIndex(e => e.Replacesspell, "replaces");

                entity.HasIndex(e => e.Skillline, "skilllineid");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Cooldown)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("cooldown")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("description");

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("expansion");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Replacesspell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("replacesspell");

                entity.Property(e => e.Requiredside)
                    .IsRequired()
                    .HasColumnType("enum('Alliance','Horde','')")
                    .HasColumnName("requiredside")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Skillline)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skillline");

                entity.Property(e => e.Tradeskillcategory)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("tradeskillcategory");
            });

            modelBuilder.Entity<TblDbcspellCraft>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Item })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCSpellCrafts");

                entity.HasIndex(e => e.Item, "item");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");
            });

            modelBuilder.Entity<TblDbcspellReagent>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Item })
                    .HasName("PRIMARY");

                entity.ToTable("tblDBCSpellReagents");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Qty)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty");
            });

            modelBuilder.Entity<TblDbctradeSkillCategory>(entity =>
            {
                entity.ToTable("tblDBCTradeSkillCategory");

                entity.HasIndex(e => e.Parent, "parent");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("name");

                entity.Property(e => e.Order)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("order");

                entity.Property(e => e.Parent)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.Skillline)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skillline");
            });

            modelBuilder.Entity<TblHouseCheck>(entity =>
            {
                entity.HasKey(e => e.House)
                    .HasName("PRIMARY");

                entity.ToTable("tblHouseCheck");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Lastdaily)
                    .HasColumnType("date")
                    .HasColumnName("lastdaily");
            });

            modelBuilder.Entity<TblItemBonusesSeen>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.Bonus1, e.Bonus2, e.Bonus3, e.Bonus4 })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemBonusesSeen");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Bonus1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("bonus1");

                entity.Property(e => e.Bonus2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("bonus2");

                entity.Property(e => e.Bonus3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("bonus3");

                entity.Property(e => e.Bonus4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("bonus4");

                entity.Property(e => e.Observed)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("observed");
            });

            modelBuilder.Entity<TblItemGlobal>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.Level, e.Region })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemGlobal");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Region)
                    .HasColumnType("enum('US','EU','CN','TW','KR')")
                    .HasColumnName("region")
                    .HasDefaultValueSql("'US'");
            });

            modelBuilder.Entity<TblItemHistoryDaily>(entity =>
            {
                entity.HasKey(e => new { e.House, e.Item, e.When })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemHistoryDaily");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.When)
                    .HasColumnType("date")
                    .HasColumnName("when");

                entity.Property(e => e.Priceavg)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("priceavg");

                entity.Property(e => e.Priceend)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("priceend");

                entity.Property(e => e.Pricemax)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pricemax");

                entity.Property(e => e.Pricemin)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pricemin");

                entity.Property(e => e.Pricestart)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pricestart");

                entity.Property(e => e.Quantityavg)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quantityavg");

                entity.Property(e => e.Quantitymax)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quantitymax");

                entity.Property(e => e.Quantitymin)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quantitymin");
            });

            modelBuilder.Entity<TblItemHistoryMonthly>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.House, e.Level, e.Month })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemHistoryMonthly");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Month)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("month");

                entity.Property(e => e.Mktslvr01)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr01");

                entity.Property(e => e.Mktslvr02)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr02");

                entity.Property(e => e.Mktslvr03)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr03");

                entity.Property(e => e.Mktslvr04)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr04");

                entity.Property(e => e.Mktslvr05)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr05");

                entity.Property(e => e.Mktslvr06)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr06");

                entity.Property(e => e.Mktslvr07)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr07");

                entity.Property(e => e.Mktslvr08)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr08");

                entity.Property(e => e.Mktslvr09)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr09");

                entity.Property(e => e.Mktslvr10)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr10");

                entity.Property(e => e.Mktslvr11)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr11");

                entity.Property(e => e.Mktslvr12)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr12");

                entity.Property(e => e.Mktslvr13)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr13");

                entity.Property(e => e.Mktslvr14)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr14");

                entity.Property(e => e.Mktslvr15)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr15");

                entity.Property(e => e.Mktslvr16)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr16");

                entity.Property(e => e.Mktslvr17)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr17");

                entity.Property(e => e.Mktslvr18)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr18");

                entity.Property(e => e.Mktslvr19)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr19");

                entity.Property(e => e.Mktslvr20)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr20");

                entity.Property(e => e.Mktslvr21)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr21");

                entity.Property(e => e.Mktslvr22)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr22");

                entity.Property(e => e.Mktslvr23)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr23");

                entity.Property(e => e.Mktslvr24)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr24");

                entity.Property(e => e.Mktslvr25)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr25");

                entity.Property(e => e.Mktslvr26)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr26");

                entity.Property(e => e.Mktslvr27)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr27");

                entity.Property(e => e.Mktslvr28)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr28");

                entity.Property(e => e.Mktslvr29)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr29");

                entity.Property(e => e.Mktslvr30)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr30");

                entity.Property(e => e.Mktslvr31)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mktslvr31");

                entity.Property(e => e.Qty01)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty01");

                entity.Property(e => e.Qty02)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty02");

                entity.Property(e => e.Qty03)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty03");

                entity.Property(e => e.Qty04)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty04");

                entity.Property(e => e.Qty05)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty05");

                entity.Property(e => e.Qty06)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty06");

                entity.Property(e => e.Qty07)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty07");

                entity.Property(e => e.Qty08)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty08");

                entity.Property(e => e.Qty09)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty09");

                entity.Property(e => e.Qty10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty10");

                entity.Property(e => e.Qty11)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty11");

                entity.Property(e => e.Qty12)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty12");

                entity.Property(e => e.Qty13)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty13");

                entity.Property(e => e.Qty14)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty14");

                entity.Property(e => e.Qty15)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty15");

                entity.Property(e => e.Qty16)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty16");

                entity.Property(e => e.Qty17)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty17");

                entity.Property(e => e.Qty18)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty18");

                entity.Property(e => e.Qty19)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty19");

                entity.Property(e => e.Qty20)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty20");

                entity.Property(e => e.Qty21)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty21");

                entity.Property(e => e.Qty22)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty22");

                entity.Property(e => e.Qty23)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty23");

                entity.Property(e => e.Qty24)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty24");

                entity.Property(e => e.Qty25)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty25");

                entity.Property(e => e.Qty26)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty26");

                entity.Property(e => e.Qty27)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty27");

                entity.Property(e => e.Qty28)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty28");

                entity.Property(e => e.Qty29)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty29");

                entity.Property(e => e.Qty30)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty30");

                entity.Property(e => e.Qty31)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("qty31");
            });

            modelBuilder.Entity<TblItemLevelsSeen>(entity =>
            {
                entity.HasKey(e => new { e.Item, e.Bonusset, e.Level })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemLevelsSeen");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item");

                entity.Property(e => e.Bonusset)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bonusset");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level");
            });

            modelBuilder.Entity<TblItemSummary>(entity =>
            {
                entity.HasKey(e => new { e.House, e.Item, e.Level })
                    .HasName("PRIMARY");

                entity.ToTable("tblItemSummary");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("item");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(11,0)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TblPet>(entity =>
            {
                entity.ToTable("tblPet");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("icon");

                entity.Property(e => e.Json).HasColumnName("json");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Npc)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npc");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblPetGlobal>(entity =>
            {
                entity.HasKey(e => new { e.Species, e.Region })
                    .HasName("PRIMARY");

                entity.ToTable("tblPetGlobal");

                entity.Property(e => e.Species)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("species");

                entity.Property(e => e.Region)
                    .HasColumnType("enum('US','EU','CN','TW','KR')")
                    .HasColumnName("region");
            });

            modelBuilder.Entity<TblPetSummary>(entity =>
            {
                entity.HasKey(e => new { e.House, e.Species })
                    .HasName("PRIMARY");

                entity.ToTable("tblPetSummary");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Species)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("species");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(11,0)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TblRealm>(entity =>
            {
                entity.ToTable("tblRealm");

                entity.HasIndex(e => e.House, "house");

                entity.HasIndex(e => new { e.Region, e.Slug }, "realmset")
                    .IsUnique();

                entity.HasIndex(e => new { e.Region, e.Name }, "region")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BlizzConnection)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("blizzConnection");

                entity.Property(e => e.BlizzId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("blizzId");

                entity.Property(e => e.Canonical)
                    .HasMaxLength(50)
                    .HasColumnName("canonical");

                entity.Property(e => e.House)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("house");

                entity.Property(e => e.Locale)
                    .HasMaxLength(5)
                    .HasColumnName("locale")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Ownerrealm)
                    .HasMaxLength(100)
                    .HasColumnName("ownerrealm");

                entity.Property(e => e.Population)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("population");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnType("enum('US','EU','CN','TW','KR')")
                    .HasColumnName("region");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("slug");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
