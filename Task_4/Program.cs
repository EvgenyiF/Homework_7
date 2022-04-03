// Напишите программу которая принимает число и проверяет есть ли оно в массиве и выводит его позицию.
const int weigth = 5;
const int Heigth = 5;

void init_matrix(int[,] local_matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < weigth; i++)
    {
        for (int j = 0; j < Heigth; j++)
        {
            local_matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void print_matrix(int[,] local_matrix)
{
    for (int i = 0; i < weigth; i++)
    {
        Console.Write("[");
        for (int j = 0; j < Heigth; j++)
        {
            Console.Write("{0,4}", local_matrix[i, j]);
        }
        Console.WriteLine("  ]");
    }
}

void Poisk(int[,] local_matrix, int b)
{
    int count = 0;
    Console.Write($"Индексы числа {b} в массиве: ");
    for (int i = 0; i < weigth; i++)
    {
        for (int j = 0; j < Heigth; j++)
        {
            if (local_matrix[i, j] == b)
            {
                count += 1;
                Console.Write($" [{i}, {j}]; ");

            } 
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Число {b} встречается {count} раз");
    if (count == 0) Console.Write($"Числа {b} нет в массиве");
}

Console.Write("Введите число которое хотите проверить:");
int a = Convert.ToInt16(Console.ReadLine());
int[,] array = new int[weigth, Heigth];
init_matrix(array);
print_matrix(array);
Poisk(array, a);