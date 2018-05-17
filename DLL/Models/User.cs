using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GoodNight.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Reputation Reputation { get; set; }
        public Location Location { get; set; }
    }
}