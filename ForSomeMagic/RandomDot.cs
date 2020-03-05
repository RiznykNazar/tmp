using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSomeMagic
{

    public class RandomDot : IComparable <RandomDot> 
    {   
        public int x { get; private set; }
        public int y { get; private set; }

        public double distance { get; set; }

        public RandomDot(Random r)
        {
            x = r.Next(0, 100000);
            y = r.Next(0, 100000);

            distance = Math.Round( Math.Sqrt((Math.Pow(x , 2) + Math.Pow(y, 2))),7);// distance between dot and 0.0 coords
        }

        public int CompareTo(RandomDot comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.distance.CompareTo(comparePart.distance);
        }

       

    }

    public class CreateDots
    {

        Random r = new Random();

        public List<RandomDot> CreateDotsList(int count)
        {
            List<RandomDot> dots = new List<RandomDot>();
            for (int i = 0; i < count; i++)
            {
                dots.Add(new RandomDot(r));
            }
            return dots;
        }


        public HashSet<RandomDot> CreateDotsHashSet(int count)
        {
            HashSet<RandomDot> dots = new HashSet<RandomDot>();

            for (int i = 0; i < count; i++)
            {
                dots.Add(new RandomDot(r));
            }

            return dots;
        }

      

    }
}



