// Задача 33:
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



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
        array[i] = Random.Shared.Next(leftRange, RightRange + 1);
    }
    return array;
}

int lenght = ReadNumber("Длинна Массива : ");
int leftRange = ReadNumber("Граница Левой части Массива : ");
int RightRange = ReadNumber("Граница правой части Массива : ");

int[ ] array = GetRandomArray(lenght,leftRange, RightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(" Введите число : ");

int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

for ( int i =0; i< array.Length; i++)
{
    if (array[i] == number)
    count++;
}
if ( count == 0)
{
    Console.WriteLine("НЕТ");
}
else
{
    Console.WriteLine("ДА");
}


