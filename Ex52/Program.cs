
void PrintArray(double[,]matrix)
{

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
           matrix[i,j] = new Random().Next(1,10); 
        }
    }

}

// Заполнение одномерного массива
 void Fill_1d(double[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       // Next() - заполнение случайными неотрицательными числами
        array[index] = 0;
        
        index ++; 
    }
} 
// печать 1мерного массива
string Print1(double[]array)
{
    return String.Join(' ', array);
}

double[] Meanvalue(double[,]matrix)
{
    double[] array = new double [matrix.GetLength(1)];

     
    Fill_1d(array);

    // string array_text = Print1(array);
    // Console.WriteLine(array_text);

    
    
    for (int j  = 0; j< matrix.GetLength(1); j++)
    {
       for (int i  = 0; i< matrix.GetLength(0); i++)
      
       
        { 
           
            array[j] = array[j]+matrix[i,j]/matrix.GetLength(0);

        }

   }



    string array_text = Print1(array);
    Console.WriteLine(array_text);
return array;
}

// int row  = new Random().Next(1,10); 
// int col  = new Random().Next(1,10); 
int row = 3;
int col = 4;

double[,]matrix = new double [row, col];

FillArray(matrix);
PrintArray(matrix);
Meanvalue(matrix);
