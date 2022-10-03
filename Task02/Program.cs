//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Enter a number");
string firstnumber = Console.ReadLine ();
int firstNumber = int.Parse(firstnumber);
Console.WriteLine("Enter next number");
string secondnumber = Console.ReadLine ();
int secondNumber = int.Parse(secondnumber);
if(firstNumber>secondNumber)
{
    Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {firstNumber}");
} 
else
{
    Console.WriteLine($"a = {firstNumber}; b = {secondNumber} -> max = {secondNumber}");
}