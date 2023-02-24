Console.WriteLine("Веди ширину массива");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("Веди высоту массива");
int height = int.Parse(Console.ReadLine());

int[,] myArr = new int[height, width];
Random ran = new Random();

// Инициализируем данный массив
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
       myArr[i, j] = ran.Next(1, 9);
       Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}

// Находим минимальный элемент и его индексы
int min = myArr[0, 0];
int min_i = 0, min_j = 0;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (myArr[i, j] < min)
        {
            min = myArr[i, j];
            min_i = i;
            min_j = j;
        }
    }
}

// Удаляем строку и столбец, содержащие минимальный элемент
int[,] resultArr = new int[height - 1, width - 1];
int row = 0, col = 0;
for (int i = 0; i < height; i++)
{
    if (i != min_i)
    {
        for (int j = 0; j < width; j++)
        {
            if (j != min_j)
            {
                resultArr[row, col] = myArr[i, j];
                col++;
            }
        }
        row++;
        col = 0;
    }
}

// Выводим результат
Console.WriteLine("Массив после удаления строки и столбца, содержащих минимальный элемент:");
for (int i = 0; i < height - 1; i++)
{
    for (int j = 0; j < width - 1; j++)
    {
        Console.Write(resultArr[i, j] + " ");
    }
    Console.WriteLine();
}
