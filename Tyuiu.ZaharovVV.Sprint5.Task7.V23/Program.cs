using Tyuiu.ZaharovVV.Sprint5.Task7.V23.Lib;

namespace Tyuiu.ZaharovVV.Sprint5.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = $@"C:\DataSprint5\InPutDataFileTask7V23.txt";
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V23.txt";


            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле : ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();

        }
    }
}