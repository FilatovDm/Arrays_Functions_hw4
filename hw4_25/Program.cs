/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. 
Решить задачу с использованием методов.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int DegreeNum(int a, int b)
{
    int degreeNum = Convert.ToInt32(Math.Pow(a, b));

    /* Либо с циклом ниже:
    int degreeNum = a;
    for (int i = 1; i < b; i++)
    {
        degreeNum = degreeNum * a; 
    }
    */
    
    return degreeNum;
}

Console.Write("Введите через пробел два числа: ");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int a = Convert.ToInt32(splitString[0]);
int b = Convert.ToInt32(splitString[1]);

int dgrNum = DegreeNum(a, b);
Console.WriteLine($"Число {splitString[0]} в степени {splitString[1]} = {dgrNum}");
