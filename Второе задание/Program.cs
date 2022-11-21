/* Напишите программу, которая будет принимать от пользователя позицию (M, N) 
двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
Если такой позиции в массиве нет, то сообщить об этом пользователю. 
Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе. */

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(min, max +1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + ";");
        }
        Console.Write("]");
        Console.WriteLine(".");
    }
}

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < array.GetLength(0) && n < array.GetLength(1)) 
{
    System.Console.WriteLine($"Значение по введенным данным = {array[m, n]}.");
}
else 
    System.Console.WriteLine($"Введенные позиции {m}" + "," + $"{n} отсутствуют в массиве.");
