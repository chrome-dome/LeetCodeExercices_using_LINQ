/*
-You are given an array prices where prices[i] is the price of a given stock on the ith day.
-You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
-Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
 */


using System;
using System.Linq;

int MaxProfit(int[] prices)
{
    int minPrice = prices.Min();
    int maxProfit = prices.Zip(prices.Skip(1), (x, y) => y - x).Max();
    return maxProfit;
}

int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
int maxProfit = MaxProfit(prices);
Console.WriteLine(maxProfit);
Console.ReadLine();