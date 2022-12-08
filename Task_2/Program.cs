// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
const int SIZE = 5;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 100;
int[] array = new int[SIZE];
int[] FillArrayWithRandomNambers(int size, int leftRange, int rightRenge)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRenge + 1);
    }
    return arr;
}

array = FillArrayWithRandomNambers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(",", array) + ']');
int sum = 0;
for (int index = 0; index < array.Length; index++)
{
    if (index % 2 != 0)
    {
        sum = sum + array[index];
    }
}
Console.Write("  Сумма нетных элементов массива равно: " + sum);