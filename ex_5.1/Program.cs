// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNum(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) n = n + 1;
    }
    return n;
}


int[] massiv(int count, int left, int right)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(left, right);
    }
    return array;
}
int[] array = massiv(10, 100, 1000);
Console.WriteLine(String.Join(" ", array));
int amount = EvenNum(array);
Console.WriteLine($"Количество четных чисел равно: {amount}");



