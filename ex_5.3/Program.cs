// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int Minimum(int[] array)
{   int min = array[0];
     for(int i = 0; i < array.Length; i++)
     {
        //max = array[0];
        if(array[i] < min) min = array[i];
     }
    return min;
}

int Maximum(int[] array)
{   int max = array[0];
     for(int i = 0; i < array.Length; i++)
     {
        //max = array[0];
        if(array[i] > max) max = array[i];
     }
    return max;
}

int[] Array(int count, int left, int right)
{
    int[]ar = new int[count];
    for(int i = 0; i < count; i++)
     ar[i] = new Random().Next(left, right + 1);
    return ar;
}

int[] array = Array(7, 1, 100);
Console.WriteLine(String.Join(" ", array));
int max = Maximum(array);
int min = Minimum(array);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: " + (max - min));

