using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Dog:Animal
    {
        public override void Makesound()
        {
            System.Console.WriteLine("Dog sound");
        }
    }
}