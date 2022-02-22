using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class DrinkBlend
    {
       /* string name;
        List<Ingredient> ingredients;
        Icetypes ice;*/

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Icetypes Icetypes { get; set; }

        public DrinkBlend() { }
        public DrinkBlend(string name,List<Ingredient> ingredients, Icetypes icetypes)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Icetypes = icetypes;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
