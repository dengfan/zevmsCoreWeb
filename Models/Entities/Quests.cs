﻿using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Quests
    {
        public int Id { get; set; }
        public string A { get; set; }
        public int? Jsid { get; set; }
        public int? X { get; set; }
        public DateTime? T { get; set; }
    }
}