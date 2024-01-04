namespace Domain
{
    public class Product
    {
        string Name { get; set; }
        decimal TotalValue { get; set; }
        DateTime ShoppingDate { get; set; }
        int NumberOfPart { get; set; }

        public decimal GetPartialValue()
        {
            return TotalValue / NumberOfPart;
        }
    }
}