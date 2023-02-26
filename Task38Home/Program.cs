// Задача 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

// [3, 7, 22, 2, 78] -> 76




int[] GetRandomArray(int lenght, int leftRange, int RightRange)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, RightRange + 1);
    }
    return array;
}