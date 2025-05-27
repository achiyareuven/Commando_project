using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commando_project
{
    class AirCommando : Commando
    {
        private bool _canfall;
        public AirCommando(string name, string codeName) :  base(name, codeName)
        {
            _canfall = true;
        }
        public void Air()
        {
            Console.WriteLine("falllll");
        }
        public override void Attack()
        {
            Console.WriteLine($"aircommando is attacks");
        }
    }
}
