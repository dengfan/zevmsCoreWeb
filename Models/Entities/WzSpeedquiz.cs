using System;
using System.Collections.Generic;

namespace ZEVMSWEB.Models.Entities
{
    public partial class WzSpeedquiz
    {
        public int QuizDataId { get; set; }
        public short Type { get; set; }
        public int Objectid { get; set; }
        public string Answer { get; set; }
        public int QuestionNo { get; set; }
    }
}
