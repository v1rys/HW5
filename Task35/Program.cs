// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении
//  сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] MassivRandom(int size)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(1, 1000);
    }
    return array;
}

int FindTheNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 | array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] arr = MassivRandom(123);
Console.Write(string.Join(",", arr));
Console.WriteLine();
int count = FindTheNumber(arr);
Console.Write(count);