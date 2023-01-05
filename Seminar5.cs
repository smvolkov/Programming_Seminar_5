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

//RndArray(4);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void OddPosArray (int Size)
{
    int[] array = new int[Size];
    Random rnd = new Random();
    int oddPosSum = 0;

    for (int i = 0; i < Size; i++)
    {
        array[i] = rnd.Next(-99, 100);
        if (i % 2 != 0) oddPosSum += array[i];
    } 

    Console.WriteLine(String.Join(", ", array));
    Console.WriteLine(oddPosSum);
}

OddPosArray(4);