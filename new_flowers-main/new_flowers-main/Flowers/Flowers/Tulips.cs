using Flowers.Flowers;

namespace FlowersShop.Flowers
{
    public class Tulips : FlowerProperty, IHaveAType
    {

        public override int Id { get; set; } = 2;
        public override string NameOfFlower { get; set; } = "Tulips";
        public override int Cost { get; set; } = 15;


        public string GetNameOfFlower() => $"I am a flower {NameOfFlower}";

    }
}
