public static class Library3
{
    public static int[,] GetSumMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[3, 4];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }

    }
    return result;
}
}