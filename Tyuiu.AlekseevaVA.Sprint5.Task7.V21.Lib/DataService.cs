using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.AlekseevaVA.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\виктория\Desktop\DataSprint5\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);

            }

            string sline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != '.') && (line[i] != ',') && (line[i] != '!') && (line[i] != '?') && (line[i] != '-'))
                        {
                            sline += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, sline + Environment.NewLine);
                    sline = "";
                }
            }
            return pathSaveFile;
        }
    }
}
