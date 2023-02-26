// Задача 35:
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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
        array[i] = new Random().Next(1, 150);
    }
    return array;
}

int lenght = ReadNumber("Введите длинну Массива : ");
int leftRange = ReadNumber("Введите левую границу вашего Массива : ");
int RightRange = ReadNumber("Введите правую границу вашего Массива : ");

int[] array = GetRandomArray(lenght, leftRange, RightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;


for (int i = 0; i < array.Length; i++)
{
    if ( array[i] > 10 && array[i] > 99)
    {
        count+=1;
    }
}
Console.WriteLine($"Всего {array.Length} числа, количество элементов в отрезке [10,99] {count}");