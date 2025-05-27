using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    internal class Weapon
    {
        public string _name {  get; set; }
        public string _manufacturer {  get; set; }
        public int _amountOfBalls { get; set; }


        public Weapon(string name ,string manufacturer,int amountOfBalls)
        {
            _name = name;
            _manufacturer = manufacturer;
            _amountOfBalls = amountOfBalls;
        }

        public void Shoot()
        {
            if (_amountOfBalls > 0)
            {
                Console.WriteLine("A shot was fired.");
                _amountOfBalls--;
            }
            else
            {
                Console.WriteLine("Not enough bullets");
            }
        }
        



    }
}
