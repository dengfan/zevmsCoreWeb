using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Characters
    {
        public Characters()
        {
            Auctionitems = new HashSet<Auctionitems>();
            Bossloa = new HashSet<Bossloa>();
            Bosslog = new HashSet<Bosslog>();
            Buddies = new HashSet<Buddies>();
            Buddyentries = new HashSet<Buddyentries>();
            Changemapspecial = new HashSet<Changemapspecial>();
            Cheatlog = new HashSet<Cheatlog>();
            Famelog = new HashSet<Famelog>();
            Gifts = new HashSet<Gifts>();
            Keymap = new HashSet<Keymap>();
            PlayerQuests = new HashSet<PlayerQuests>();
            PlayerVariables = new HashSet<PlayerVariables>();
            Regrocklocations = new HashSet<Regrocklocations>();
            Savedlocations = new HashSet<Savedlocations>();
            Skillmacros = new HashSet<Skillmacros>();
            Skills = new HashSet<Skills>();
            Trocklocations = new HashSet<Trocklocations>();
        }

        public int Id { get; set; }
        public int? Accountid { get; set; }
        public int? World { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public int? Exp { get; set; }
        public int? Str { get; set; }
        public int? Dex { get; set; }
        public int? Luk { get; set; }
        public int? Inte { get; set; }
        public int? Hp { get; set; }
        public int? Mp { get; set; }
        public int? Maxhp { get; set; }
        public int? Maxmp { get; set; }
        public int? Meso { get; set; }
        public int? HpApUsed { get; set; }
        public int? MpApUsed { get; set; }
        public int? Job { get; set; }
        public int? Skincolor { get; set; }
        public int? Gender { get; set; }
        public int? Fame { get; set; }
        public int? Hair { get; set; }
        public int? Face { get; set; }
        public int? Ap { get; set; }
        public int? Sp { get; set; }
        public int? Map { get; set; }
        public int? Spawnpoint { get; set; }
        public int? Gm { get; set; }
        public int? Party { get; set; }
        public int? BuddyCapacity { get; set; }
        public int? AutoHpPot { get; set; }
        public int? AutoMpPot { get; set; }
        public DateTime? Createdate { get; set; }
        public uint? Rank { get; set; }
        public int? RankMove { get; set; }
        public uint? JobRank { get; set; }
        public int? JobRankMove { get; set; }
        public uint? Guildid { get; set; }
        public uint? Guildrank { get; set; }
        public uint? AllianceRank { get; set; }
        public int? Mountlevel { get; set; }
        public int? Mountexp { get; set; }
        public int? Mounttiredness { get; set; }
        public uint? Married { get; set; }
        public uint? Partnerid { get; set; }
        public uint? Marriagequest { get; set; }
        public int? Omok { get; set; }
        public int? Matchcard { get; set; }
        public int? Omokwins { get; set; }
        public int? Omoklosses { get; set; }
        public int? Omokties { get; set; }
        public int? Matchcardwins { get; set; }
        public int? Matchcardlosses { get; set; }
        public int? Matchcardties { get; set; }
        public int? MerchantMesos { get; set; }
        public byte? HasMerchant { get; set; }
        public int? Equipslots { get; set; }
        public int? Useslots { get; set; }
        public int? Setupslots { get; set; }
        public int? Etcslots { get; set; }
        public int? Bosspoints { get; set; }
        public int? AriantPoints { get; set; }
        public int? VotePoints { get; set; }
        public int? HpMpUsed { get; set; }
        public string Pets { get; set; }
        public long? Playtime { get; set; }
        public int? SpouseId { get; set; }
        public string DataString { get; set; }
        public int? TodayOnlineTime { get; set; }
        public int? TotalOnlineTime { get; set; }
        public int? Vip { get; set; }
        public int? Viptime { get; set; }
        public int? Jiazu { get; set; }
        public int? Jiazulevel { get; set; }
        public int? Dianzhan { get; set; }
        public int? World2 { get; set; }
        public int? Death { get; set; }
        public int? Combat { get; set; }
        public int? KillMonster { get; set; }
        public int? RecoveryHp { get; set; }
        public int? RecoveryHpitemid { get; set; }
        public int? RecoveryMp { get; set; }
        public int? RecoveryMpitemid { get; set; }
        public int? Signin { get; set; }
        public int? Signinreward { get; set; }
        public int? Paodianjinbi { get; set; }
        public int? Paodiandianquan { get; set; }
        public int? Paodianexp { get; set; }
        public int? Maxlevel { get; set; }
        public int? Banned { get; set; }
        public int? Pdexp { get; set; }
        public int? ForgingExp { get; set; }
        public int? DailyItemid { get; set; }
        public int? DailyNpcid { get; set; }
        public int? Integral { get; set; }
        public int? TotalOnlineTimett { get; set; }
        public int? Tianti { get; set; }
        public int? Zhubo { get; set; }
        public int? Mapid { get; set; }
        public int? Master { get; set; }
        public int? Prestige { get; set; }
        public int? Zhujiemian { get; set; }
        public int? SwitchBufftime { get; set; }
        public int? SwitchZhubosx { get; set; }
        public int? SwitchQunltkx { get; set; }
        public int? SwitchDuanzao { get; set; }
        public int? SwitchSkill { get; set; }
        public int? Fumolevel { get; set; }
        public int? Aa { get; set; }
        public int? Bb { get; set; }
        public int? Cc { get; set; }
        public int? Dd { get; set; }
        public int? Ee { get; set; }
        public int? Ff { get; set; }

        public virtual Auctionpoint Auctionpoint { get; set; }
        public virtual CharactersKmob CharactersKmob { get; set; }
        public virtual Charactersforging Charactersforging { get; set; }
        public virtual Charactersin Charactersin { get; set; }
        public virtual Charactersiy Charactersiy { get; set; }
        public virtual ICollection<Auctionitems> Auctionitems { get; set; }
        public virtual ICollection<Bossloa> Bossloa { get; set; }
        public virtual ICollection<Bosslog> Bosslog { get; set; }
        public virtual ICollection<Buddies> Buddies { get; set; }
        public virtual ICollection<Buddyentries> Buddyentries { get; set; }
        public virtual ICollection<Changemapspecial> Changemapspecial { get; set; }
        public virtual ICollection<Cheatlog> Cheatlog { get; set; }
        public virtual ICollection<Famelog> Famelog { get; set; }
        public virtual ICollection<Gifts> Gifts { get; set; }
        public virtual ICollection<Keymap> Keymap { get; set; }
        public virtual ICollection<PlayerQuests> PlayerQuests { get; set; }
        public virtual ICollection<PlayerVariables> PlayerVariables { get; set; }
        public virtual ICollection<Regrocklocations> Regrocklocations { get; set; }
        public virtual ICollection<Savedlocations> Savedlocations { get; set; }
        public virtual ICollection<Skillmacros> Skillmacros { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<Trocklocations> Trocklocations { get; set; }
    }
}
