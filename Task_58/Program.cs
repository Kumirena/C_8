/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = GetNumber("Введите количество строк 1-й матрицы: ");
int n = GetNumber("Введите количество столбцов 1-й матрицы (и строк 2-й матрицы): ");
int p = GetNumber("Введите количество столбцов 2-й матрицы: ");
int range = GetNumber("Введите диапазон случайных чисел: от 1 до ");

int[,] Matrix1 = new int[m, n];
CreateArray(Matrix1);
Console.WriteLine($"Первая матрица:");
WriteArray(Matrix1);

int[,] Matrix2 = new int[n, p];
CreateArray(Matrix2);
Console.WriteLine($"Вторая матрица:");
WriteArray(Matrix2);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(Matrix1, Matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matrix1.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int GetNumber(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
  }
}