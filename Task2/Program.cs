// 50
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseElement(int i, int j, int[,] matrix)
{
    int element = 0;
    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
    {
        element = matrix[i, j];
        Console.WriteLine(element);
    }
    else
        Console.WriteLine("Такой позиции в массиве нет");
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите строку элемента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int j = Convert.ToInt32(Console.ReadLine());
ReleaseElement(i, j, matrix);