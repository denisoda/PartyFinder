using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace DLL.models
{
    public class Party
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public DataTime TimeStart {get;set;}
        public DataTime TimeEnd {get;set;}
        public string Description {get;set;}
        public ICollection<User> Partisipants {get;set;}
    }
}