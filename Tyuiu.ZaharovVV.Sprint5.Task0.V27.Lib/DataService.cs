﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZaharovVV.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Pow((x - 1), (3 * x + 1));
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}