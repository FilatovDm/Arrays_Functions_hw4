/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран. Элементы массива вводятся пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void PrintArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));

    /* P. S. немного не понял задание =(  
       На всякий случай ниже закоментил цикл
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    */
}

int[] array = new int[8];

Console.Write("Введите через пробел восемь чисел: ");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

if (splitString.Length != 8) 
{
 System.Console.WriteLine("Вы ввели " + splitString.Length + 
                          " элементов. Попробуйте еще раз");
}

else 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(splitString[i]);
    }

    PrintArray(array);
}