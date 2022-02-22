using System;
using System.Collections.Generic;

namespace Cocktails_assignment_H3
{
    public class Program
    {
        static void Main(string[] args)
        {
          /*
            using (var ctx = new DrinkContext())
            {
                List<Ingredient> ingredients = new List<Ingredient> (){ new Alcohol("Tequila", "20ml"), new Soft("Orange juice", "80ml"), new Soft("Grenadine", "10ml")};
                var alc = new Container("Highball", "sunrise" ,ingredients, Icetypes.no);

                ctx.containers.Add(alc);
                ctx.SaveChanges();
            }*/


            using (var ctx = new DrinkContext())
            {
                foreach (Container item in ctx.containers)
                {
                    ctx.Entry(item).Reference("Blend").Load();
                    Console.WriteLine(item.Id + "..." + item.Blend?.Name);
                }
            }
                Console.WriteLine("Hello World!");
        }
    }
}
