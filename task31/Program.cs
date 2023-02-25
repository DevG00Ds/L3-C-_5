// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int lenght = 12;// int leftRange = -9;// int RightRange = 9;
int[] GetRandomArray(int lenght, int leftRange, int RightRange)
{

    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, RightRange + 1);
    }
    return array;
}

(int, int) SumPositiveAndNegativeElements(int[] array)
{
    int SumPositive = 0;//Сумма положительных чисел 
    int SumNegative = 0;//Сумма отрицательных чисел

    for( int i = 0; i < array.Length; i++)
    {
        if ( array[i]> 0)
        {
            SumPositive = SumPositive + array[i];
        }
        else if ( array[i]<0)
        {
            SumNegative = SumNegative + array[i];
        }    
    }
    return(SumPositive,SumNegative);
}

int [] myArray = GetRandomArray(12,-9, 9);
Console.WriteLine($"[{string.Join(",", myArray)}]");
(int SumP, int SumN) = SumPositiveAndNegativeElements(myArray);
Console.WriteLine($"Сумма положительных элементов : {SumP}");
Console.WriteLine($"Сумма отрицательных элементов : {SumN}");



