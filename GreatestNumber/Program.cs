// See https://aka.ms/new-console-template for more information
int num1, num2, sum;

Console.WriteLine("Insert a number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    {
        Console.WriteLine("The greatest number is: " + num1);
    }
else
    Console.WriteLine("The greatest number is: " + num2);