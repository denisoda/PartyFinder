using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DLL.Models
{
    public class Party
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime TimeStart {get; set;}
        public DateTime TimeEnd {get; set;}
        public string Description {get; set;}
        public decimal LocationX {get; set;}
        public decimal LocationY {get; set;}
        public ICollection<Rewiew> Rewiew {get; set;}
        public ICollection<User> Partisipants {get; set;}
    }
}