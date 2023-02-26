// Задача 34.
// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

// [345, 897, 568, 238] -> 2


int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GetRandomArray(int lenght, int leftRange, int RightRange)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int lenght = ReadNumber(" Задайте длинну массива : ");
int leftRange = ReadNumber(" Задайте левый диапозон чисел : ");
int RightRange = ReadNumber(" задайте правый диапозон чисел : ");

int[] array = GetRandomArray(lenght, leftRange, RightRange);

Console.WriteLine("Вот наш массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        count++;
    }

Console.WriteLine($"Всего {array.Length} чисел, из них {count} ЧЕТНЫХ");
