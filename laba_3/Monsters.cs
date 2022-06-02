using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    class Monsters : MythicalMonsters
    {
        private string personality;
        private int height;

        public Monsters() : base() { }
        public Monsters(string type, string typeOfPowerSupply) : base(type, typeOfPowerSupply) { }

        public Monsters(string type, string typeOfPowerSupply, string personality) : base(type, typeOfPowerSupply)
        {
            this.personality = personality;
        }

        public Monsters(string type, string typeOfPowerSupply, string personality, int lifeExpectancy) : base(type, typeOfPowerSupply)
        {
            this.personality = personality;
            this.height = height;
        }
        public override string Print()
        {
            return $" {base.Print()}, характер {personality}, рост{height} 190 сантиметров";
        }

    }
}
