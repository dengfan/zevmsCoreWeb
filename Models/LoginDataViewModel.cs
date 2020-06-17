using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZEVMSWEB.Models.Entities;

namespace ZEVMSWEB.Models
{
    public class LoginDataViewModel
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public List<CharacterViewModel> Characters { get; set; }
    }
}
