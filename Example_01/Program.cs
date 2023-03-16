using static Library2;
using static Library3;
using static Library_fill;
int[,] arrayA = new int[3, 4];
int[,] arrayB = new int[3, 4];
arrayA = FillMatrix(arrayA);
arrayB = FillMatrix(arrayB);
printArray(arrayA);
Console.WriteLine();
printArray(arrayB);
int[,] result = GetSumMatrix(arrayA, arrayB);
Console.WriteLine();
printArray(result);



