// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] randomArray (int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
int random = new Random().Next(4,15);
int [] Array = randomArray(random, 100, 1000);

int evenNumbers (int [] arrayWithNumbers)
{
    int acc = 0;
    for (int i = 0; i < arrayWithNumbers.Length; i++)
    {
        // if (arrayWithNumbers[i] % 2 == 0)
        // {
        //     ++acc;
        // }
        // else 
        // {
        //     continue;
        // }
        acc = arrayWithNumbers[i] % 2 == 0 ? acc + 1: acc + 0;
    }
    return acc;
}
Console.Write("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine("]");
Console.WriteLine ($"Amount of even numbers = {evenNumbers(Array)}");