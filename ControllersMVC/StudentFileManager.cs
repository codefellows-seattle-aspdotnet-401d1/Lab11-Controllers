using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersMVC
{
    public class StudentFileManager
    {
        static string fileName = "student-file.txt";
        string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", fileName);

        public String Post(string name, int age)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", "Student-File.txt");
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine($"{name} Age: {age}");
            }

            return $"Saved {name} Age: {age} to database.";
        }

        public string ViewStudents()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                //creates an array of words from the game file
                string[] words = File.ReadAllLines(path);

                string returnString = "";

                //Prints all words to console for user
                foreach (string word in words)
                {
                    returnString += word + "\n";
                }

                return returnString;
            }
        }
    }
}
