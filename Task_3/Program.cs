int[,,] myArr = new int[3, 3, 3];
Random ran = new Random();

// Инициализируем данный массив
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            int num;
            do
            {
                num = ran.Next(1, 9);
            } while (IsNumInArray(num, myArr));
            myArr[i, j, k] = num;
            Console.Write($"[{i},{j},{k}] = {myArr[i, j, k]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция проверки наличия числа в трехмерном массиве
bool IsNumInArray(int num, int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}
