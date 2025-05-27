using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    internal class SeaCommando : Commando
    {
        private bool _canSwim;

        public SeaCommando(string name, string codeName) : base(name, codeName)
        {
            _canSwim = true;
        }
        public void Swim()
        {
            Console.WriteLine("swimmmmm");
        }
        public override void Attack()
        {
            Console.WriteLine($"sea commando is attacks");
        }
    }
}
