using System;

namespace GoodNight.Models
{
    public class Party
    {
        public int IdCreater { get; set; }
        public DateTime StartTime { get; set; }
        public int Partisipants { get; set; }
        public string Description { get; set; }
    }
}