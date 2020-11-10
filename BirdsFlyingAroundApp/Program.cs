using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin();

            Albatross albatross = new Albatross();

            Console.WriteLine(albatross.BirdCanFly());

        }
    }
}