﻿// See https://aka.ms/new-console-template for more information
using static System.Console;

Console.WriteLine("Hello, World!");

// foreach, for, do, while, goto
// , if, if..else, switch

int[] peoplesAge = new int[5] { 30, 25, 42, 18, 32 };  // Array declaration and assignment (initialization)

// requirement for ages less than 30 , multiply by 2, then Print all results
WriteLine("FOREACH LOOP ");
foreach (int i in peoplesAge)
{
    int y = i;
    if (i < 30)
        y =  i * 2;

    WriteLine($"Age is : {y}");
}


// FOR LOOP
WriteLine("FOR LOOP ");
for (int i = 0; i < peoplesAge.Length; i++)
{
    int y = peoplesAge[i];

    if (peoplesAge[i] < 30)
        y = peoplesAge[i] * 2;
    
    WriteLine($"Age is : {y}");
}

//DO LOOP
WriteLine("DO..WHILE LOOP ");
int a = 0, b = 0;
do
{
    b = peoplesAge[a];
    if (b < 30)  b *= 2; 
    
    WriteLine($"Age is : {b}");
    a += 1;
} while (a < peoplesAge.Length);

int counter = 0;
do
{
    ++counter;
    WriteLine($"Processing Pending Background Transactions {counter}");
    await Task.Delay(500);

} while (whileWeStillHavePendingTransactionToProcess());



bool whileWeStillHavePendingTransactionToProcess() =>  counter < 10;

//While LOOP
WriteLine("WHILE LOOP ");
int c = 0, d = 0;
while (c < peoplesAge.Length) // while this condition is valid
{
    d = peoplesAge[c];
    if (d < 30) d *=  2;
   
    WriteLine($"Age Is  : {d}");
    c += 1;
}
