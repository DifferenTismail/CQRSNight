namespace CQRSNight.CQRSDesignPattern.Command.ProductCommands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int ProductStok { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
