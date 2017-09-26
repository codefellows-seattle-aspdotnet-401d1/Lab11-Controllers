using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersMVC.Controllers
{
    public class StudentsController : Controller
    {
        StudentFileManager fileManipulator = new StudentFileManager();
        static string fileName = "student-file.txt";
        string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", fileName);

        [Route("students/add")]
        public String AddStudent(string name, int age)
        {
            return fileManipulator.Post(name, age);
        }

        public string ViewStudents()
        {
            return fileManipulator.ViewStudents();
        }
    }
}
