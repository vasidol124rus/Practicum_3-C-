Console.Clear();
int[] FillArray(int size)
{
    Console.Write("Включаем рандомайзер и получаем... ");
    Console.WriteLine();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}
void PrintArray(int[] ElemArray)
{
    Console.Write("Наш массив: ");
    for(int i = 0; i < ElemArray.Length; i++)
    {
        Console.Write(ElemArray[i] + " ");
    }
}
void Filter(int[] elements) 
{ 
    int[] n = new int[elements.Length];
    Console.WriteLine(); 
    Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); 

    for (int i = 0; i < elements.Length; i++) 
    { 
        if (elements[i] >= 20 && elements[i] <= 90) 
        { 
            Console.Write(elements[i] + " ");
            n[i] = elements[i];
        } 
    }
    int countWithoutZero = n.Count(x => x != 0);
    Console.WriteLine();
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {countWithoutZero}");
}

int sizeMass = 10;
int[] mass = FillArray(sizeMass);
PrintArray(mass);
Filter(mass);