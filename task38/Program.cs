// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[6];

doubleArray(array);
PrintArray(array);
System.Console.WriteLine();
double resoult = maxNum(array) - minNum(array);
System.Console.WriteLine($"Разница между min и max = {Math.Round(resoult, 4)}");

double maxNum(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    return maxNum;
}

double minNum(double[] arr)
{
    double minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }    
    }
    return minNum;
}

void doubleArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}