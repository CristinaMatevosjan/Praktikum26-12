void FillArray(int[] col, int min, int max)
{
    int size=col.Length;
    for (int i = 0; i <size; i++)
    {
        col[i]=new Random().Next(min,max);
    }
}

void PrintArray(int[] array)
{
    int count=array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.Write("введите M: ");
int lengthM = int.Parse(Console.ReadLine());
int[] Numbers = new int[lengthM];
FillArray (Numbers, 1, 20);
PrintArray (Numbers);
 Console.WriteLine();