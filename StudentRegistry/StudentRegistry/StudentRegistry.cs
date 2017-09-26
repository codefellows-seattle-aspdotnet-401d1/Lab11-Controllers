using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistry
{
    public class StudentRegistry
    {
        public string filePath = "StudentList.txt";
        public string RegisterStudent(string name, int age, int course)
        {
            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                    Byte[] myText = new System.Text.UTF8Encoding(true).GetBytes($"{name}, {age}, {course}");
                    fs.Write(myText, 0, myText.Length);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.Write(Environment.NewLine);
                    sw.WriteLine($"{name}, {age}, {course}");
                }
            }

            return $"{name} added to Student Registry!";
        }

        public string ShowStudents()
        {
            string students = "";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string[] words = File.ReadAllLines(filePath);
                int length = words.Length;
                foreach (string line in words)
                {
                    students += line + "\n";
                }
            }

            return students;
        }
    }
}
