Console.Clear();
int[] FillArray(int size)
{
    Console.Write("Включаем рандомайзер и получаем... ");
    Console.WriteLine();
    int[] array = new int[size];
    for(int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-50; 150);
    }
    return array;
}


