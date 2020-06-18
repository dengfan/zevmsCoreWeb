using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Accounts
    {
        public Accounts()
        {
            CharacterslotsNavigation = new HashSet<Characterslots>();
            Iplog = new HashSet<Iplog>();
            Storages = new HashSet<Storages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Pin { get; set; }
        public sbyte Loggedin { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime Createdat { get; set; }
        public DateTime Birthday { get; set; }
        public bool Banned { get; set; }
        public string Banreason { get; set; }
        public bool Gm { get; set; }
        public string Email { get; set; }
        public string Macs { get; set; }
        public DateTime Lastpwemail { get; set; }
        public DateTime Tempban { get; set; }
        public sbyte? Greason { get; set; }
        public int? PaypalNx { get; set; }
        public int? MPoints { get; set; }
        public int? CardNx { get; set; }
        public bool? DonatorPoints { get; set; }
        public bool Guest { get; set; }
        public ulong LastLoginInMilliseconds { get; set; }
        public string Lastknownip { get; set; }
        public int? VotePoints { get; set; }
        public string Sitelogged { get; set; }
        public int? Webadmin { get; set; }
        public string Ip { get; set; }
        public string SessionIp { get; set; }
        public sbyte Gender { get; set; }
        public string Hwid { get; set; }
        public bool? Tos { get; set; }
        public sbyte Characterslots { get; set; }
        public string Nick { get; set; }
        public int? Mute { get; set; }
        public string Qq { get; set; }
        public string Sj { get; set; }
        public int? Lv { get; set; }
        public int? Rmb { get; set; }
        public string Promoters { get; set; }
        public int? Promoterschongzhi { get; set; }
        public int? Promoterschongzhilog { get; set; }
        public long? Fj { get; set; }

        public virtual ICollection<Characterslots> CharacterslotsNavigation { get; set; }
        public virtual ICollection<Iplog> Iplog { get; set; }
        public virtual ICollection<Storages> Storages { get; set; }
    }
}
