// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int[] arr = FillingArray(num);
Console.WriteLine(String.Join(", ", arr));

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int result = FindEvenNumbers(arr);
Console.WriteLine($"Колличество четных чисел в массиве: {result}");