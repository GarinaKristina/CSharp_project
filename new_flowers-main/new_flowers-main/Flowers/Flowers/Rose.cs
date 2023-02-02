using Flowers.Flowers;

namespace FlowersShop.Flowers
{

    public class Rose : FlowerProperty, IHaveAType
    {
        public override int Id { get; set; } = 4;
        public override string NameOfFlower { get; set; } = "Rose";

        public override int Cost { get; set; } = 22;


        public string GetNameOfFlower() => $"I am a flower {NameOfFlower}";
    }
}
