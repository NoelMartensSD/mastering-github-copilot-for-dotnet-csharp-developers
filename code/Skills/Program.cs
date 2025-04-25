using System.Transactions;

void CalculateNumbers(int var1, int var2)
{
    int result = var1 + var2;
    Console.WriteLine($"The result of adding {var1} and {var2} is {result}");
}

void SubtractNumbers(int var1, int var2)
{
    int result = var1 - var2;
    Console.WriteLine($"The result of subtracting {var1} from {var2} is {result}");
}
void MultiplyNumbers(int var1, int var2)
{
    int result = var1 * var2;
    Console.WriteLine($"The result of multiplying {var1} and {var2} is {result}");
}
Console.WriteLine("Enter two numbers to add:");
Console.Write("Number 1: ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 2: ");
var num2 = Convert.ToInt32(Console.ReadLine());
CalculateNumbers(num1, num2);
