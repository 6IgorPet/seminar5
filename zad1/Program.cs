// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] newArray = new int[15];  
CreateArray(newArray);
Console.WriteLine($"Массив:[{String.Join(",", newArray)}]");

SumNumbersOddPosition(newArray);

int[] CreateArray(int[] size)
{
     
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(101);
    }
    return size;
}

void SumNumbersOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i] ;
    }
    Console.WriteLine($"Вывод суммы чисел, находящихся на четных позициях  {sum}");
}
