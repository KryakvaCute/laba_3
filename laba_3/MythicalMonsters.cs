using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    class MythicalMonsters
    {
        private string type;
        private string typeOfPowerSupply;
        public string Type { get; set; }
        public string TypeOfPowerSupply { get; set; }



        public MythicalMonsters() { }
        public MythicalMonsters(string type)
        { this.type = type; }
        public MythicalMonsters(string type, string typeOfPowerSupply)
        { this.type = type; this.typeOfPowerSupply = typeOfPowerSupply; }




        public virtual string Print()
        {
            return $"Тип - {this.type}, тип питания - {this.typeOfPowerSupply}";
        }
    }
}
