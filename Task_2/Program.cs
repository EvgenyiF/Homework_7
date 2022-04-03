// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
//Пример: 1 4 7 2 5 9 2 3 8 4 2 4 Вывод -> 1 4 7 2 5 81 2 9 8 4 2 4

const int m = 5;
const int n = 5;

void init_matrix(int [,] local_matrix)
{
    Random rnd = new Random();
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            local_matrix[i,j] = rnd.Next(-10,10);
        }
    }
}

void print_matrix(int [,] local_matrix)
{
    for(int i=0;i<m;i++)
    {
        Console.Write("[");
        for(int j=0;j<n;j++)
        {
            Console.Write("{0,4}", local_matrix[i,j]);
        }
        Console.WriteLine("  ]");
    }    
}
void Pow_matrix(int [,] local_matrix)
{
    for(int i=0;i<m;i++)
    {        
        for(int j=0;j<n;j++)
        {
            if( i%2!=0 & j%2!=0) 
            {
            local_matrix[i,j] = local_matrix[i,j]*local_matrix[i,j];
            }
        }
    }    
}

int[,] matrix = new int [m,n];
init_matrix(matrix);
print_matrix(matrix);
Console.WriteLine();
Pow_matrix(matrix);
print_matrix(matrix);