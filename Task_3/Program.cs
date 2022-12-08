// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
// массива.
// // [3 7 22 2 78] -> 76
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

int maxNumber=array[0];
int minNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    
        if(maxNumber<=array[i])
        {
            maxNumber=array[i];
        }
        if (minNumber>=array[i])
    {
                minNumber=array[i];
    }
}
int result = maxNumber - minNumber;
Console.WriteLine("разница между max и min элементами массива = " + result);
