using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projet_net.Models;

namespace projet_net.Dto.Character
{
    public class GetDtoCharacter
    {
        public int Id {get;set;}
        public string? Name  {get;set;}
        public int HitPoints {get;set;}=100;
        public int Strength {get;set;}=10;
        public int Defense {get;set;}=10;
        public int Intelligence {get;set;}=10;
        public RpgClass Class {get;set;}=RpgClass.Knight;
    }
}