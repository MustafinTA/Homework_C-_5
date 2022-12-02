// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[6];

var newArray = FillArray(array);
PrintArray(newArray);

System.Console.WriteLine();
System.Console.WriteLine(SumNum(newArray));

int SumNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
        sum += array[i];
        }
    }
    return sum;
}

int[] FillArray(int[] arr)
{
    var result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}