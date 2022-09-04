/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
n = array.Length;
Console.Write("[");
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
  }
Console.Write("]");

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < array.Length; j++)
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
Console.WriteLine($"В массиве всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

