// Include name spaces
using System;
using System.IO;

namespace breakEven {
    class Program{
        static void Main(){

        // Initialise variables
        string separator = new string('-', 40);
        string nameOfProduct = null;
        int totalFixedCost = 0;
        int variableCostPerUnit = 0;
        int contributionMargin = 0;
        int breakEvenPoint = 0;

        // Display title of the app
        Console.WriteLine(separator);
        Console.WriteLine("Breakeven Analysis for a single product.");
        Console.WriteLine(separator);

        // Request the name of the product
        Console.WriteLine("What is the name of your product? ");
        nameOfProduct = Convert.ToString(Console.ReadLine());
        Console.WriteLine(separator + '\n');

        // Request fixed cost value 
        // Console.WriteLine();
        totalFixedCost = Convert.ToInt32(Console.ReadLine("What are your total fixed costs? "));
        Console.WriteLine(separator + '\n');

        // Request variable cost value 
        Console.WriteLine("What is the variable cost of your product? ");
        variableCostPerUnit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(separator + '\n');

        // Calculate the contribution margin
        Console.WriteLine("The contribution margin is equal to fixed costs - variable costs.\n");
        Console.WriteLine($"Fixed costs: ${totalFixedCost}\nVariable costs: ${variableCostPerUnit}\n");

        contributionMargin = totalFixedCost - variableCostPerUnit;

        Console.WriteLine($"Contribution margin: ${contributionMargin}");
        Console.WriteLine(separator + '\n');

        // Calculate the breakeven point
        Console.WriteLine("The breakeven point is equal to total fixed costs divided by contribution margin.\n");

        breakEvenPoint = totalFixedCost / contributionMargin;

        Console.WriteLine($"The breakeven number of units to sell: {breakEvenPoint}");
        Console.WriteLine(separator + '\n');
        }
    }

    class Products{
        // Perform CRUD database logic
        static addProduct(){
            // add an item (i.e. ticket class) to a database
            // give it a set of attributes (price, quantity)
            // keep a total of how much profit etc. the item gains
        }

        static viewProduct(){
            // get request for the details of the item
        }

        static editProduct(){
            // update details of product
        }
    }

    class Profit{
        static calculateRevenue (int unitsSold, int price){
        Console.WriteLine("How many units did you sell?");
        unitsSold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What price did you sell them for?");
        price = Convert.ToInt32(Console.ReadLine());
        revenue = unitsSold * price;
        return revenue;
    }

        static calculateProfit(int revenue, int totalCosts){
        profit = revenue - totalCosts;
        return profit;
    }

}
