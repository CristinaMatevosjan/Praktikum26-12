void FillArray(int[] col, int min, int max)
{
    int size=col.Length;
    for (int i = 0; i <size; i++)
    {
        col[i]=new Random().Next(min,max);
    }
}