using Flowers.Flowers;

namespace FlowersShop.Flowers
{
    public class Narcissus : FlowerProperty, IHaveAType
    {

        public override int Id { get; set; } = 3;
        public override string NameOfFlower { get; set; } = "Narcissus";
        public override int Cost { get; set; } = 12;

        public string GetNameOfFlower() => $"I am a flower {NameOfFlower}";

    }

}
