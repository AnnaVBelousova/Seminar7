
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void PrintArray(int[,]matrix)
{
// int rows; 
// int column;
// int[,]matrix = new int [0, 1];
for (int rows = 0; rows < matrix.GetLength(0); rows ++)
{
    for (int column = 0; column < matrix.GetLength(1); column ++)
    {
      Console.Write($"{matrix[rows, column]}");
    }
    Console.WriteLine();
}

void Fill (int[,]matrix)
{
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
        for (int j  = 0; j< matrix.GetLength(0); j++)
        {
           matrix[i,j] = new Random().Next(1,100); 
        }
    }

}
}

int m  = int.Parse (Console.ReadLine());
int n  = int.Parse (Console.ReadLine());
int[,]matrix = new int [m, n];

PrintArray(matrix);
Fill(matrix);
PrintArray(matrix);