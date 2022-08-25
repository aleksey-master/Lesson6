//  Сгенерировать двумерный массив со случайными числами, вывести его на экран, оформить в виде функций

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

double[,] matrix = new double[10, 10];

void FillMatrix(double[,] matrix)
{
    double rows = matrix.GetLength(0);
    double column = matrix.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * 100;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write("{0,6:f2}", matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}
FillMatrix(matrix);
System.Console.WriteLine("");
PrintMatrix(matrix);
