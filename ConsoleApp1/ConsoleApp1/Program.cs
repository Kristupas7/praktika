using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(Console.ReadLine());

            FileInfo[] Files = directory.GetFiles();

            using (StreamWriter sw = File.CreateText("D:/uzduotys/Rezultatai.txt"))
            {
                for (int i = 0; i < Files.Length - 1; i++)
                {
                    string temp = File.ReadAllText(Files[i].FullName);

                    for (int j = i + 1; j < Files.Length; j++)
                    {
                        string temp2 = File.ReadAllText(Files[j].FullName);
                        
                        if(temp == temp2)
                        {
                            if (File.Exists("D:/uzduotys/Rezultatai.txt"))
                            {
                                sw.WriteLine(Files[i] + " | " + Files[j]);

                            }   
                        }   
                    }
                }
            }
        }
    }
}
