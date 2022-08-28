// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] MassivRandom(int size)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(1, 1000);
    }
    return array;
}
double SelectionSortMin(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPositions = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPositions])
            {
                MinPositions = j;
            }
        }
        double temporary = array[i];
        array[i] = array[MinPositions];
        array[MinPositions] = temporary;

    }
    return array;

}

double SelectionSortMax(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MaxPositions = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[MaxPositions])
            {
                MaxPositions = j;
            }
        }
        double temporary = array[i];
        array[i] = array[MaxPositions];
        array[MaxPositions] = temporary;

    }
    return array;

}

double[] arr = MassivRandom(10);
Console.Write(string.Join(",", arr));
double min = SelectionSortMin(arr);
double max = SelectionSortMax(arr);
Console.WriteLine($"Разница {max}-{min} = {max - min}");