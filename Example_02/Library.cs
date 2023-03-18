public static class Library
{
    public static int[,] GetProdutMatrix(int[,] array1, int[,] array2)
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
        int sum = 0;

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    sum = sum + array1[i, k] * array2[k, j];
                }
                result[i, j] = sum;
                sum = 0;
            }
        }
        return result;
    }
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
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}