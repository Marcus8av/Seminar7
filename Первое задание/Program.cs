/* Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой. */

void FillArray(double[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
{
        Console.Write("[");
        for (int j = 0; j < n; j++)
{
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write(Math.Round(array[i, j], 2) + ";");
}
        Console.Write("]");
        Console.WriteLine(".");
}
}

System.Console.WriteLine($"Введите размерность двумерного массива");

System.Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillArray(array,m,n);
