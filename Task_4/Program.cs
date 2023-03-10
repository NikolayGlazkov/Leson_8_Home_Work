int n = 10; // число уровней треугольника

// Создаем двумерный массив для хранения значений треугольника Паскаля
int[,] pascal = new int[n, n];

// Заполняем массив значениями треугольника Паскаля
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
        {
            pascal[i, j] = 1;
        }
        else
        {
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
        }
    }
}

// Выводим треугольник Паскаля в виде равнобедренного треугольника
for (int i = 0; i < n; i++)
{
    // Выводим пробелы для выравнивания значений
    for (int k = 0; k < n - i - 1; k++)
    {
        Console.Write(" ");
    }

    // Выводим значения уровня треугольника Паскаля
    for (int j = 0; j <= i; j++)
    {
        Console.Write(pascal[i, j] + " ");
    }

    Console.WriteLine();
}
