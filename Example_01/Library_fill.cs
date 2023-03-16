public static class Library
{
    public static double[,] FillMatrix(double[,] array)
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