using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaFactory : IPizzaFactory
    {


        public AbstractPizza MakePizza(string[] additionals)
        {
            AbstractPizza pizza = new PizzaMargaritta(); ;
            return pizza;
        }

        private AbstractPizza AddIngredients(string ingredients, AbstractPizza pizza)
        {
            return null;
        }
    }
}
