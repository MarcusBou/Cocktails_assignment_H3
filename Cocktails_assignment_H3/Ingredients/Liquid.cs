using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public abstract class Liquid : Ingredient
    {
        protected Liquid(string name, string amount) : base(name, amount)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
