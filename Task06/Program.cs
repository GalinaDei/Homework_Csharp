// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter a number");
string number = Console.ReadLine ();
int Number = int.Parse(number);
int residue = Number % 2;
if (residue == 0)
{
   Console.WriteLine($"{Number} -> да");   
}
else
{
    Console.WriteLine($"{Number} -> нет");
}