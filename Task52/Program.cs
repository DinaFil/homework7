Console.WriteLine("Введите числа n и m, которые будут являться длиной строки и высотой столбца вашего двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[n,m];
Console.WriteLine("Введите элементы массива, являющиеся целыми числами, через пробел: ");
    for (int i = 0; i < m; i++)
    {   string[] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = double.Parse(text[j]);
            Console.Write(array2d[i,j] +" ");
        }
    Console.WriteLine();
    }
   


ColumnAverage(array2d);

void ColumnAverage(double[,] collection)
{
double average = 0;
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             average += collection[i,j];
            
        }
        average = average / n;
        Console.WriteLine($"Среднее арифметическое столбца равно {average}");
    }
}


