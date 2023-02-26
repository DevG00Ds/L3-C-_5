// Задача 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

// [3, 7, 22, 2, 78] -> 76


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void GetRandomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

GetRandomArray(array);
Console.WriteLine("Вот наш массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

double Min = 0;
double Max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > Max)
    {
        Max = array[i];
    }
    if (array[i] < Min)
    {
        Min = array[i];
    }
}

Console.WriteLine($"Всего {array.Length} чисел, Макс. значение = {Max}, Мин. значение = {Min}");
Console.WriteLine($" Разница межде максимальным и Минимальным значениями = { Max - Min}");