// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Пример:
//m = 3, n = 4. 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9

const int m = 3;
const int n = 4;

void init_matrix(double [,] local_matrix)
{
    Random rnd = new Random();
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            local_matrix[i,j] = rnd.NextDouble()*100;
        }
    }
}

void print_matrix(double [,] local_matrix)
{
    for(int i=0;i<m;i++)
    {
        Console.Write("[");
        for(int j=0;j<n;j++)
        {
            Console.Write("{0,6:f2}", local_matrix[i,j]);
        }
        Console.WriteLine("]");
    }    
}

double [,] matrix = new double [m,n];
init_matrix(matrix);
print_matrix(matrix);