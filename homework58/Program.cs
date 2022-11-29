int m = 2,
    n = 2;
int[,] mat1 = new int[m, n],
        mat2 = new int[m, n],
        matr = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        mat1[i, k] = rnd.Next(10);
        mat2[i, k] = rnd.Next(10);
    }
}

for (int d = 0; d < m; d++)
{
    for (int i = 0; i < m; i++)
    {
        matr[d, i] = 0;
        for (int k = 0; k < n; k++)
        {
            matr[d, i] += mat1[d, k] * mat2[k, i];
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++) Console.Write("{0} ", mat1[i, k]);
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++) Console.Write("{0} ", mat2[i, k]);
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++) Console.Write("{0} ", matr[i, k]);
    Console.WriteLine();
}