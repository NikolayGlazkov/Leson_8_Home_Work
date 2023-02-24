Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

// создаем словарь
Dictionary<char, int> charFrequency = new Dictionary<char, int>();

// проходимся по каждому символу строки
foreach (char c in input)
{
    // проверяем, есть ли такой символ уже в словаре
    if (charFrequency.ContainsKey(c))
    {
        // если есть, то увеличиваем счетчик
        charFrequency[c]++;
    }
    else
    {
        // если нет, то добавляем символ в словарь со счетчиком 1
        charFrequency.Add(c, 1);
    }
}

// выводим результат
foreach (KeyValuePair<char, int> pair in charFrequency.OrderByDescending(p => p.Value))
{
    double frequency = (double)pair.Value / input.Length * 100;
    Console.WriteLine("Символ {0} встречается {1} раз. Частота {2:F2}%", pair.Key, pair.Value, frequency);
}
