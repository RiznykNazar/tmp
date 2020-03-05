using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSomeMagic
{
    class Hero
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int XP { get; set; }

        public virtual void EnterToBattle()
        {
            Console.WriteLine("Ready");
        }

    }


    class Disruptor : Hero
    {
        public void CastThunterStrike()
        {
            Console.WriteLine("Thunder rolls!");
        }

        public override void EnterToBattle()
        {
            Console.WriteLine("The stormcrafter comes!");
        }

    }


    

}
