using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    string path = @"C:\Users\new\source\repos\Student data\Student.txt";
                    string[] lines = File.ReadAllLines(path);
                    Console.WriteLine("The Students Data are \n");
                    int index = 1;
                    foreach (string line in lines)
                        Console.WriteLine($" {index++} : " + line);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("All the Students data in the files are Displayed.");
                }
            }
            Console.ReadLine();
        }
    }

}
