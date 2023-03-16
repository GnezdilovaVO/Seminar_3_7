public static class Library
{
    int[,] GetProdutMatrix(int[,] array1,int[,] array2)
    {
        int[,] result =new int [,];
        int sum = 0;
        for(int i = 0; i<array1.GetLength(0); i++)
        {
            for(int j = 0; j<array1.GetLength(1); j++)
            {
                for(int k = 0; k<array1.GetLength(0); k++)
                {
                    sum = sum +array1[i, k]*array2[j, k]; // вот здесь проверь, я могла напутать с индексами
                }
                result[i, j] = sum;
                sum = 0;
            }
        }
    }



}