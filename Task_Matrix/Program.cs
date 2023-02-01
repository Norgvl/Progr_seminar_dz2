/*Произведение матриц
(Время: 1 сек.Память: 16 Мб Сложность: 21 %)
Заданы две целочисленные матрицы A и B.
    Матрица A состоит из N строк и M столбцов, Матрица B состоит из M строк и P столбцов. Требуется вычислить произведение данных матриц A*B.*/

int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int P = int.Parse(Console.ReadLine());
int[,] matrixA = new int[N, M];
int[,] matrixB = new int[M, P];

for (int i = 0; i < N; i++)
{
    for(int j = 0; j < M; j++)
    {
        matrixA[i, j] = new Random().Next(1,10);
        Console.Write(matrixA[i, j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < P; j++)
    {
        matrixB[i, j] = new Random().Next(1, 10);
        Console.Write(matrixB[i, j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine();
int[,] productOfMatrix = new int[N, P];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < P; j++)
    {
        for (int k = 0; k < M; k++)
        {
            int prod = matrixA[i, k] * matrixB[k, j];
            productOfMatrix[i, j] = productOfMatrix[i, j] + prod;
        }
     Console.Write(productOfMatrix[i, j] + " ");
        
    }
    Console.WriteLine(" ");
}