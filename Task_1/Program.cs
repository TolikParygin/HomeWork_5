// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
const int SIZE = 10;
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
    
    if (array[index] % 2 == 0)
    {
        sum++;
    }
}
Console.Write("Количество четных элементов массива равно: " + sum);