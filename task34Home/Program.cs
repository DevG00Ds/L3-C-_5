// Задача 34.
// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

// [345, 897, 568, 238] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

int[] GetRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

GetRandomArray(array);
Console.WriteLine("Вот наш массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        count++;
    }

Console.WriteLine($"Всего {array.Length} чисел, из них {count} ЧЕТНЫХ");





