using CodeAndGoDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAndGoDemo.Services
{
    public class RaportGenerator
    {
        private static string _filePath = "studenti.txt";
        public RaportGenerator()
        {

        }

        public async Task SaveStudentInfo(Student student)
        {
            using (StreamWriter sw = new StreamWriter(""))
            {
                sw.WriteLine(student.ToString());
            }
        }
    }
}
