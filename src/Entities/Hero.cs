using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Entities;

namespace dotnet_ef_marvel.src.Entities
{
    public class Hero
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public string RealName;
        public DateTime CreatedAt { get; set; } 
        public int? GroupId{ get; set;}
        public Group group;
    }
}