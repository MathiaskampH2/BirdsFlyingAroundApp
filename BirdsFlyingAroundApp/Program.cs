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
            // new penguin object
            Penguin penguin = new Penguin();
            Console.WriteLine("I'm a Penguin"+ "\n" +penguin.Eat() +"\n" + penguin.MakeSound() + "\n\n");

            // new albatross object
            Albatross albatross = new Albatross();
            Console.WriteLine("I'm an Albatross" + "\n" + albatross.Eat() +"\n" + albatross.MakeSound()+"\n" + albatross.BirdCanFly());


        }
    }
}