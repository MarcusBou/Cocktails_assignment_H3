using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class Garnish : Ingredient
    {
        public Garnish() { }
        public Garnish(string name, string amount) : base(name, amount)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
