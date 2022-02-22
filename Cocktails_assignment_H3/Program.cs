using System;
using System.Collections.Generic;
using System.Threading;

namespace Cocktails_assignment_H3
{
    public class Program
    {
        public static Drinkmanager drinkmanager = new Drinkmanager();
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-1- Show all");
                Console.WriteLine("-2- Create Drink");
                Console.WriteLine("-3- Delete Drink");
                Console.WriteLine("-4- Update Drink");
                Console.WriteLine("Click the number of the function you wish to use: ");
                ConsoleKeyInfo input = Console.ReadKey();
                if (char.IsDigit(input.KeyChar))
                {
                    int id = int.Parse(input.KeyChar.ToString());
                    switch (id)
                    {
                        case 1:
                            ShowAll();
                            break;
                        case 2:
                            AddDrinkToCard();
                            break;
                        case 3:
                            DeleteFromCard();
                            break;
                        case 4:
                            UpdateDrinkOnCard();
                            break;
                        default:
                            Console.WriteLine("Unvalid input");
                            break;
                    }

                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("\nUnvalid input");
                    Thread.Sleep(2000);
                }
            }
        }

        public static void ShowAll()
        {
            Console.Clear();
            foreach (Container drink in drinkmanager.GetDrinklist())
            {
                Console.WriteLine(drink.ToString());
            }
            Console.ReadKey();
            Start();
        }

        public static void DeleteFromCard()
        {
            int id;
            Console.Clear();
            foreach (Container drink in drinkmanager.GetDrinklist())
            {
                Console.WriteLine(drink.Id + "| " + drink.Blend.Name);
            }
            Console.Write("\n\nId for drink you want deleted: ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out id);
            if (!id.Equals(null))
            {
                Console.WriteLine("\n" + drinkmanager.DeleteById(id));
                Thread.Sleep(200);
            }
            else
            {
                Console.WriteLine("\nUnvalid input");
                Thread.Sleep(2000);
            }
        }

        public static void AddDrinkToCard()
        {
            Console.Clear();
            Console.Write("Glass Type: ");
            string glass = Console.ReadLine();
            List<Ingredient> ingredients = ChooseIngredients();
            Console.Clear();
            string[] values = Enum.GetNames(typeof(Icetypes));
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(i + " " + values[i]);
            }
            Console.Write("Write id for ice in drink: ");
            string iceID = Console.ReadLine();
            Int32.TryParse(iceID, out int id);
            Icetypes ice = (Icetypes)id;
            Console.Clear();
            Console.Write("A name for your drink: ");
            string name = Console.ReadLine();
            Container tempCon = drinkmanager.CreateContainer(glass, name, ingredients, ice);
            Console.Clear();
            Console.WriteLine(tempCon.ToString());
            Console.Write("\n\nIs this how you wish your drink to be (y/n): ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine(drinkmanager.AddNewDrinkList(glass, name, ingredients, ice).ToString()); 
                Start();
            }
            else
            {
                Console.WriteLine("Oki, going back to start");
            }
            
        }

        public static void UpdateDrinkOnCard()
        {

        }


        /// <summary>
        /// Method for only choosing what goes into drink
        /// </summary>
        /// <returns></returns>
        public static List<Ingredient> ChooseIngredients()
        {
            bool chooseAlcohol = true;
            bool chooseSoft = true;
            bool chooseGarnish = true;
            List<Ingredient> ingredients = new List<Ingredient>();
            //while loop for running while you choose alcohol
            while (chooseAlcohol)
            {
                Console.Clear();
                Console.WriteLine("Alcohol that shall go into the drink/ write 'end' stop alchol choosing:");
                Console.Write("(write like 'Alcohol of your liking, Amount in ML'): ");
                string text = Console.ReadLine();
                if (text.ToLower().Equals("end"))
                {
                    chooseAlcohol = false;
                }
                else
                {
                    string[] splittedtext = text.Split(',');
                    if (splittedtext.Length > 2)
                    {
                        ingredients.Add(new Alcohol(splittedtext[0], splittedtext[1]));
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(500);
                    }
                }

            }
            //while loop for running while you choose Softdrinks
            while (chooseSoft)
            {
                Console.Clear();
                Console.WriteLine("Softdrink that shall go into the drink/ write 'end' stop Softdrink choosing:");
                Console.Write("(write like 'Softdrink of your liking, Amount in ML'): ");
                string text = Console.ReadLine();
                if (text.ToLower().Equals("end"))
                {
                    chooseSoft = false;
                }
                else
                {
                    string[] splittedtext = text.Split(',');
                    if (splittedtext.Length > 2)
                    {
                        ingredients.Add(new Soft(splittedtext[0], splittedtext[1]));
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(500);
                    }
                }
            }
            //while loop for running while you choose Garnish
            while (chooseGarnish)
            {
                Console.Clear();
                Console.WriteLine("Garnish that shall go into the drink/ write 'end' stop Garnish choosing:");
                Console.Write("(write like 'Garnish of your liking, Amount'): ");
                string text = Console.ReadLine();
                if (text.ToLower().Equals("end"))
                {
                    chooseGarnish = false;
                }
                else
                {
                    string[] splittedtext = text.Split(',');
                    if (splittedtext.Length > 2)
                    {
                        ingredients.Add(new Garnish(splittedtext[0], splittedtext[1]));
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(500);
                    }
                }
            }
            return ingredients;
        }
    }
}
