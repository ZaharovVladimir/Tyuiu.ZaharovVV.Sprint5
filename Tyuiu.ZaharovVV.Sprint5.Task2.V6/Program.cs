using Tyuiu.ZaharovVV.Sprint5.Task2.V6.Lib;

namespace Tyuiu.ZaharovVV.Sprint5.Task2.V6;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Захаров В. В. | ИСТНб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #5                                                            *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл   *");
        Console.WriteLine("* Задание #2                                                           *");
        Console.WriteLine("* Вариант #6                                                           *");
        Console.WriteLine("* Выполнила: Захаров Владимир Владимирович | ИСТНб-24-1                *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 3 на 3 элементов,        *");
        Console.WriteLine("* заполненный значениями с клавиатуры. Заменить положительные элементы *");
        Console.WriteLine("* массива на 1, отрицательные на 0. Результат сохранить в файл         *");
        Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                            *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        int[,] matrix = { { -2, 1, 8 },
                          { -4, -7, 8 },
                          { 6, 5, 5 } };
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}