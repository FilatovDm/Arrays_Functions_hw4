/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumDigits(int number)
{
    int sumDigits = 0;
    int num = Math.Abs(number);
    
    while (num != 0)
    {
        sumDigits = sumDigits + num % 10;
        num = num / 10;
    }

    return sumDigits; 
}

Console.Write("Введите число: ");
int imputNumber = int.Parse(Console.ReadLine());

int sum = SumDigits(imputNumber);
Console.WriteLine($"Сумма всех цифр числа {imputNumber}: {sum}");
