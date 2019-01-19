using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0724144
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary",3.5, 20);
            StudentInformation _John = new StudentInformation("John",2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark",0.2, 3);
            StudentInformation _Steve = new StudentInformation("Steve",2.9, 16);
            StudentInformation _Cindy = new StudentInformation("Cindy",2.8, 18);
            var StudentList = new List<StudentInformation>();
            StudentList.Add(_Mary);
            StudentList.Add(_John);
            StudentList.Add(_Mark);
            StudentList.Add(_Steve);
            StudentList.Add(_Cindy);

            foreach (var student in StudentList)
            {
                Console.WriteLine(student.name);

            }
            Console.ReadLine();
        }
    }

    class StudentInformation
    {
        public string name;
        public double GPA;
        public int attend;

        public StudentInformation(string aName, double aGPA, int aattend)
        {
            name = aName; 
            GPA = aGPA;
            attend = aattend;
        }
    }
    

    class StudentList
    { 
        public void CICS()
        {

        }
    }


}
