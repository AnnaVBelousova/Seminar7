
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void PrintArray(double[,]matrix)
{
// int rows; 
// int column;
// int[,]matrix = new int [0, 1];
for (int rows = 0; rows < matrix.GetLength(0); rows ++)
{
    for (int column = 0; column < matrix.GetLength(1); column ++)
    {
      Console.Write($" {matrix[rows, column]}");
    }
    Console.WriteLine();
}
}
    void FillArray (double[,]matrix)
{
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
       for (int j  = 0; j< matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().NextDouble()+new Random().NextDouble()*10+new Random().NextDouble()*100; 
        }
    }

}


int m  = int.Parse (Console.ReadLine());
int n  = int.Parse (Console.ReadLine());
double[,]matrix = new double [m, n];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);