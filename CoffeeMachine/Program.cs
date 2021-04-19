using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee_Manager coffee = new Coffee_Manager();
            coffee.Machine = new Coffee_Machine("Abovyan");
            coffee.GetCoffee();
        }

    }
}
