using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Puppy:Dog
    {
        public override void Makesound()
        {
            System.Console.WriteLine("Puppy Sound");
        }
    }
}