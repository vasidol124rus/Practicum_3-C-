Console.Clear();
 Random random = new Random();
        int[] elem = new int[10];
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            elem[i] = random.Next(1, 101); 
            if (elem[i] >= 20 &&elem[i] <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов в диапазоне 20 - 90: " + count);
    
