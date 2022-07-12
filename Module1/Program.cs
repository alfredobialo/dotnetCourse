// See https://aka.ms/new-console-template for more information
using static System.Console;

Console.WriteLine("Hello, World!");

// foreach, for, do, while, goto
// , if, if..else, switch

int[] peoplesAge = new int[5] { 30, 25, 42, 18, 32 };  // Array declaration and assignment (initialization)

// requirement for ages less than 30 , multiply by 2, then Print all results

foreach (int i in peoplesAge)
{
    int y = i;
    if (i < 30)
    {
        y =  i * 2;
    }
    
    WriteLine($"Age is : {y}");
}


