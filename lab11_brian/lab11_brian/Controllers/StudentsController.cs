using System;
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
            studentList.Add(studentName);
            return $" Ahhh yes ... {studentName} will be placed in {SortedHouse<houses>()}!!!";
        }
        static void CreateFile(string filePath)
        {
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                Byte[] info = new UTF8Encoding().GetBytes("");
                fs.Write(info, 0, info.Length);
            }
        }

        private List<string> studentList = new List<string>();
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
