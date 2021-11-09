using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Dto
{
    public class CreateHero
    {
        public string Name{get;set;}
        public string RealName {get; set;} 
        public int? GroupId{get; set;}
    }
}