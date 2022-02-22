using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_assignment_H3
{
    public abstract class Ingredient
    {
        /*private int id;
        private string name;
        private string amount;*/
        public int Id { get; set; }
        public string Name { get; set;}
        public string Amount { get; set; }

        protected Ingredient(string name, string amount) {
            this.Name = name;
            this.Amount = amount;
        }
        protected Ingredient() { }
    }
}
