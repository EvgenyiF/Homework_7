// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Пример:
//Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

const int m = 6;
const int n = 5;

void init_matrix(int[,] local_matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            local_matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void print_matrix(int[,] local_matrix)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write("[");
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,4}", local_matrix[i, j]);
        }
        Console.WriteLine("  ]");
    }
}

void Mean_matrix(int[,] local_matrix)
{
    double a = 0;
    double mean = 0;
    double[] mean_array = new double[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            a = Convert.ToDouble(local_matrix[j, i]);
            mean = mean + a;
        }
        mean_array[i] = Math.Round(mean/m,3);
        mean = 0;
    }
    Console.Write("[{0}]", string.Join("  ", mean_array));
}
int[,] matrix = new int[m, n];
init_matrix(matrix);
print_matrix(matrix);
Console.WriteLine("");
Mean_matrix(matrix);