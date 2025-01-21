using System;

class Level1 {
    static void Main() {
        double costPrice = 129, sellingPrice = 191;
        double profit = sellingPrice - costPrice;
        double profitPercent = (profit / costPrice) * 100;

        Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
                          $"The Profit is INR {profit:F2} and the Profit Percentage is {profitPercent:F2}.");
    }
}
