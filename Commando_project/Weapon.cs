using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    internal class Weapon
    {
        public string Name {  get; set; }
        public string Manufacturer {  get; set; }
        public int AmountOfBalls { get; set; }


        public Weapon(string name ,string manufacturer,int amountOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            AmountOfBalls = amountOfBalls;
        }

        public void Shoot()
        {
            if (AmountOfBalls > 0)
            {
                Console.WriteLine("A shot was fired.");
                AmountOfBalls--;
            }
            else
            {
                Console.WriteLine("Not enough bullets");
            }
        }
        



    }
}
