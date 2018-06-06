using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DLL.Models
{
    public class User
    {
        public int Id {get; set;}
        public string FName {get; set;}
        public string SName {get; set;}
        public Party UserParty{get; set;}
        public ICollection<Rewiew> Rewiew{get; set;}
    }
}