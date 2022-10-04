/*

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] startArray = GetArray (6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Выводим количество чётных элементов в массиве = {GetEvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int GetEvenCount(int[] array)
{
  int count = 0;
  foreach (var item in array)
  {
    if (item % 2 == 0) count++;
  }
  return count;
}

------------------------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] startArray = GetArray (6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Выводим сумму элементов на нечётных позициях = {GetSumOdd(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int GetSumOdd(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0) sum += array[i];
  }
  return sum;
}

------------------------------------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] startArray = GetArray (6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Выводим разницу = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int GetDifference(int[] array)
{
  int max = array[0];
  int min = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }
    else if (array[i] < min)
    {
      min = array[i];
    }
  }
  Console.WriteLine($"max = {max} and min = {min}");
  return max - min;
}

*/