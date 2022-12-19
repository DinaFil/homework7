// Задача 47. Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m и n массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[n,m];
double[] array = new double [n * m];
int j = 0;
int i = 0;
int l = 0;
Console.WriteLine("Введите элементы массива, являющиеся вещественными числами, в одну строку через пробел");
array = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries), double.Parse);
double temporary = 0;
for (i = 0;  i < n; i++)
 { 
        for (j = 0; j < m;  j++)
        {temporary = array[l];
        array2d[i,j] = temporary;
        Console.Write(array2d[i,j]+" ");
        l++;
        }
       Console.WriteLine();
        }
        
      
       
 
 