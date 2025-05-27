using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    enum Status
    {
        Standing,
        Walking,
        Hiding
    }
    internal class Commando
    {
        public string _name { get; set; }
        public string _codeName { get; set; }
        private string[] _tools = { "Hammer, chisel, rope, bag, water bottle"};
        private Status _currentstatus;

        public Commando (string name, string codeName)
        {
            _name = name;
            _codeName = codeName;
            _currentstatus = Status.Standing;
        }

        public void Walk()
        {
            Console.WriteLine($"{_name}; is {Status.Walking} ");
            _currentstatus = Status.Walking;
        }
        public void Hide()
        {
            _currentstatus =Status.Hiding;
            Console.WriteLine($" {_name} is {_currentstatus}");
        }
        public void Attack()
        {
            Console.WriteLine($"{_name} is attacks");
        }
    }
}
