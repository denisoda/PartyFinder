using Microsoft.EntityFrameworkCore;

namespace GoodNight.Models
{
    public class Location
    {
        public string LocationX { get; set; }
        public string LocationY { get; set; }

        public User User { get; set; }
    }
}