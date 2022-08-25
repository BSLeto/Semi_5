Console.Clear();
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int arraySize = array.Length;

for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(50);
}
Console.WriteLine($"Array: [{String.Join(", ", array)}]");

int sum = 0;

for (int i = 0; i < arraySize; i++)
{
    // нечетные позиции элементов идут непосредственно на array[0] array[2], array[4] ...?
    if (i % 2 == 0) sum += array[i]; 
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");