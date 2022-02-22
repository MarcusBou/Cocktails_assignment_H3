using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class Container
    {
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

        public override string ToString()
        {
            string alc = "";
            string sof = "";
            string garn = "";
            foreach (var item in Blend.Ingredients)
            {
                if (item.GetType() == typeof(Alcohol))
                {
                    alc += " - "+ item.Name+" | "+item.Amount+"\n";
                }
                if (item.GetType() == typeof(Soft))
                {
                    sof += " - " + item.Name + " | " + item.Amount + "\n";
                }
                if (item.GetType() == typeof(Garnish))
                {
                    garn += " - " + item.Name + " | " + item.Amount + "\n";
                }
            }
            string con = "ID: "+Id+"\n"+Blend.Name+": \nGlas type: "+Glasstype+"\nAlcohol: \n" + alc +"Soft drinks: \n" + sof + "Garnish: " + garn;
            con += "\n[----------------------------------------]";
            return con;
        }
    }
}
