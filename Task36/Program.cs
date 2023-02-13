// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] randomArray (int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int random = new Random().Next(5,15);
int [] Array = randomArray(random, -100, 100);

int notEvenIndex (int [] arrayWithNumbers)
{
    int acc = 0;
    for (int i = 0; i < arrayWithNumbers.Length; i++)
    {
        
        // if (i % 2 != 0)
        // {
        //     acc = acc + arrayWithNumbers[i];
        // }
        // else 
        // {
        //     continue;
        // }
        acc = i % 2 != 0 ? acc + arrayWithNumbers[i] : acc + 0;
    }
    return acc;
}
Console.Write ("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine ("]");
Console.WriteLine ($"Sum of numbers = {notEvenIndex(Array)}");