// НАПИСАТЬ ПРОГРАММУ МАСШТАБИРОВАНИЯ ФИГУРЫ

// МАСШТАБИРОВАНИЕ РАВНОСТОРОННЕГО ЧЕТЫРЕХУГОЛЬНИКА


int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k) 
{
    int[,] coor = new int[4, 2];                                
    for (int ii = 0; ii < 2; ii++)                                  
    {
        for (int j = 0; j < 2; j++)                                 
        {
            if (ii == j)                                            
            {
                coor[0, j] = a[ii];                                
                coor[1, j] = (b[ii] - a[ii]) * k + a[ii];
                coor[2, j] = (c[ii] - a[ii]) * k + a[ii];
                coor[3, j] = (d[ii] - a[ii]) * k + a[ii];
            }
        }
    }
    return coor;
}

void PrintCords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 2;                   // коэффициент масштабирования
int[] pointA = { 1, 1 };     // координаты точек
int[] pointB = { 2, 3 };     // координаты точек
int[] pointC = { 5, 3 };     // координаты точек
int[] pointD = { 4, 1 };     // координаты точек
char[] pointName = { 'A', 'B', 'C', 'D' };

Console.WriteLine();
Console.WriteLine("Масштабирование");
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCords(newCords, pointName);
