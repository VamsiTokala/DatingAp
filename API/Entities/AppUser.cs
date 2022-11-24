using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        //entiry framwork recognises id as primiary key automatically
        public int Id { get; set; }
        //Asp.net core identify uses Capital letter, there will be morerefactoring later if we don't follow convention
        public string UserName { get; set; } 
    }
}