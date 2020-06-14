using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class Consumption
    {
        public int Id { get; set; }
        public int Charactersid { get; set; }
        public int Accountsid { get; set; }
        public string Qq { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Nx { get; set; }
    }
}
