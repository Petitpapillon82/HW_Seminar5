/*Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size,100,1000);
Console.WriteLine("Массив: ");
PrintArray(array);

int count = 0;
for (int j = 0; j < size; j++)
if (array[j] % 2 == 0)
count++;

Console.WriteLine($"В массиве {size} чисел, из них чётных чисел: {count}");

int [] GetArray(int size, int min, int max){
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