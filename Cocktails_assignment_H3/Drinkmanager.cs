using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public class Drinkmanager
    {
        private List<Container> Drinklist;
        private DBManager dbman = new DBManager();

        public Drinkmanager()
        {
            Drinklist = dbman.GetDrinkList();
        }

        public List<Container> GetDrinklist()
        {
            return Drinklist;
        }

        
        /// <summary>
        /// For a Creating Container if show of it is needed like under creation
        /// </summary>
        /// <param name="glass"></param>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        /// <param name="icetypes"></param>
        /// <returns></returns>
        public Container CreateContainer(string glass, string name, List<Ingredient> ingredients, Icetypes icetypes)
        {
            Container con = new Container(glass, name, ingredients, icetypes);
            return con;
        }

        /// <summary>
        /// add new drink to the DB
        /// </summary>
        /// <param name="glass"></param>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        /// <param name="icetypes"></param>
        /// <returns></returns>
        public Container AddNewDrinkList(string glass, string name, List<Ingredient> ingredients, Icetypes icetypes)
        {
            Container con = new Container(glass, name, ingredients, icetypes);
            dbman.AddDrinkToDB(con);
            Drinklist = dbman.GetDrinkList();
            return con;
        }

        /// <summary>
        /// Is being giving an ID through parameters, which will go in and delete it from the db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteById(int id)
        {
            foreach (var drink in Drinklist)
            {
                if (drink.Id.Equals(id))
                {
                    Container container = drink;
                    dbman.DeleteFromDB(container);
                    Drinklist = dbman.GetDrinkList();
                    return container.Id + " has been removed";
                }
            }
            return "Id is not valid";


        }
            
    }
}


