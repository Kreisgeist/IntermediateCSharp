namespace Testability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProccesor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}