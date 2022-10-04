// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
//  максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Enter a number");
string firstnumber = Console.ReadLine ();
int firstNumber = int.Parse(firstnumber);
Console.WriteLine("Enter next number");
string secondnumber = Console.ReadLine ();
int secondNumber = int.Parse(secondnumber);
Console.WriteLine("Enter third number");
string thirddnumber = Console.ReadLine ();
int thirdNumber = int.Parse(thirddnumber);
int max = firstNumber;
if (secondNumber > max)
{
    max = secondNumber;
}
else
{
    if(thirdNumber > max)
    {
        max = thirdNumber;
    }
}
Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} -> {max}");