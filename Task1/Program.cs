    Console.Clear();   
    {
        Random random = new Random();
        int[] numbers = new int[10];
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = random.Next(1, 101); 
            if (numbers[i] >= 20 && numbers[i] <= 90)
            {
                count++;
            }
        }
        Console.WriteLine($"Массив:  {string.Join(", ", numbers)}");
        Console.WriteLine($"Kоличество элементов массива, значения которых лежат в отрезке [20,90]: " + count);
    }