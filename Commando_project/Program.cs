using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c = new Commando("aaa", "jk");
            AirCommando a = new AirCommando("fgh", "yy");
            SeaCommando s = new SeaCommando("jhj", "jj");
            //a.Attack();
            //c.Attack();
            //s.Attack();
            Commando[] commandos = { c ,a,s};
            foreach (var command in commandos)
            {
                command.Attack();
            }
        }

    }
}
