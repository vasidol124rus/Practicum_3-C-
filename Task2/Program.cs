Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-50, 150);
    }
}

int EvenNubers(int[] array)
{   
    int count = 0;
    foreach (int element in array)
    {   
        if(element % 2 == 0)
            count++;
    }
    return count;
}

int[] array = new int [10];
InputArray(array);
Console.WriteLine($"Создали массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {EvenNubers(array)}");