namespace CQRSNight.CQRSDesignPattern.Command.ProductCommands
{
    public class RemoveProductCommand
    {
        public int ProductId { get; set; }

        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }
    }
}
