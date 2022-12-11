// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int count = 0;
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

int rows = Convert.ToInt32(new Random().Next(4, 6));//Ввели число строк (СЛУЧАЙНО)
int cols = Convert.ToInt32(new Random().Next(4, 6));// Ввели число столбцов (СЛУЧАЙНО)
int[,] array = new int[rows, cols]; // задали массив размером rows на cols
FillArray(array); //обратились к функции, заполнили "ячейки"(сам массив)
PrintArray(array);//обратились к функции, вывели заполненный массив в терминате
Console.WriteLine("Введите число, чтобы посмотреть его позицию");
int num = Convert.ToInt32(Console.ReadLine()); // Вводим искомое число
FindNumber(array);
if (count ==0)
{
    Console.Write("Такого числа нет в массиве");
}
int FindNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (num == array[i, j])
            {
                Console.Write($"Позиция этого числа - [{i},{j}]");
                count++;
            }
            return count;
}