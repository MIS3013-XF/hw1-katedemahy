// HW1a Sales Total

// Your Name:Kate de Mahy
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        private const double taxRate = 0.085; // const= never change double = to store numbers with decimals
        static void Main(string[] args)
        {

            Console.WriteLine("What is the product name of the item you are purchasing?"); // console.write displays without line break, readline waits for user to type something, add string and it stores it as a string, with itemName after string it saves the string as the name to use later
            string itemName =Console.ReadLine();

            Console.WriteLine($"How many {itemName}'s do you want to buy?"); // $ you can insert {itemName} right in the text
            int quantity = Convert.ToInt32(Console.ReadLine()); // int.parse converts string to integer, readline waits for user to type something, we choose int cause quantity is always a whole #

            Console.WriteLine($"What is the price of {itemName}?"); // double is for numbers with decimals
            double price = Convert.ToDouble(Console.ReadLine());

            double subtotal = quantity * price;
            double salesTax = subtotal * taxRate;
            double total = subtotal + salesTax;

            Console.WriteLine(); // blank one to add line spacing between input and output really for aesthetics
            Console.WriteLine($"Your subtotal for your bill is {subtotal:C}."); // C formats number as currency
            Console.WriteLine($"The sales tax is {salesTax:C}.");
            Console.WriteLine($"Your total for your bill is {total:C}.");

        }
    }
}
