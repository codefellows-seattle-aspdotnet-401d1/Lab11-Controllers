using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11George.Controllers
{
    public class StudentsController
    {
        public string Index() => "This is the student controller.";
        [Route("AddStudent")]
        // This is called model binding
        public string Student(string name, int age)
        {
            if (name != "" || age != 0)
            {
                return "No movie input";
            }
            else
            {
                try
                {
                    if (!File.Exists(filePath))
                    {
                        CreateFile();
                    }
                    else
                    {
                        AppendFile(name, age);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("The Directory you suggested does not exist");
                }
                return $"Student name is {name} and age is {age}.";
            }
        }
        [Route("ShowStudents")]
        public string[] Read()
        {
            return ReadFile();
        }

        // file I/O code
        private static string filePath = @"studentFile.txt";
        // create the file if it doesn't exist
        private static void CreateFile()
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("The Professional 1994");
            }
        }
        // add a word to the file C in CRUD
        private static void AppendFile(string name, int year)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{name} {year}");
            }
        }
        // read the file R in CRUD
        private static string[] ReadFile()
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string[] words = File.ReadAllLines(filePath);
                return words;
            }
        }
    }
}
//  2 actions