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
        public string Name { get; set; }
        public string CodeName { get; set; }
        private string[] _tools = { "Hammer, chisel, rope, bag, water bottle"};
        private Status _currentstatus;

        public Commando (string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            _currentstatus = Status.Standing;
        }

        public void Walk()
        {
            Console.WriteLine($"{Name}; is {Status.Walking} ");
            _currentstatus = Status.Walking;
        }
        public void Hide()
        {
            _currentstatus =Status.Hiding;
            Console.WriteLine($" {Name} is {_currentstatus}");
        }
        public void Attack()
        {
            Console.WriteLine($"{Name} is attacks");
        }
    }
}
