using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class Container
    {
        /*private string glasstype;
        private DrinkBlend blend;*/
        public int Id { get; set; }
        public string Glasstype { get; set; }
        public DrinkBlend Blend { get; set; }

        public Container() { }
        public Container(string glass)
        {
            this.Glasstype = glass;
        }

        public Container(string glass, string blendName, List<Ingredient> ingredients, Icetypes ice)
        {
            this.Glasstype = glass;
            this.Blend = new DrinkBlend(blendName, ingredients, ice);
        }
    }
}
