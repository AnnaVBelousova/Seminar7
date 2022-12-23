void PrintArray(int[,]matrix)
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

    void FillArray (int[,]matrix)
{
    for (int i  = 0; i< matrix.GetLength(0); i++)
    {
       for (int j  = 0; j< matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(1,10); 
        }
    }

}


int Valueposition(int i, int j, int[,]matrix)
{
    if (i> matrix.GetLength(0) || j > matrix.GetLength(1) ) 
    {
       Console.WriteLine ("Такого значения нет");
    }
     
   else 
    {
        int value = matrix[i,j];
    }
   {
   return matrix[i,j];
   }
    }
    
   

  

   
     



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int row  = new Random().Next(1,10); 
int col  = new Random().Next(1,10); 
int[,]matr = new int [row, col];


FillArray(matr);
PrintArray(matr);
Valueposition(4,1,matr);

//Valueposition(1,1);
Console.WriteLine(matr[4,1]);





