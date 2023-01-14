using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;


public static class FileSystem
{
    public static void SaveInformation(this string information, string filePath)
    {
        using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
        {
            sw.WriteLine(information);
        }
    }
    public static string GetInformation(this string filePath)
    {
        string information;
        using (StreamReader sr = new StreamReader(filePath))
        {
            information = sr.ReadToEnd();
        }
        return information;
    }
}
