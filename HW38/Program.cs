Console.Clear();
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
int arraySize = array.Length;

for (int i = 0; i < arraySize; i++)
{
    array[i] = Math.Round(new Random().NextDouble()*100, 3);
}
Console.WriteLine($"Array: [{String.Join(", ", array)}]");
double max = array[0];
double min = array[0];
for (int i = 1; i < arraySize; i++){
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
Console.WriteLine($"Максимальный элемент = {max}; Минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами  = {max-min}");