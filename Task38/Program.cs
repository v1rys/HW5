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
    double MinPositions2 = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int MinPositions = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[MinPositions])
            
                MinPositions = j;
            
        }
        double temporary = array[i];
        array[i] = array[MinPositions];
        array[MinPositions] = temporary;
        MinPositions2 = array[MinPositions]; 

    }
    return MinPositions2;

}

double SelectionSortMax(double[] array)
{
    double MaxPositions2 = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int MaxPositions = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MaxPositions])
            
                MaxPositions = j;
            
        }
        double temporary = array[i];
        array[i] = array[MaxPositions];
        array[MaxPositions] = temporary;
        MaxPositions2 = array[MaxPositions];

    }
    return MaxPositions2;

}

double[] arr = MassivRandom(10);
//double [] arr ={1,2,3,4,5,6,7,8,9,10};
Console.Write(string.Join(",", arr));
double min = SelectionSortMin(arr);
double max = SelectionSortMax(arr);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным значением {max}-{min} = {max - min}");