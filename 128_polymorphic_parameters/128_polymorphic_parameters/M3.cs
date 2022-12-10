using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128_polymorphic_parameters
{
    class M3: BMW
    {
        public M3(int hp, string colour, string model) : base(hp, colour, model)
        {
            this.Model = model;
        }

        public override void Repair()
        {
            base.Repair();
        }
    }
}
