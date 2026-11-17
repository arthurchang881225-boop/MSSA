/*
2. Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

Use the format specifiers to display currency, % symbol.
*/


Console.Write("Enter the original price: ");
decimal billTotal = decimal.Parse(Console.ReadLine());

Console.Write("How much percentage would you like to tip? ");
decimal tipRate = decimal.Parse(Console.ReadLine()) / 100;


if (billTotal > 0 && tipRate >= 0)
{
  decimal grandTotal = billTotal * (1 + tipRate);

  decimal tipAmount = grandTotal - billTotal;

  Console.WriteLine($"\nBill Total: {billTotal:C}");
  Console.WriteLine($"Tip ({tipRate:P0}): {tipAmount:C}");
  Console.WriteLine($"Grand Total: {grandTotal:C}");
}
else 
{Console.WriteLine("Enter a valide amount.");}


