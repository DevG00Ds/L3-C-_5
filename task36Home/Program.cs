// Задача 36.
// Задайте одномерный массив, Заполненый случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
// Random.Shared.Next(leftRange, RightRange + 1)
int lenght = ReadNumber(" Задайте длинну массива : ");
int leftRange = ReadNumber(" Задайте левый диапозон чисел : ");
int RightRange = ReadNumber(" задайте правый диапозон чисел : ");

int[] array = GetRandomArray(lenght, leftRange, RightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");

int SumNegative = 0;

for (int i = 0; i < array.Length; i+=2)
{

    SumNegative = SumNegative + array[i];   
    
}

Console.WriteLine($"Всего {array.Length} чисел, сумма чисел на не четных позициях {SumNegative} ");


