using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Coffee_Manager : Coffee_Machine
    {
        public Coffee_Machine Machine { get; set; }


        public Coffee_Manager()
        {
            Machine = new Coffee_Machine("Baghramyan");
        }

        public void GetCoffee()
        {
            int coin;
            do
            {
                Console.WriteLine("Please insert coins");
                coin = int.Parse(Console.ReadLine());
            }
            while (!Security(coin));

            int coffeePrice;
            byte chooseCoffee = ChooseCoffee();

            switch (chooseCoffee)
            {
                case 1:
                    {
                        coffeePrice = 100;
                        break;
                    }
                case 2:
                    {
                        coffeePrice = 150;
                        break;
                    }
                case 3:
                    {
                        coffeePrice = 200;
                        break;
                    }
                case 4:
                    {
                        coffeePrice = 250;
                        break;
                    }
                case 5:
                    {
                        coffeePrice = 300;
                        break;
                    }
                case 6:
                    {
                        coffeePrice = 350;
                        break;
                    }
                case 7:
                    {
                        coffeePrice = 400;
                        break;
                    }
                case 8:
                    {
                        coffeePrice = 450;
                        break;
                    }
                case 9:
                    {
                        coffeePrice = 500;
                        break;
                    }
                case 10:
                    {
                        coffeePrice = 550;
                        break;
                    }
                default:
                    Console.WriteLine("There is no coffee corresponding to the number you entered");
                    return;
            }
        Refresh:
            if (coin >= coffeePrice)
            {

                CreateCoffee();
                Console.WriteLine($"Take your change {coin - coffeePrice} dram");
                Console.WriteLine("Product is ready.");
            }
            else
            {
                Console.WriteLine($"Please insert {coffeePrice - coin} dram");

                int newCoin = int.Parse(Console.ReadLine());
                if (Security(newCoin)) coin += newCoin;
                goto Refresh;
            }
        }
    }
}
