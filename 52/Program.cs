// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4 
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
double ArifmeticMiddle = 0;
double summa = 0;
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 20);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}\t");
        Console.WriteLine();
    }
}

int rows = Convert.ToInt32(new Random().Next(4, 4));     //Ввели число строк (СЛУЧАЙНО)
int cols = Convert.ToInt32(new Random().Next(4, 4));     // Ввели число столбцов (СЛУЧАЙНО)
int[,] array = new int[rows, cols];                      // задали массив размером rows на cols
FillArray(array);                                       //обратились к функции, заполнили "ячейки"(сам массив)
PrintArray(array);
FindMiddle(array);                                      //обратились к функции, вывели заполненный массив в терминате
void FindMiddle(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)           //"Переворачиваем" считывание массива
    {
        summa = 0;
        for (int i = 0; i < array.GetLength(1); i++)
            summa = array[i, j] + summa;
        ArifmeticMiddle = summa / array.GetLength(1);
        Console.Write($"[{ArifmeticMiddle}] ");

    }
}

