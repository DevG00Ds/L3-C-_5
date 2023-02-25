// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int [ ] ReverseArray( int [ ] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}



int lenght = ReadNumber("Введите длинну Массива : ");
int leftRange = ReadNumber("Введите левую границу вашего Массива : ");
int RightRange = ReadNumber("Введите правую границу вашего Массива : ");

int [] array = GetRandomArray(lenght,leftRange,RightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", ReverseArray(array))}]");
