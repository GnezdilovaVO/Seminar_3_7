using static Library;

int[,] naborArr = new int[7, 3];
int[,] naborArr2 = new int[3, 7];
int[,] productArr = new int[0, 0];
naborArr = FillMatrix(naborArr);
naborArr2 = FillMatrix(naborArr2);
PrintArray(naborArr);
Console.WriteLine();
PrintArray(naborArr2);

productArr = GetProdutMatrix(naborArr, naborArr2);
Console.WriteLine();
PrintArray(productArr);