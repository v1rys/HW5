// Задача 34: Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] MassivRandom (int size)
{
   int [] array = new int [size];
   Random rand = new Random();
   
   for(int i =0; i < size; i++)
   {
    array[i] = rand.Next(100,1000); 
   }
   return array;
} 

int ShowEven (int [] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    return count ;
    
}


int [] arr = MassivRandom(10);
Console.WriteLine(string.Join(",", arr));
int count = ShowEven(arr);
Console.WriteLine(count);