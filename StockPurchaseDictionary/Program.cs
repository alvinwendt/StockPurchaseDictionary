namespace StockPurchaseDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            // Add a few more of your favorite stocks

            string GM = stocks["GM"]; //< ---"General Motors"

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 150, price: 23.21));
            purchases.Add((ticker: "AAPL", shares: 32, price: 17.87));
            purchases.Add((ticker: "AAPL", shares: 80, price: 19.02));
            // Add more for each stock you added to the stocks dictionary

            //Create a total ownership report that computes the total value of each stock that you have purchased.
            //This is the basic relational database join algorithm between two tables.

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */



            Dictionary<string, double> report = new Dictionary<string, double>();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value

            }

        }
    }
}