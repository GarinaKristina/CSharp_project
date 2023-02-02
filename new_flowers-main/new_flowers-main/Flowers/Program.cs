using FlowersShop.FlowerShop;
using System;

namespace Flowers
{
    class Program
    {
        static void Main()
        {
            FlowerShop flowerShop = new FlowerShop();

            Console.WriteLine($"Are you ready to order your flowers?");
            Console.Write("Answer please yes/no:  ");
            var answer = flowerShop.GetAnswer();

            try
            {
                if (answer == "yes")
                {
                    Console.WriteLine("Oh! Wondeful!!! What do you want?");
                    var chosenFlowers = flowerShop.ChooseFlowers();
                    var totalCost = flowerShop.GetCostOfTheFlowers(chosenFlowers);
                    Console.WriteLine($"The total cost the bouquet of '{string.Join(",", chosenFlowers)}': {totalCost} dollars");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Bye-Bye");
                }
                else
                {
                    throw new WrongTypeOfAnswerException("");
                }

            }
            catch (WrongTypeOfAnswerException)
            {
                Console.WriteLine($"Please type 'yes' or 'no'");
                throw;

            }
            catch (WrongChosenTypeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (EmptyChosenFlowersException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("See you soon");
            }
        }
    }
}
