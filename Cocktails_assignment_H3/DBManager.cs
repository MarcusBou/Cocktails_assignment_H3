using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class DBManager
    { 
        DrinkContext ctx = new DrinkContext();
        /// <summary>
        /// Gets entire list with drinks in their given containers
        /// </summary>
        /// <returns></returns>
        public List<Container> GetDrinkList()
        {
            List<Container> containers = new List<Container>();
            foreach (Container item in ctx.containers)
            {
                ctx.Entry(item).Reference("Blend").Load();
                ctx.Entry(item.Blend).Collection(p => p.Ingredients).Load();
                containers.Add(item);
            }
            return containers;
        }

        /// <summary>
        /// Writes a new drink to the database
        /// </summary>
        /// <param name="container"></param>
        public void AddDrinkToDB(Container container)
        {
            ctx.containers.Add(container);
            ctx.SaveChanges();
        }
    }
}
