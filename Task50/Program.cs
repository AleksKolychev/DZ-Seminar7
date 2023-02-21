/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этот элемент или же указание, что такого элемента нет.*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix)
{
    string[] index = Console.ReadLine().Split(' ');
    int n = int.Parse(index[0]);
    int m = int.Parse(index[1]);
    if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
                    Console.WriteLine("Элемента с таким индексом нет");
    {
        for (int i = 0; i <= matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= matrix.GetLength(1); j++)
            {
                   if (n == i && m == j)
                    Console.WriteLine($"{matrix[i - 1, j - 1]}");           
            }
        }        
    }
}        

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите индекс элемента массива: ");
FindElement(matrix);