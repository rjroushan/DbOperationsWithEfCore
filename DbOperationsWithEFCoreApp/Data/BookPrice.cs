namespace DbOperationsWithEFCoreApp.Data
{
    public class BookPrice
    {
        public int  Id { get; set; }
        public int BookId { get; set; }

        public Book Books { get; set; }
        public decimal Amount { get; set; }

        public CurrencyType Currencyid { get; set; }

        

    }
}
