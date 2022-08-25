Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int arraySize = array.Length;

for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"Array: [{String.Join(", ", array)}]");
int result = 0;
for (int i = 0; i < arraySize; i++)
{
    if (array[i] % 2 == 0) result ++;
}
Console.WriteLine($"Количество положительных элементов в массиве = {result}");