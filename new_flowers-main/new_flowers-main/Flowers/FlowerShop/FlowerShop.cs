using Flowers;
using FlowersShop.Flowers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowersShop.FlowerShop
{
    public class FlowerShop
    {
        private List<FlowerProperty> existingFlowers;
        private Rose rose;
        private Tulips tulpis;
        private Chrysanthemum chrysanthemum;
        private Narcissus narcissus;

        public FlowerShop()
        {
            chrysanthemum = new Chrysanthemum();
            tulpis = new Tulips();
            narcissus = new Narcissus();
            rose = new Rose();
            existingFlowers = new List<FlowerProperty>() { chrysanthemum, rose, tulpis, narcissus };
        }

        public string GetAnswer() => Console.ReadLine();

        public List<string> ChooseFlowers()
        {

            foreach (var flower in existingFlowers)
            {
                Console.Write($"{flower.Id} - {flower.NameOfFlower}  ");

            }
            string returnResult = Console.ReadLine();

            List<string> receivedListOfFlowers = string.IsNullOrEmpty(returnResult) ? new List<string>() : returnResult.Split(',').ToList();

            return receivedListOfFlowers;
        }


        public int GetCostOfTheFlowers(List<string> receivedListOfFlowers)
        {
            if (receivedListOfFlowers.Count == 0)
            {
                throw new EmptyChosenFlowersException("Gotta choose something. :( ");
            }
            
            else if (!receivedListOfFlowers.All(r => existingFlowers.Any(e => e.NameOfFlower.Contains(r))))
            {
                throw new WrongChosenTypeException("Please, type the name of Flower.");
            }
            
            var totalCost = 0;

            foreach (var flower in existingFlowers)
            {
                if (receivedListOfFlowers.Contains(flower.NameOfFlower))
                {
                    totalCost += flower.Cost;
                }

            }
            return totalCost;
        }
    }
}


