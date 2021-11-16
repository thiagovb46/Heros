using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Dto;
using src.Entities;

namespace dotnet_ef_marvel.src.Entities
{
    public class Hero
    {   public Hero(){}
        public Hero(CreateHero hero)
        { 
            this.Name=hero.Name;
            this.RealName=hero.RealName;
            this.GroupId=hero.GroupId;
        }

        public int Id {get;private set;}
        public string Name{get;set;}
        public string RealName;
        public DateTime CreatedAt { get;set; }=DateTime.Now;
        public int? GroupId{ get; set;}
        public Group group;
    }
}