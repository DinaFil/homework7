Console.WriteLine("Ведите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(1, 10);
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

FindElement(array2d);

void FindElement(int[,] collection)
{
    Console.WriteLine("Ведите элемент, индекс которого необходимо найти: ");
    int element = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int j = 0;
    int l = collection.GetLength(0);
    int p = collection.GetLength(1);
    for (i = 0; i < l; i++)
    {
        for (j = 0; j < p;)
        {
            if (element == collection[i, j])
            {
                Console.WriteLine($"Индекс заданного элемента {i}, {j}");
                j++;
            }
            else j++;
        }
    }
}


