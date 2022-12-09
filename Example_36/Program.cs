// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
    return arr;
}

int[] arr = FillingArray(num);
Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.WriteLine("]");

int FindSumOfNumbersAtOddPositions(int[]array)
{
    int sum = 0;
     for (int i = 0; i < array.Length; i++)
     {
        if (i % 2 != 0)
        {
            sum += array[i]; 
        }
     }
     return sum;
}
int result =FindSumOfNumbersAtOddPositions(arr);

Console.Write($"Сумма элементов массива стоящих на нечетных позициях: {result}");