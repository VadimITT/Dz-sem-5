
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("наш массив: ");
PrintArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
    if (array[z] % 2 == 0)
        count++;

Console.WriteLine($"всего {array.Length} чисел, {count} чисел чётные");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   
    Console.WriteLine();
}