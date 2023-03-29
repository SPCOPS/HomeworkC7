void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите номер строки элемента: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n < 1 || m < 1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (n <= size[0] + 1 && m <= size[1] + 1)
Console.Write($"Значение элемента равно {matrix[n-1,m-1]}");
else Console.Write("Такой позиции нет");