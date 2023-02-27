using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and muy favourite food is {this.FavouriteFood}";
        }
    }
}
