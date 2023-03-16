public static class Library_fill
{
    public static int[,] FillMatrix(int[,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(1, 20);
            }
        }
        return array;
    }
}