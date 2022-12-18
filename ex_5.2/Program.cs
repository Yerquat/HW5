// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//Console.Write($"{ar[i]}, ");
int SumOddIndex(int[] array)
{   
    int summ = 0;
    
    for (int i = 0; i < (array.Length - 1) / 2; i++)
    {
       int j = 0;
        j = 2 * i + 1;
        summ = summ + array[j];
    }
   return summ;
}


int[] massiv(int count, int left, int right)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(left, right + 1);
    }
    return array;
}

int[] array = massiv(7, 1, 100);
Console.WriteLine(String.Join(" ", array));
int B = SumOddIndex(array);
Console.WriteLine($"В выведенном массиве сумма элементов на нечетных позициях равно: {B}");