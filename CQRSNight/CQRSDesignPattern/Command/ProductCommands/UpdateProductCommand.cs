namespace CQRSNight.CQRSDesignPattern.Command.ProductCommands
{
    public class UpdateProductCommand
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStok { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
