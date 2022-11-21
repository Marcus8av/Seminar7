/* Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца. */

void FillArrayRandom(double[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + ";");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void Arithmetic(double[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double numm = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            numm = (numm + array[i, j]);
        }
        Console.Write($"Среднее арифмитическое каждого столбца = {numm / array.GetLength(0):f1}"+ "; ");
    }
}
System.Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[n, m]; 
FillArrayRandom(array);
Arithmetic(array);
