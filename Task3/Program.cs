    
    
        Random random = new Random();
        double[] elem = new double[10];
        
        for (int i = 0; i < 10; i++)
        {
            elem[i] = random.NextDouble() * 100; 
        }
        
        double min = elem[0];
        double max = elem[0];
        
        foreach (var number in elem)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        double difference = max - min;
        Console.WriteLine("Максимальный элемент массива: " + max);
        Console.WriteLine("Минимальный элемент массива: " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);