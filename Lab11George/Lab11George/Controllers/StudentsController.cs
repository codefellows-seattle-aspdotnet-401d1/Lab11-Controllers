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

        //[Route("AddStudent")]
        // This is called model binding
        public string Student(string name, int age)
        {
            if (name != "" && age != 0)
            {

            }
            return $"Student name is {name} and age is {age}.";


        }

 
    }

    /*public class StudentManager
    {
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
        private static void AppendFile(string filePath, string newWord)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(newWord);
            }
        }

        // read the file R in CRUD
        private static string[] ReadFile(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string[] words = File.ReadAllLines(filePath);
                return words;
            }
        }
    }*/
}
//  2 actions