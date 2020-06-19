using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Jiazu
    {
        public int Id { get; set; }
        public int? Jiazuid { get; set; }
        public int? Jiazuworld { get; set; }
        public string Jiazuname { get; set; }
        public int? Jiazujingyan { get; set; }
        public int? Jiazurenshu { get; set; }
        public int? Jiazugp { get; set; }
        public string Gonggao { get; set; }
    }
}
