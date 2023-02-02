using Flowers.Flowers;

namespace FlowersShop.Flowers
{
    public class Chrysanthemum : FlowerProperty, IHaveAType
    {

        public override int Id { get; set; } = 1;
        public override string NameOfFlower { get; set; } = "Chrysanthemum";
        public override int Cost { get; set; } = 10;


        public string GetNameOfFlower() => $"I am a flower {NameOfFlower}";

    }
}
