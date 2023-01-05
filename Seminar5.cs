// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void RndArray (int Size)
{
    int[] array = new int[Size];
    Random rnd = new Random();
    int evenCount = 0;

    for (int i = 0; i < Size; i++)
    {
        array[i] = rnd.Next(100, 1000);
        if (array[i] % 2 == 0) evenCount += 1;
    } 

    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine(evenCount);
}

RndArray(4);