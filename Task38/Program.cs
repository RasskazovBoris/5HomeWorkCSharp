// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] randomArray (int size, int minValue, int maxValue)
{
    double [] res = new double [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble (new Random().Next (minValue, maxValue))/100;
    }
    return res;
}
int random = new Random().Next(5,15);
double [] Array = randomArray(random, -10000, 10000); // Насколько я помню, вещественные числа в том числе могут быть отрицательными.

Console.Write ("[");
Console.Write(String.Join(" , ", Array));
Console.WriteLine ("]");
double findDifference (double [] arrayWithNumbers)
{
    double min = arrayWithNumbers[0];
    double max = arrayWithNumbers[0];
    for (int i = 0; i < arrayWithNumbers.Length; i++)
    {
        if (arrayWithNumbers[i] > max) max = arrayWithNumbers[i];
        if (arrayWithNumbers[i] < min) min = arrayWithNumbers[i];
        
    }
    return max - min;
    
}
Console.WriteLine 
($"Difference between maximum value of number and minimum value of number = {findDifference(Array)}");