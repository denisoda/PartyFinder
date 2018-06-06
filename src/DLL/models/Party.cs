using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DLL.models
{
    public class Party
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public ICollection<User> Partisipants {get; set;}
    }
}