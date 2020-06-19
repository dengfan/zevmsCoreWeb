using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZEVMSWEB.Models.Entities
{
    public partial class zevms027Context : DbContext
    {
        public zevms027Context()
        {
        }

        public zevms027Context(DbContextOptions<zevms027Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsJilu> AccountsJilu { get; set; }
        public virtual DbSet<AccountsXj> AccountsXj { get; set; }
        public virtual DbSet<Accountsrecharge> Accountsrecharge { get; set; }
        public virtual DbSet<Auctionitems> Auctionitems { get; set; }
        public virtual DbSet<Auctionpoint> Auctionpoint { get; set; }
        public virtual DbSet<Azjm> Azjm { get; set; }
        public virtual DbSet<Bossloa> Bossloa { get; set; }
        public virtual DbSet<Bosslog> Bosslog { get; set; }
        public virtual DbSet<Buddies> Buddies { get; set; }
        public virtual DbSet<Buddyentries> Buddyentries { get; set; }
        public virtual DbSet<Cashitems> Cashitems { get; set; }
        public virtual DbSet<Cashshopcouponitems> Cashshopcouponitems { get; set; }
        public virtual DbSet<Cashshopcoupons> Cashshopcoupons { get; set; }
        public virtual DbSet<Changemapspecial> Changemapspecial { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<CharactersJilu> CharactersJilu { get; set; }
        public virtual DbSet<CharactersKmob> CharactersKmob { get; set; }
        public virtual DbSet<Charactersforging> Charactersforging { get; set; }
        public virtual DbSet<Charactersin> Charactersin { get; set; }
        public virtual DbSet<Charactersiy> Charactersiy { get; set; }
        public virtual DbSet<Characterslots> Characterslots { get; set; }
        public virtual DbSet<Cheatlog> Cheatlog { get; set; }
        public virtual DbSet<Completpqs> Completpqs { get; set; }
        public virtual DbSet<Configvalues> Configvalues { get; set; }
        public virtual DbSet<Consumption> Consumption { get; set; }
        public virtual DbSet<DlqIllegalRecords> DlqIllegalRecords { get; set; }
        public virtual DbSet<Dlqvip> Dlqvip { get; set; }
        public virtual DbSet<DropData> DropData { get; set; }
        public virtual DbSet<DropDataGlobal> DropDataGlobal { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Famelog> Famelog { get; set; }
        public virtual DbSet<Fullpoint> Fullpoint { get; set; }
        public virtual DbSet<Gifts> Gifts { get; set; }
        public virtual DbSet<Global> Global { get; set; }
        public virtual DbSet<Gmlog> Gmlog { get; set; }
        public virtual DbSet<Hwidbans> Hwidbans { get; set; }
        public virtual DbSet<Inventoryequipment> Inventoryequipment { get; set; }
        public virtual DbSet<Inventoryitems> Inventoryitems { get; set; }
        public virtual DbSet<Ipbans> Ipbans { get; set; }
        public virtual DbSet<Iplog> Iplog { get; set; }
        public virtual DbSet<Jiance> Jiance { get; set; }
        public virtual DbSet<Jiazu> Jiazu { get; set; }
        public virtual DbSet<Keymap> Keymap { get; set; }
        public virtual DbSet<Levelhistory> Levelhistory { get; set; }
        public virtual DbSet<Macbans> Macbans { get; set; }
        public virtual DbSet<Macfilters> Macfilters { get; set; }
        public virtual DbSet<Mainpage> Mainpage { get; set; }
        public virtual DbSet<Mountdata> Mountdata { get; set; }
        public virtual DbSet<MxmxdChenghao> MxmxdChenghao { get; set; }
        public virtual DbSet<MxmxdFumoInfo> MxmxdFumoInfo { get; set; }
        public virtual DbSet<MxmxdFumoInfo2> MxmxdFumoInfo2 { get; set; }
        public virtual DbSet<MxmxdQqQun> MxmxdQqQun { get; set; }
        public virtual DbSet<MxmxdQqSj> MxmxdQqSj { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Nxcodez> Nxcodez { get; set; }
        public virtual DbSet<Pets> Pets { get; set; }
        public virtual DbSet<PlayerQuests> PlayerQuests { get; set; }
        public virtual DbSet<PlayerVariables> PlayerVariables { get; set; }
        public virtual DbSet<Playernpcs> Playernpcs { get; set; }
        public virtual DbSet<PlayernpcsEquip> PlayernpcsEquip { get; set; }
        public virtual DbSet<Qqgm> Qqgm { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<Reactordrops> Reactordrops { get; set; }
        public virtual DbSet<Redenvelopes> Redenvelopes { get; set; }
        public virtual DbSet<Redenvelopeslog> Redenvelopeslog { get; set; }
        public virtual DbSet<Regrocklocations> Regrocklocations { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Rings> Rings { get; set; }
        public virtual DbSet<Savedlocations> Savedlocations { get; set; }
        public virtual DbSet<Shopitems> Shopitems { get; set; }
        public virtual DbSet<Shops> Shops { get; set; }
        public virtual DbSet<Skillmacros> Skillmacros { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillsPf> SkillsPf { get; set; }
        public virtual DbSet<Spawns> Spawns { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Stocklog> Stocklog { get; set; }
        public virtual DbSet<Stocktxet> Stocktxet { get; set; }
        public virtual DbSet<Storages> Storages { get; set; }
        public virtual DbSet<Topresults> Topresults { get; set; }
        public virtual DbSet<Trocklocations> Trocklocations { get; set; }
        public virtual DbSet<VipItemcount> VipItemcount { get; set; }
        public virtual DbSet<Visitnpc> Visitnpc { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<World> World { get; set; }
        public virtual DbSet<WzMxditemid> WzMxditemid { get; set; }
        public virtual DbSet<WzMxdskillid> WzMxdskillid { get; set; }
        public virtual DbSet<WzSpeedquiz> WzSpeedquiz { get; set; }
        public virtual DbSet<ZHair> ZHair { get; set; }
        public virtual DbSet<ZHeishi> ZHeishi { get; set; }
        public virtual DbSet<ZMobmnzc> ZMobmnzc { get; set; }
        public virtual DbSet<ZSonghuo> ZSonghuo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=zevms027;uid=root;pwd=zevms027;allowzerodatetime=True;convertzerodatetime=True", x => x.ServerVersion("5.7.16-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Banned).HasColumnName("banned");

                entity.Property(e => e.Banreason)
                    .HasColumnName("banreason")
                    .HasColumnType("text")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.CardNx)
                    .HasColumnName("cardNX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterslots)
                    .HasColumnName("characterslots")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Createdat)
                    .HasColumnName("createdat")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DonatorPoints).HasColumnName("donatorPoints");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("tinytext")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Fj)
                    .HasColumnName("fj")
                    .HasColumnType("bigint(255)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.Gm).HasColumnName("gm");

                entity.Property(e => e.Greason)
                    .HasColumnName("greason")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Guest).HasColumnName("guest");

                entity.Property(e => e.Hwid)
                    .IsRequired()
                    .HasColumnName("hwid")
                    .HasColumnType("varchar(12)")
                    .HasDefaultValueSql("'ACE2-32E7'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LastLoginInMilliseconds).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Lastknownip)
                    .HasColumnName("lastknownip")
                    .HasColumnType("tinytext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Lastpwemail)
                    .HasColumnName("lastpwemail")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'2002-12-31 17:00:00'");

                entity.Property(e => e.Loggedin)
                    .HasColumnName("loggedin")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Lv)
                    .HasColumnName("lv")
                    .HasColumnType("int(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MPoints)
                    .HasColumnName("mPoints")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Macs)
                    .HasColumnName("macs")
                    .HasColumnType("tinytext")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Mute)
                    .HasColumnName("mute")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(13)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nick)
                    .HasColumnName("nick")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PaypalNx)
                    .HasColumnName("paypalNX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Promoters)
                    .HasColumnName("promoters")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Promoterschongzhi)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Promoterschongzhilog)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rmb)
                    .HasColumnName("rmb")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SessionIp)
                    .HasColumnName("SessionIP")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sitelogged)
                    .HasColumnName("sitelogged")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sj)
                    .HasColumnName("sj")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Tempban)
                    .HasColumnName("tempban")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Tos)
                    .IsRequired()
                    .HasColumnName("tos")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VotePoints)
                    .HasColumnName("votePoints")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Webadmin)
                    .HasColumnName("webadmin")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AccountsJilu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accounts_jilu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jilu)
                    .IsRequired()
                    .HasColumnName("jilu")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AccountsXj>(entity =>
            {
                entity.ToTable("accounts_xj");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Xianjin)
                    .HasColumnName("xianjin")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Accountsrecharge>(entity =>
            {
                entity.ToTable("accountsrecharge");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.A)
                    .HasColumnName("a")
                    .HasColumnType("int(11)");

                entity.Property(e => e.B)
                    .HasColumnName("b")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.World).HasColumnType("int(11)");

                entity.Property(e => e.Xianjin)
                    .HasColumnName("xianjin")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Auctionitems>(entity =>
            {
                entity.ToTable("auctionitems");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Acc)
                    .HasColumnName("acc")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AuctionState).HasColumnName("auctionState");

                entity.Property(e => e.Avoid)
                    .HasColumnName("avoid")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Buyer)
                    .HasColumnName("buyer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BuyerName)
                    .HasColumnName("buyerName")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CharacterName)
                    .HasColumnName("characterName")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dex)
                    .HasColumnName("dex")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dzlevel)
                    .HasColumnName("dzlevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GmLog)
                    .HasColumnName("GM_Log")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hands)
                    .HasColumnName("hands")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Int)
                    .HasColumnName("_int")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inventorytype)
                    .HasColumnName("inventorytype")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jump)
                    .HasColumnName("jump")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Luk)
                    .HasColumnName("luk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Matk)
                    .HasColumnName("matk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mdef)
                    .HasColumnName("mdef")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mp)
                    .HasColumnName("mp")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Options2)
                    .HasColumnName("options2")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Shijian)
                    .HasColumnName("shijian")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Socket)
                    .HasColumnName("socket")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Socket2)
                    .HasColumnName("socket2")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Upgradeslots)
                    .HasColumnName("upgradeslots")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ViciousHammer)
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Watk)
                    .HasColumnName("watk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wdef)
                    .HasColumnName("wdef")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Auctionitems)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("auctionitems_ibfk_1");
            });

            modelBuilder.Entity<Auctionpoint>(entity =>
            {
                entity.HasKey(e => e.Characterid)
                    .HasName("PRIMARY");

                entity.ToTable("auctionpoint");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Selling)
                    .HasColumnName("selling")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.HasOne(d => d.Character)
                    .WithOne(p => p.Auctionpoint)
                    .HasForeignKey<Auctionpoint>(d => d.Characterid)
                    .HasConstraintName("auctionpoint_ibfk_1");
            });

            modelBuilder.Entity<Azjm>(entity =>
            {
                entity.ToTable("azjm");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.A)
                    .IsRequired()
                    .HasColumnName("a")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Jsid)
                    .HasColumnName("jsid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Bossloa>(entity =>
            {
                entity.ToTable("bossloa");

                entity.HasIndex(e => e.Accountid)
                    .HasName("characterid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bossid)
                    .IsRequired()
                    .HasColumnName("bossid")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Bossloa)
                    .HasForeignKey(d => d.Accountid)
                    .HasConstraintName("bossloa_ibfk_1");
            });

            modelBuilder.Entity<Bosslog>(entity =>
            {
                entity.ToTable("bosslog");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bossid)
                    .IsRequired()
                    .HasColumnName("bossid")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Bosslog)
                    .HasForeignKey(d => d.Characterid)
                    .HasConstraintName("bosslog_ibfk_1");
            });

            modelBuilder.Entity<Buddies>(entity =>
            {
                entity.ToTable("buddies");

                entity.HasIndex(e => e.Characterid)
                    .HasName("buddies_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Buddyid)
                    .HasColumnName("buddyid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pending)
                    .HasColumnName("pending")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Buddies)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("buddies_ibfk_1");
            });

            modelBuilder.Entity<Buddyentries>(entity =>
            {
                entity.ToTable("buddyentries");

                entity.HasIndex(e => e.Owner)
                    .HasName("owner");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Buddyid)
                    .HasColumnName("buddyid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Buddyentries)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("buddyentries_ibfk_1");
            });

            modelBuilder.Entity<Cashitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cashitems");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Onsale).HasColumnName("onsale");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("serialnumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sj)
                    .HasColumnName("sj")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Cashshopcouponitems>(entity =>
            {
                entity.ToTable("cashshopcouponitems");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ItemData)
                    .HasColumnName("itemData")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Used).HasColumnName("used");
            });

            modelBuilder.Entity<Cashshopcoupons>(entity =>
            {
                entity.ToTable("cashshopcoupons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Character)
                    .HasColumnName("character")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Used)
                    .HasColumnName("used")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Changemapspecial>(entity =>
            {
                entity.ToTable("changemapspecial");

                entity.HasIndex(e => e.Charactersid)
                    .HasName("charactersid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Charactersid)
                    .HasColumnName("charactersid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Characters)
                    .WithMany(p => p.Changemapspecial)
                    .HasForeignKey(d => d.Charactersid)
                    .HasConstraintName("changemapspecial_ibfk_1");
            });

            modelBuilder.Entity<Characters>(entity =>
            {
                entity.ToTable("characters");

                entity.HasIndex(e => e.Accountid)
                    .HasName("accountid");

                entity.HasIndex(e => e.Party)
                    .HasName("party");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aa)
                    .HasColumnName("aa")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllianceRank)
                    .HasColumnName("allianceRank")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Ap)
                    .HasColumnName("ap")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AriantPoints)
                    .HasColumnName("ariantPoints")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AutoHpPot)
                    .HasColumnName("autoHpPot")
                    .HasColumnType("mediumint(7)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AutoMpPot)
                    .HasColumnName("autoMpPot")
                    .HasColumnType("mediumint(7)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Banned)
                    .HasColumnName("banned")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Bb)
                    .HasColumnName("bb")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'500000'");

                entity.Property(e => e.Bosspoints)
                    .HasColumnName("bosspoints")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BuddyCapacity)
                    .HasColumnName("buddyCapacity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'199'");

                entity.Property(e => e.Combat)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DailyItemid)
                    .HasColumnName("daily_itemid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DailyNpcid)
                    .HasColumnName("daily_npcid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataString)
                    .HasColumnName("dataString")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Dd)
                    .HasColumnName("dd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3000'");

                entity.Property(e => e.Death)
                    .HasColumnName("death")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dex)
                    .HasColumnName("dex")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dianzhan)
                    .HasColumnName("dianzhan")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ee)
                    .HasColumnName("ee")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Equipslots)
                    .HasColumnName("equipslots")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Etcslots)
                    .HasColumnName("etcslots")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Exp)
                    .HasColumnName("exp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Face)
                    .HasColumnName("face")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fame)
                    .HasColumnName("fame")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ff)
                    .HasColumnName("ff")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.ForgingExp)
                    .HasColumnName("forgingExp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fumolevel)
                    .HasColumnName("fumolevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gm)
                    .HasColumnName("gm")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Guildid)
                    .HasColumnName("guildid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Guildrank)
                    .HasColumnName("guildrank")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HasMerchant)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HpApUsed)
                    .HasColumnName("hpApUsed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HpMpUsed)
                    .HasColumnName("hpMpUsed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Inte)
                    .HasColumnName("inte")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Integral)
                    .HasColumnName("integral")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Jiazu)
                    .HasColumnName("jiazu")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jiazulevel)
                    .HasColumnName("jiazulevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JobRank)
                    .HasColumnName("jobRank")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.JobRankMove)
                    .HasColumnName("jobRankMove")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.KillMonster)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Luk)
                    .HasColumnName("luk")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Marriagequest)
                    .HasColumnName("marriagequest")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Married)
                    .HasColumnName("married")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Master)
                    .HasColumnName("master")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Matchcard)
                    .HasColumnName("matchcard")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Matchcardlosses)
                    .HasColumnName("matchcardlosses")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Matchcardties)
                    .HasColumnName("matchcardties")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Matchcardwins)
                    .HasColumnName("matchcardwins")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Maxhp)
                    .HasColumnName("maxhp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxlevel)
                    .HasColumnName("maxlevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Maxmp)
                    .HasColumnName("maxmp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.MerchantMesos)
                    .HasColumnName("merchantMesos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Meso)
                    .HasColumnName("meso")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mountexp)
                    .HasColumnName("mountexp")
                    .HasColumnType("int(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mountlevel)
                    .HasColumnName("mountlevel")
                    .HasColumnType("int(9)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Mounttiredness)
                    .HasColumnName("mounttiredness")
                    .HasColumnType("int(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mp)
                    .HasColumnName("mp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.MpApUsed)
                    .HasColumnName("mpApUsed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(19)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Omok)
                    .HasColumnName("omok")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Omoklosses)
                    .HasColumnName("omoklosses")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Omokties)
                    .HasColumnName("omokties")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Omokwins)
                    .HasColumnName("omokwins")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Paodiandianquan)
                    .HasColumnName("paodiandianquan")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Paodianexp)
                    .HasColumnName("paodianexp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Paodianjinbi)
                    .HasColumnName("paodianjinbi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Partnerid)
                    .HasColumnName("partnerid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pdexp)
                    .HasColumnName("pdexp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pets)
                    .HasColumnName("pets")
                    .HasColumnType("varchar(13)")
                    .HasDefaultValueSql("'-1,-1,-1'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Playtime)
                    .HasColumnName("playtime")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Prestige)
                    .HasColumnName("prestige")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RankMove)
                    .HasColumnName("rankMove")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecoveryHp)
                    .HasColumnName("RecoveryHP")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecoveryHpitemid)
                    .HasColumnName("RecoveryHPitemid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecoveryMp)
                    .HasColumnName("RecoveryMP")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecoveryMpitemid)
                    .HasColumnName("RecoveryMPitemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Setupslots)
                    .HasColumnName("setupslots")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Signin)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Signinreward)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Skincolor)
                    .HasColumnName("skincolor")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sp)
                    .HasColumnName("sp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spawnpoint)
                    .HasColumnName("spawnpoint")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpouseId)
                    .HasColumnName("spouseId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SwitchBufftime)
                    .HasColumnName("switch_bufftime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SwitchDuanzao)
                    .HasColumnName("switch_duanzao")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SwitchQunltkx)
                    .HasColumnName("switch_qunltkx")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SwitchSkill)
                    .HasColumnName("switch_skill")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SwitchZhubosx)
                    .HasColumnName("switch_zhubosx")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tianti)
                    .HasColumnName("tianti")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TodayOnlineTime)
                    .HasColumnName("todayOnlineTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalOnlineTime)
                    .HasColumnName("totalOnlineTime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalOnlineTimett)
                    .HasColumnName("totalOnlineTimett")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Useslots)
                    .HasColumnName("useslots")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'24'");

                entity.Property(e => e.Vip)
                    .HasColumnName("vip")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Viptime)
                    .HasColumnName("viptime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VotePoints)
                    .HasColumnName("votePoints")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.World2)
                    .HasColumnName("world2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zhubo)
                    .HasColumnName("zhubo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zhujiemian)
                    .HasColumnName("zhujiemian")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CharactersJilu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("characters_jilu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jilu)
                    .IsRequired()
                    .HasColumnName("jilu")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CharactersKmob>(entity =>
            {
                entity.ToTable("characters_kmob");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mobshuliang)
                    .HasColumnName("mobshuliang")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CharactersKmob)
                    .HasForeignKey<CharactersKmob>(d => d.Id)
                    .HasConstraintName("characters_kmob_ibfk_1");
            });

            modelBuilder.Entity<Charactersforging>(entity =>
            {
                entity.ToTable("charactersforging");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ForgingExp)
                    .HasColumnName("forgingExp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Charactersforging)
                    .HasForeignKey<Charactersforging>(d => d.Id)
                    .HasConstraintName("charactersforging_ibfk_1");
            });

            modelBuilder.Entity<Charactersin>(entity =>
            {
                entity.ToTable("charactersin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cailiao)
                    .HasColumnName("cailiao")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dianquan)
                    .HasColumnName("dianquan")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dianquan2)
                    .HasColumnName("dianquan2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dkbck)
                    .HasColumnName("dkbck")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Feiqi)
                    .HasColumnName("feiqi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fmdxk)
                    .HasColumnName("fmdxk")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gaojifuhuo)
                    .HasColumnName("gaojifuhuo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Hjfx)
                    .HasColumnName("hjfx")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jueseshuliang)
                    .HasColumnName("jueseshuliang")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Meso)
                    .HasColumnName("meso")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Meso2)
                    .HasColumnName("meso2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Meso3)
                    .HasColumnName("meso3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Meso4)
                    .HasColumnName("meso4")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg10000)
                    .HasColumnName("pg10000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg100000)
                    .HasColumnName("pg100000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg1000000)
                    .HasColumnName("pg1000000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg50000)
                    .HasColumnName("pg50000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg500000)
                    .HasColumnName("pg500000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pg5000000)
                    .HasColumnName("pg5000000")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Putongfuhuo)
                    .HasColumnName("putongfuhuo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tplevel)
                    .HasColumnName("tplevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wnk)
                    .HasColumnName("wnk")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zhakun)
                    .HasColumnName("zhakun")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zs499)
                    .HasColumnName("zs499")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zs99)
                    .HasColumnName("zs99")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Zs999)
                    .HasColumnName("zs999")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Charactersin)
                    .HasForeignKey<Charactersin>(d => d.Id)
                    .HasConstraintName("charactersin_ibfk_1");
            });

            modelBuilder.Entity<Charactersiy>(entity =>
            {
                entity.ToTable("charactersiy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Feiqifubentongguan1)
                    .HasColumnName("feiqifubentongguan1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Charactersiy)
                    .HasForeignKey<Charactersiy>(d => d.Id)
                    .HasConstraintName("charactersiy_ibfk_1");
            });

            modelBuilder.Entity<Characterslots>(entity =>
            {
                entity.ToTable("characterslots");

                entity.HasIndex(e => e.AccountId)
                    .HasName("accountId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Slots)
                    .HasColumnName("slots")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CharacterslotsNavigation)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("characterslots_ibfk_1");
            });

            modelBuilder.Entity<Cheatlog>(entity =>
            {
                entity.ToTable("cheatlog");

                entity.HasIndex(e => e.Characterid)
                    .HasName("cid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lastoffensetime)
                    .HasColumnName("lastoffensetime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Offense)
                    .IsRequired()
                    .HasColumnName("offense")
                    .HasColumnType("tinytext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Param)
                    .IsRequired()
                    .HasColumnName("param")
                    .HasColumnType("tinytext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Cheatlog)
                    .HasForeignKey(d => d.Characterid)
                    .HasConstraintName("cheatlog_ibfk_1");
            });

            modelBuilder.Entity<Completpqs>(entity =>
            {
                entity.ToTable("completpqs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmoriaPq)
                    .HasColumnName("amoriaPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GuildPq)
                    .HasColumnName("guildPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HenesysPq)
                    .HasColumnName("henesysPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HorntailPq)
                    .HasColumnName("horntailPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.KerningPq)
                    .HasColumnName("kerningPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LudibriumPq)
                    .HasColumnName("ludibriumPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrbisPq)
                    .HasColumnName("orbisPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PiratePq)
                    .HasColumnName("piratePQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ZakumPq)
                    .HasColumnName("zakumPQ")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Configvalues>(entity =>
            {
                entity.ToTable("configvalues");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Val).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Consumption>(entity =>
            {
                entity.ToTable("consumption");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accountsid)
                    .HasColumnName("accountsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Charactersid)
                    .HasColumnName("charactersid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Day)
                    .HasColumnName("day")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nx)
                    .HasColumnName("NX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qq)
                    .IsRequired()
                    .HasColumnName("qq")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DlqIllegalRecords>(entity =>
            {
                entity.ToTable("dlq_illegal_records");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duetime)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IllegalFrequency)
                    .HasColumnName("illegal_frequency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Machine)
                    .HasColumnName("machine")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dlqvip>(entity =>
            {
                entity.ToTable("dlqvip");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duetime)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idid2)
                    .HasColumnName("idid2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Machine)
                    .HasColumnName("machine")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Number)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Openquantity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'VIP'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DropData>(entity =>
            {
                entity.ToTable("drop_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dropperid)
                    .HasColumnName("dropperid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaximumQuantity)
                    .HasColumnName("maximum_quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinimumQuantity)
                    .HasColumnName("minimum_quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Questid)
                    .HasColumnName("questid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DropDataGlobal>(entity =>
            {
                entity.ToTable("drop_data_global");

                entity.HasIndex(e => e.Continent)
                    .HasName("mobid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Continent)
                    .HasColumnName("continent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DropType).HasColumnName("dropType");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaximumQuantity)
                    .HasColumnName("maximum_quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinimumQuantity)
                    .HasColumnName("minimum_quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Questid)
                    .HasColumnName("questid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Event)
                    .HasColumnName("event")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Minute)
                    .HasColumnName("minute")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Week)
                    .HasColumnName("week")
                    .HasColumnType("int(11)");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Famelog>(entity =>
            {
                entity.ToTable("famelog");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Famelogid)
                    .HasColumnName("famelogid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CharacteridTo)
                    .HasColumnName("characterid_to")
                    .HasColumnType("int(11)");

                entity.Property(e => e.When)
                    .HasColumnName("when")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Famelog)
                    .HasForeignKey(d => d.Characterid)
                    .HasConstraintName("famelog_ibfk_1");
            });

            modelBuilder.Entity<Fullpoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fullpoint");

                entity.Property(e => e.Leixing)
                    .HasColumnName("leixing")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Point).HasColumnType("int(32)");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(128)");
            });

            modelBuilder.Entity<Gifts>(entity =>
            {
                entity.ToTable("gifts");

                entity.HasIndex(e => e.To)
                    .HasName("to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("tinytext")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.To)
                    .HasColumnName("to")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("int(10)");

                entity.HasOne(d => d.ToNavigation)
                    .WithMany(p => p.Gifts)
                    .HasForeignKey(d => d.To)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("gifts_ibfk_1");
            });

            modelBuilder.Entity<Global>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("global");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(128)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Point).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Gmlog>(entity =>
            {
                entity.ToTable("gmlog");

                entity.Property(e => e.Gmlogid)
                    .HasColumnName("gmlogid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Command)
                    .IsRequired()
                    .HasColumnName("command")
                    .HasColumnType("text")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Hwidbans>(entity =>
            {
                entity.HasKey(e => e.Hwidbanid)
                    .HasName("PRIMARY");

                entity.ToTable("hwidbans");

                entity.HasIndex(e => e.Hwid)
                    .HasName("hwid_2")
                    .IsUnique();

                entity.Property(e => e.Hwidbanid)
                    .HasColumnName("hwidbanid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Hwid)
                    .IsRequired()
                    .HasColumnName("hwid")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Inventoryequipment>(entity =>
            {
                entity.HasKey(e => e.Inventoryitemid)
                    .HasName("PRIMARY");

                entity.ToTable("inventoryequipment");

                entity.HasIndex(e => e.Accountid)
                    .HasName("trunkid");

                entity.HasIndex(e => e.Characterid)
                    .HasName("charid");

                entity.Property(e => e.Inventoryitemid)
                    .HasColumnName("inventoryitemid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Acc)
                    .HasColumnName("acc")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Avoid)
                    .HasColumnName("avoid")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dex)
                    .HasColumnName("dex")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dzlevel)
                    .HasColumnName("dzlevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Giftfrom)
                    .HasColumnName("giftfrom")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Hands)
                    .HasColumnName("hands")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Hp)
                    .HasColumnName("hp")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inte)
                    .HasColumnName("inte")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Inventorytype).HasColumnName("inventorytype");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jump)
                    .HasColumnName("jump")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Luk)
                    .HasColumnName("luk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Matk)
                    .HasColumnName("matk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mdef)
                    .HasColumnName("mdef")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mp)
                    .HasColumnName("mp")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Options2)
                    .HasColumnName("options2")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Socket)
                    .HasColumnName("socket")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Socket2)
                    .HasColumnName("socket2")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Str)
                    .HasColumnName("str")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Upgradeslots)
                    .HasColumnName("upgradeslots")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Watk)
                    .HasColumnName("watk")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Wdef)
                    .HasColumnName("wdef")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Inventoryitems>(entity =>
            {
                entity.HasKey(e => e.Inventoryitemid)
                    .HasName("PRIMARY");

                entity.ToTable("inventoryitems");

                entity.HasIndex(e => e.Accountid)
                    .HasName("accountid");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.HasIndex(e => e.Inventorytype)
                    .HasName("inventorytype");

                entity.HasIndex(e => e.Uniqueid)
                    .HasName("uniqueid");

                entity.Property(e => e.Inventoryitemid)
                    .HasColumnName("inventoryitemid")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Giftfrom)
                    .HasColumnName("giftfrom")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Inventorytype)
                    .HasColumnName("inventorytype")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<Ipbans>(entity =>
            {
                entity.HasKey(e => e.Ipbanid)
                    .HasName("PRIMARY");

                entity.ToTable("ipbans");

                entity.Property(e => e.Ipbanid)
                    .HasColumnName("ipbanid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Iplog>(entity =>
            {
                entity.ToTable("iplog");

                entity.HasIndex(e => e.Ip)
                    .HasName("ip");

                entity.HasIndex(e => new { e.Accountid, e.Ip })
                    .HasName("accountid");

                entity.Property(e => e.Iplogid)
                    .HasColumnName("iplogid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Iplog)
                    .HasForeignKey(d => d.Accountid)
                    .HasConstraintName("iplog_ibfk_1");
            });

            modelBuilder.Entity<Jiance>(entity =>
            {
                entity.ToTable("jiance");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X1)
                    .HasColumnName("x1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X2)
                    .HasColumnName("x2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.X3)
                    .HasColumnName("x3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Y1)
                    .HasColumnName("y1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Y2)
                    .HasColumnName("y2")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Y3)
                    .HasColumnName("y3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Jiazu>(entity =>
            {
                entity.ToTable("jiazu");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gonggao)
                    .HasColumnName("gonggao")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Jiazugp)
                    .HasColumnName("jiazugp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jiazuid)
                    .HasColumnName("jiazuid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jiazujingyan)
                    .HasColumnName("jiazujingyan")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jiazuname)
                    .HasColumnName("jiazuname")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Jiazurenshu)
                    .HasColumnName("jiazurenshu")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Jiazuworld)
                    .HasColumnName("jiazuworld")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Keymap>(entity =>
            {
                entity.ToTable("keymap");

                entity.HasIndex(e => e.Characterid)
                    .HasName("keymap_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Keymap)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("keymap_ibfk_1");
            });

            modelBuilder.Entity<Levelhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("levelhistory");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("bigint(255)");
            });

            modelBuilder.Entity<Macbans>(entity =>
            {
                entity.HasKey(e => e.Macbanid)
                    .HasName("PRIMARY");

                entity.ToTable("macbans");

                entity.HasIndex(e => e.Mac)
                    .HasName("mac_2")
                    .IsUnique();

                entity.Property(e => e.Macbanid)
                    .HasColumnName("macbanid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mac)
                    .IsRequired()
                    .HasColumnName("mac")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Macfilters>(entity =>
            {
                entity.HasKey(e => e.Macfilterid)
                    .HasName("PRIMARY");

                entity.ToTable("macfilters");

                entity.Property(e => e.Macfilterid)
                    .HasColumnName("macfilterid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Filter)
                    .IsRequired()
                    .HasColumnName("filter")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Mainpage>(entity =>
            {
                entity.ToTable("mainpage");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Caidan)
                    .HasColumnName("caidan")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mainpageid)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Mountdata>(entity =>
            {
                entity.ToTable("mountdata");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Exp).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Fatigue).HasColumnType("int(3) unsigned");

                entity.Property(e => e.Level).HasColumnType("int(3) unsigned");
            });

            modelBuilder.Entity<MxmxdChenghao>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PRIMARY");

                entity.ToTable("mxmxd_chenghao");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.Huoqu)
                    .HasColumnName("huoqu")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xiaoguo)
                    .HasColumnName("xiaoguo")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");
            });

            modelBuilder.Entity<MxmxdFumoInfo>(entity =>
            {
                entity.HasKey(e => e.FumoType)
                    .HasName("PRIMARY");

                entity.ToTable("mxmxd_fumo_info");

                entity.Property(e => e.FumoType)
                    .HasColumnName("fumoType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FumoInfo)
                    .HasColumnName("fumoInfo")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FumoName)
                    .HasColumnName("fumoName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MxmxdFumoInfo2>(entity =>
            {
                entity.HasKey(e => e.FumoType)
                    .HasName("PRIMARY");

                entity.ToTable("mxmxd_fumo_info2");

                entity.Property(e => e.FumoType)
                    .HasColumnName("fumoType")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FumoInfo)
                    .HasColumnName("fumoInfo")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FumoName)
                    .HasColumnName("fumoName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MxmxdQqQun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mxmxd_qq_qun");

                entity.Property(e => e.Gm)
                    .IsRequired()
                    .HasColumnName("gm")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QqGun)
                    .IsRequired()
                    .HasColumnName("qqGun")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MxmxdQqSj>(entity =>
            {
                entity.HasKey(e => e.Qq)
                    .HasName("PRIMARY");

                entity.ToTable("mxmxd_qq_sj");

                entity.Property(e => e.Qq)
                    .HasColumnName("qq")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Banned)
                    .HasColumnName("banned")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sj)
                    .HasColumnName("sj")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("notes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fame).HasColumnName("fame");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasColumnName("from")
                    .HasColumnType("varchar(13)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasColumnName("to")
                    .HasColumnType("varchar(13)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Nxcodez>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PRIMARY");

                entity.ToTable("nxcodez");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(322)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Leixing)
                    .HasColumnName("leixing")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Pets>(entity =>
            {
                entity.HasKey(e => e.Petid)
                    .HasName("PRIMARY");

                entity.ToTable("pets");

                entity.HasIndex(e => e.Petid)
                    .HasName("petid");

                entity.Property(e => e.Petid)
                    .HasColumnName("petid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Closeness)
                    .HasColumnName("closeness")
                    .HasColumnType("int(6) unsigned");

                entity.Property(e => e.Excluded)
                    .HasColumnName("excluded")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Fullness)
                    .HasColumnName("fullness")
                    .HasColumnType("int(3) unsigned");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(3) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(19)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Seconds)
                    .HasColumnName("seconds")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayerQuests>(entity =>
            {
                entity.ToTable("player_quests");

                entity.HasIndex(e => e.Charid)
                    .HasName("charid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Charid)
                    .HasColumnName("charid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Questid)
                    .HasColumnName("questid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Char)
                    .WithMany(p => p.PlayerQuests)
                    .HasForeignKey(d => d.Charid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("player_quests_ibfk_1");
            });

            modelBuilder.Entity<PlayerVariables>(entity =>
            {
                entity.ToTable("player_variables");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(10000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.PlayerVariables)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("player_variables_ibfk_1");
            });

            modelBuilder.Entity<Playernpcs>(entity =>
            {
                entity.ToTable("playernpcs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cy)
                    .HasColumnName("cy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dir)
                    .HasColumnName("dir")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Face)
                    .HasColumnName("face")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Foothold).HasColumnType("int(11)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rx0)
                    .HasColumnName("rx0")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rx1)
                    .HasColumnName("rx1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScriptId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Skin)
                    .HasColumnName("skin")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Y)
                    .HasColumnName("y")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlayernpcsEquip>(entity =>
            {
                entity.ToTable("playernpcs_equip");

                entity.HasIndex(e => e.Npcid)
                    .HasName("FK_playernpcs_equip_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Equipid)
                    .HasColumnName("equipid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Equippos)
                    .HasColumnName("equippos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Npcid)
                    .HasColumnName("npcid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Npc)
                    .WithMany(p => p.PlayernpcsEquip)
                    .HasForeignKey(d => d.Npcid)
                    .HasConstraintName("playernpcs_equip_ibfk_1");
            });

            modelBuilder.Entity<Qqgm>(entity =>
            {
                entity.ToTable("qqgm");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.ToTable("quests");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.A)
                    .IsRequired()
                    .HasColumnName("a")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Jsid)
                    .HasColumnName("jsid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.T)
                    .HasColumnName("t")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Reactordrops>(entity =>
            {
                entity.HasKey(e => e.Reactordropid)
                    .HasName("PRIMARY");

                entity.ToTable("reactordrops");

                entity.HasIndex(e => e.Reactorid)
                    .HasName("reactorid");

                entity.Property(e => e.Reactordropid)
                    .HasColumnName("reactordropid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Questid)
                    .HasColumnName("questid")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Reactorid)
                    .HasColumnName("reactorid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Redenvelopes>(entity =>
            {
                entity.ToTable("redenvelopes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.A)
                    .HasColumnName("a")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Leixing1)
                    .HasColumnName("leixing1")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Leixing2)
                    .HasColumnName("leixing2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shuliang)
                    .HasColumnName("shuliang")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tiem)
                    .HasColumnName("tiem")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Txet)
                    .HasColumnName("txet")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'恭喜发财'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Redenvelopeslog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("redenvelopeslog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jilu)
                    .IsRequired()
                    .HasColumnName("jilu")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Regrocklocations>(entity =>
            {
                entity.HasKey(e => e.Trockid)
                    .HasName("PRIMARY");

                entity.ToTable("regrocklocations");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Trockid)
                    .HasColumnName("trockid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Regrocklocations)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("regrocklocations_ibfk_1");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.ToTable("reports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Chatlog)
                    .IsRequired()
                    .HasColumnName("chatlog")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Reporterid)
                    .HasColumnName("reporterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reporttime)
                    .HasColumnName("reporttime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Victimid)
                    .HasColumnName("victimid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Rings>(entity =>
            {
                entity.ToTable("rings");

                entity.HasIndex(e => e.Id)
                    .HasName("id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartnerChrId)
                    .HasColumnName("partnerChrId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartnerRingId)
                    .HasColumnName("partnerRingId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Partnername)
                    .IsRequired()
                    .HasColumnName("partnername")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");
            });

            modelBuilder.Entity<Savedlocations>(entity =>
            {
                entity.ToTable("savedlocations");

                entity.HasIndex(e => e.Characterid)
                    .HasName("savedlocations_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Locationtype)
                    .IsRequired()
                    .HasColumnName("locationtype")
                    .HasColumnType("enum('FREE_MARKET','WORLDTOUR','FLORINA','MONSTER_CARNIVAL','ARIANT_PQ','EVENTO','BALROGPQ','RICHIE','RANDOM_EVENT')")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Savedlocations)
                    .HasForeignKey(d => d.Characterid)
                    .HasConstraintName("savedlocations_ibfk_1");
            });

            modelBuilder.Entity<Shopitems>(entity =>
            {
                entity.HasKey(e => e.Shopitemid)
                    .HasName("PRIMARY");

                entity.ToTable("shopitems");

                entity.Property(e => e.Shopitemid)
                    .HasColumnName("shopitemid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pitch)
                    .HasColumnName("pitch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)")
                    .HasComment("sort is an arbitrary field designed to give leeway when modifying shops. The lowest number is 104 and it increments by 4 for each item to allow decent space for swapping/inserting/removing items.");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reqitem)
                    .HasColumnName("reqitem")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reqitemq)
                    .HasColumnName("reqitemq")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'26'");
            });

            modelBuilder.Entity<Shops>(entity =>
            {
                entity.HasKey(e => e.Shopid)
                    .HasName("PRIMARY");

                entity.ToTable("shops");

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Beizhu)
                    .HasColumnName("beizhu")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Npcid)
                    .HasColumnName("npcid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Skillmacros>(entity =>
            {
                entity.HasKey(e => e.Entryid)
                    .HasName("PRIMARY");

                entity.ToTable("skillmacros");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Silent).HasColumnName("silent");

                entity.Property(e => e.Skill1)
                    .HasColumnName("skill1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Skill2)
                    .HasColumnName("skill2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Skill3)
                    .HasColumnName("skill3")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Skillmacros)
                    .HasForeignKey(d => d.Characterid)
                    .HasConstraintName("skillmacros_ibfk_1");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.ToTable("skills");

                entity.HasIndex(e => e.Characterid)
                    .HasName("skills_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Masterlevel)
                    .HasColumnName("masterlevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Skillid)
                    .HasColumnName("skillid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Skilllevel)
                    .HasColumnName("skilllevel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("skills_ibfk_1");
            });

            modelBuilder.Entity<SkillsPf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("skills_pf");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Skillspf1)
                    .HasColumnName("skillspf")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Spawns>(entity =>
            {
                entity.ToTable("spawns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cy)
                    .HasColumnName("cy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.F)
                    .HasColumnName("f")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fh)
                    .HasColumnName("fh")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idd)
                    .HasColumnName("idd")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mobtime)
                    .HasColumnName("mobtime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.Rx0)
                    .HasColumnName("rx0")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rx1)
                    .HasColumnName("rx1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Y)
                    .HasColumnName("y")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("stock");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.B)
                    .IsRequired()
                    .HasColumnName("b")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.D)
                    .HasColumnName("d")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Stocklog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stocklog");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Shuliang)
                    .HasColumnName("shuliang")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Stocktxet>(entity =>
            {
                entity.ToTable("stocktxet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.A)
                    .HasColumnName("a")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.B)
                    .HasColumnName("b")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Shijian)
                    .HasColumnName("shijian")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Storages>(entity =>
            {
                entity.HasKey(e => e.Storageid)
                    .HasName("PRIMARY");

                entity.ToTable("storages");

                entity.HasIndex(e => e.Accountid)
                    .HasName("accountid");

                entity.Property(e => e.Storageid)
                    .HasColumnName("storageid")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Meso)
                    .HasColumnName("meso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Slots)
                    .HasColumnName("slots")
                    .HasColumnType("int(11)");

                entity.Property(e => e.World).HasColumnName("world");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Storages)
                    .HasForeignKey(d => d.Accountid)
                    .HasConstraintName("storages_ibfk_1");
            });

            modelBuilder.Entity<Topresults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("topresults");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Trocklocations>(entity =>
            {
                entity.HasKey(e => e.Trockid)
                    .HasName("PRIMARY");

                entity.ToTable("trocklocations");

                entity.HasIndex(e => e.Characterid)
                    .HasName("characterid");

                entity.Property(e => e.Trockid)
                    .HasColumnName("trockid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mapid)
                    .HasColumnName("mapid")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Trocklocations)
                    .HasForeignKey(d => d.Characterid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("trocklocations_ibfk_1");
            });

            modelBuilder.Entity<VipItemcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vip_itemcount");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jilu)
                    .IsRequired()
                    .HasColumnName("jilu")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Visitnpc>(entity =>
            {
                entity.ToTable("visitnpc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characterid)
                    .HasColumnName("characterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Npcid)
                    .HasColumnName("npcid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Npcname)
                    .HasColumnName("npcname")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Visitcout)
                    .HasColumnName("visitcout")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouse");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accountid)
                    .HasColumnName("accountid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cout)
                    .HasColumnName("cout")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("bigint(255)");

                entity.Property(e => e.World)
                    .HasColumnName("world")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<World>(entity =>
            {
                entity.ToTable("world");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bl)
                    .HasColumnName("bl")
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'100'");
            });

            modelBuilder.Entity<WzMxditemid>(entity =>
            {
                entity.ToTable("wz_mxditemid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");
            });

            modelBuilder.Entity<WzMxdskillid>(entity =>
            {
                entity.ToTable("wz_mxdskillid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jobid)
                    .HasColumnName("jobid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("gbk")
                    .HasCollation("gbk_chinese_ci");

                entity.Property(e => e.Skillid)
                    .HasColumnName("skillid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WzSpeedquiz>(entity =>
            {
                entity.HasKey(e => e.QuizDataId)
                    .HasName("PRIMARY");

                entity.ToTable("wz_speedquiz");

                entity.Property(e => e.QuizDataId)
                    .HasColumnName("quizDataId")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("answer")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Objectid)
                    .HasColumnName("objectid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuestionNo)
                    .HasColumnName("questionNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ZHair>(entity =>
            {
                entity.ToTable("z_hair");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasColumnType("int(11)");

                entity.Property(e => e.D)
                    .HasColumnName("d")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jsid)
                    .HasColumnName("jsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shijian)
                    .HasColumnName("shijian")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Xjq)
                    .HasColumnName("xjq")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ZHeishi>(entity =>
            {
                entity.ToTable("z_heishi");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.J)
                    .HasColumnName("j")
                    .HasColumnType("int(11)");

                entity.Property(e => e.S)
                    .HasColumnName("s")
                    .HasColumnType("int(11)");

                entity.Property(e => e.W)
                    .HasColumnName("w")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ZMobmnzc>(entity =>
            {
                entity.ToTable("z_mobmnzc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jsid)
                    .HasColumnName("jsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mobid)
                    .HasColumnName("mobid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Y)
                    .HasColumnName("y")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ZSonghuo>(entity =>
            {
                entity.ToTable("z_songhuo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jsid)
                    .HasColumnName("jsid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.S)
                    .HasColumnName("s")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.W)
                    .HasColumnName("w")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
