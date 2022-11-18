 int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)        //метод вывода на экран массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
