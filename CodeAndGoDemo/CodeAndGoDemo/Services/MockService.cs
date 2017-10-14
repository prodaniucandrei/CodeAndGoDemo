using CodeAndGoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CodeAndGoDemo.Services
{
    public class MockService
    {
        public MockService()
        {

        }

        public IEnumerable<Student> GetStudenti()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Nume="Marian Dan",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=8.5,
                    CuTaxa=false,
                    GrupaId=1
                },
                new Student()
                {
                    Nume="Alex Bob",
                    Varsta=22,
                    Facultate ="ET",
                    Medie=8,
                    CuTaxa=false,
                    GrupaId=1
                },
                new Student()
                {
                    Nume="Dan Decebal",
                    Varsta=21,
                    Facultate ="ETC",
                    Medie=8.7,
                    CuTaxa=false,
                    GrupaId=1
                },
                new Student()
                {
                    Nume="Simon Miron",
                    Varsta=23,
                    Facultate ="AC",
                    Medie=8,
                    CuTaxa=false,
                    GrupaId=1
                },
                new Student()
                {
                    Nume="Ilie Dinu",
                    Varsta=20,
                    Facultate ="Mec",
                    Medie=7.8,
                    CuTaxa=false,
                    GrupaId=2
                },
                new Student()
                {
                    Nume="Haralamb Petrică",
                    Varsta=20,
                    Facultate ="ETC",
                    Medie=9,
                    CuTaxa=false,
                    GrupaId=2
                },
                new Student()
                {
                    Nume="Dănuț Ioan",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=7,
                    CuTaxa=false,
                    GrupaId=3
                },
                new Student()
                {
                    Nume="Serafim Nicușor",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=9.8,
                    CuTaxa=false,
                    GrupaId=3
                },
                new Student()
                {
                    Nume="Corneliu Serafim",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=9.5,
                    CuTaxa=false,
                    GrupaId=4
                },
                new Student()
                {
                    Nume="Sandu Costică",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=8.1,
                    CuTaxa=false,
                    GrupaId=4
                },
                new Student()
                {
                    Nume="Gheorghe Denis",
                    Varsta=20,
                    Facultate ="ETC",
                    Medie=7.5,
                    CuTaxa=false,
                    GrupaId=5
                },
                new Student()
                {
                    Nume="Florin Remus",
                    Varsta=24,
                    Facultate ="AC",
                    Medie=8.6,
                    CuTaxa=false,
                    GrupaId=5
                },
                new Student()
                {
                    Nume="Theodor Alin",
                    Varsta=20,
                    Facultate ="Arh",
                    Medie=8.3,
                    CuTaxa=false,
                    GrupaId=6
                },
                new Student()
                {
                    Nume="Flaviu Nicușor",
                    Varsta=20,
                    Facultate ="Mec",
                    Medie=9.2,
                    CuTaxa=false,
                    GrupaId=6
                },
                new Student()
                {
                    Nume="Mitică Vasilică",
                    Varsta=19,
                    Facultate ="AC",
                    Medie=8.9,
                    CuTaxa=false,
                    GrupaId=6
                },
                new Student()
                {
                    Nume="Vasile Ioan",
                    Varsta=22,
                    Facultate ="AC",
                    Medie=7.6,
                    CuTaxa=false,
                    GrupaId=6
                },
                new Student()
                {
                    Nume="Bogdan Florin",
                    Varsta=21,
                    Facultate ="ETC",
                    Medie=8.2,
                    CuTaxa=false,
                    GrupaId=6
                },
                new Student()
                {
                    Nume="Teodor Mihăiță",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=8.4,
                    CuTaxa=false,
                    GrupaId=1
                },
                new Student()
                {
                    Nume="Marin Răzvan",
                    Varsta=20,
                    Facultate ="ET",
                    Medie=9.5,
                    CuTaxa=false,
                    GrupaId=5
                },
                new Student()
                {
                    Nume="Liviu Dorin",
                    Varsta=20,
                    Facultate ="AC",
                    Medie=8.3,
                    CuTaxa=false,
                    GrupaId=4
                },
            };
        }

        public IEnumerable<Grupa> GetGrupe()
        {
            return new List<Grupa>
            {
                new Grupa
                {
                    Id=1,
                    Nume="1.1",
                    NumarStudenti=15
                },
                new Grupa
                {
                    Id=2,
                    Nume="1.2",
                    NumarStudenti=12
                },
                new Grupa
                {
                    Id=3,
                    Nume="2.1",
                    NumarStudenti=11
                },
                new Grupa
                {
                    Id=4,
                    Nume="2.2",
                    NumarStudenti=18
                },
                new Grupa
                {
                    Id=5,
                    Nume="3.1",
                    NumarStudenti=15
                },
                 new Grupa
                {
                    Id=6,
                    Nume="3.2",
                    NumarStudenti=10
                }
            };
        }

        public Student Find(List<Student> students, int varsta)
        {
            //var student = from s in students
            //              where s.Varsta == varsta
            //              select s;

            var student = students.First(s => s.Varsta == varsta);
            var mock = new MockService();
            var res = (from g in mock.GetGrupe()
                      join t in mock.GetStudenti() on g.Id equals t.GrupaId
                      select new { nume = t.Nume }).ToList();



            return student;
            
        }
    }
}
