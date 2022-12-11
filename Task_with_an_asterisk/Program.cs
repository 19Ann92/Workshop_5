// Дополнительная задача (задача со звёздочкой): Задайте одномерный 
// массив, заполненный случайными числами. Из входного массива сформируйте 
// массив с чётными и массив с нечётными значениями элементов входного 
// массива. Найдите ср. арифметическое из полученных значений элементов 
// массивов и выведите результат сравнения средних арифметических.

// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными 
// числами > средн. арифм. значений элементов с нечётными числами
// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными 
// числами > средн. арифм. значений элементов с чётными числами
// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными 
// числами = средн. арифм. значений элементов с чётными числами

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

int[] arr = FillingArray(num);
Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.WriteLine("]");

int[] FillArrayWithEvenElements(int[] array)
{
    int[] evenArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenArray[i] = array[i];
        }
    }
    return evenArray;
}

int[] evenArray = FillArrayWithEvenElements(arr);

Console.Write("Массив с четными числами: ");
Console.Write("[");
Console.Write(String.Join(", ", evenArray));
Console.WriteLine("]");

int ArithmeticMean1 = FindArithmeticMean(evenArray);
Console.WriteLine($"Cредн. арифм. значений элементов массива с чётными числами: {ArithmeticMean1}");

int[] FillArrayWithOddElements(int[] array)
{
    int[] oddArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            oddArray[i] = array[i];
        }
    }
    return oddArray;
}

int[] oddArray = FillArrayWithOddElements(arr);

Console.Write("Массив с нечетными числами: ");
Console.Write("[");
Console.Write(String.Join(", ", oddArray));
Console.WriteLine("]");

int FindArithmeticMean(int[] array)
{
    int sum = 0;
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
        sum = sum + array[i];
        position += 1;
        }
    }
    int ArithmeticMean = sum / position;
    return ArithmeticMean;
}

int ArithmeticMean2 = FindArithmeticMean(oddArray);
Console.Write($"Cредн. арифм. значений элементов массива с нечётными числами: {ArithmeticMean2}");



