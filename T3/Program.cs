/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -10, 11);
Console.WriteLine("Массив: ");
PrintArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < size; j++)
{
    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
}
Console.WriteLine($"В массиве всего {size} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

int [] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max + 1);
    }
return result;
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
