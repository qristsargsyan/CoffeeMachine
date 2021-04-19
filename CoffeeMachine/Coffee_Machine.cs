using System;

namespace CoffeeMachine
{
    public enum CoffeeName
    {
        Cappuccino = 1,
        Americano,
        Espresso,
        Doppio,
        Robusta,
        Arabica,
        Macchiato,
        Mocha,
        Affogato,
        Mazagran
    }
    public class Coffee_Machine
    {
        private string Address { get; set; }

        public Coffee_Machine()
        {

        }
        public Coffee_Machine(string address)
        {
            Address = address;
        }
        protected double CreateCoffee()
        {
            Console.WriteLine("Please enter water sugar and coffee portions (1 - 10 interval)");
            Console.Write("Water - ");
            byte.TryParse(Console.ReadLine(), out byte water);
            Console.Write("Sugar - ");
            byte.TryParse(Console.ReadLine(), out byte sugar);
            Console.Write("Coffee - ");
            byte.TryParse(Console.ReadLine(), out byte coffee);

            if (water < 11 && sugar < 11 && coffee < 11)
            {
                return 0.1 * water + 0.1 * sugar + 0.1 * coffee;
            }
            else
            {

                water = 10;
                sugar = 10;
                coffee = 10;
                return 0.1 * water + 0.1 * sugar + 0.1 * coffee;
            }
        }

        protected byte ChooseCoffee()
        {
            int price = 50;
            Console.WriteLine($"Press ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} --> {(CoffeeName)i} ({price += 50})");
            }

            byte chooseCoffee = byte.Parse(Console.ReadLine());
            return chooseCoffee;
        }
        protected bool Security(int coin)
        {

            if (coin != 50 && coin != 100 && coin != 200 && coin != 500)
            {
                Console.WriteLine("You can insert only 50 100 200 500 coins");
                return false;
            }
            return true;
        }


    }
}
