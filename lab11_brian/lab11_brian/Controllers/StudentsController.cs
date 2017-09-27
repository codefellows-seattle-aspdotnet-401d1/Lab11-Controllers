﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;


namespace lab11_brian.Controllers
{
    [Route("Register")]
    public class StudentsController : Controller
    {
        public string Index()
        {
            return
                "To begin, you must register a hacker and they will be sorted into their house. Please use: \n /Student?studentName={studentName}";
        }
        [Route("Student")]
        public string Register(string studentName)
        {
            // Couldn't get defualt path to work. Updarte this path for your computer...sorry got reading to do
            string filePath = @"C:\projects\401d1\Labs\lab11_brian\lab11_brian\lab11_brian\Controllers\students.txt";
            using (StreamWriter sw = System.IO.File.AppendText(filePath))
            {
                sw.WriteLine(studentName);
            }
            return $" Ahhh yes ... {studentName} will be placed in {SortedHouse<houses>()}!!!";
        }

        private T SortedHouse<T>()
        {
            T[] houses = (T[])Enum.GetValues(typeof(T));
            return houses[new Random().Next(0, houses.Length)];
        }
        enum houses : int
        {
            CSharp = 1,
            JavaScript,
            Python
        }
    }
}
