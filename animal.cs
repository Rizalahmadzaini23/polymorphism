using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("The animal speaks");
        }
    }
}
