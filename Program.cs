using System;
using lab2.models;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student(new Person(), Education.SecondEducation, 4);
            Console.WriteLine(s.toShortString());
            s.Person = new Person("POLIGRAF", "SHARIKOV", DateTime.MaxValue);
            s.Group = 8;
            s.Education = Education.Specialist;
            s.Exams = new[] {new Exam(),};
            Console.WriteLine(s);
            s.addExams(new []{new Exam("MATAN", 4, DateTime.UtcNow), new Exam("PHYSICS", 3, DateTime.Today), new Exam()});
            Console.WriteLine(s);
            testTime(40,40);
        }

        public static void testTime(int length, int height)
        {
            DateTime start = DateTime.Now;
            Exam[] arr1 = new Exam[length*height];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new Exam();
            }
            Console.WriteLine(DateTime.Now-start);
            start=DateTime.Now;
            
            Exam[,] arr2 = new Exam[height,length];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    arr2[i,j]=new Exam();
                }
            }
            Console.WriteLine(DateTime.Now-start);
            start=DateTime.Now;
            
            Exam[][] arr3 = new Exam[height][];
            for (int i = 0; i < height; i++)
            {
                arr3[i] = new Exam[length];
                for (int j = 0; j < length; j++)
                {
                    arr3[i][j]=new Exam();
                }
            }
            Console.WriteLine(DateTime.Now-start);
        }
    }
}