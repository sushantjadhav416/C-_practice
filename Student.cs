using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Student
    {
        public static String name;
        public static int studentClass;
        public static float result;
        public Student(String s, int sClass)
        {
            name = s;
            studentClass = sClass;
            Console.WriteLine("Added student: " + s + " to the roll of class: " + sClass);
        }
        String getName()
        {
            return name;
        }
        public static String Publish()
        {
            if (result >= 33.33)
            {
                return (name + " has been promoted to class: " + (studentClass + 1));
            }
            else
            {
                return (name + " has been retained in class: " + studentClass);
            }
        }
    }

    internal class Result : Student
    {
        int subject1, subject2, subject3;
       public  Result(int a, int b, int c, String s, int sClass) : base(s, sClass)
        {

            subject1 = a;
            subject2 = b;
            subject3 = c;
            Console.WriteLine(s + " obtained " + a + " marks in subject1");
            Console.WriteLine(s + " obtained " + b + " marks in subject2");
            Console.WriteLine(s + " obtained " + c + " marks in subject3");
        }

        public String calculateResult()
        {

            Student.result = ((subject1 + subject2 + subject3) * (100) / 300);
            String str = Student.Publish();
            return str;
        }

        String changeMarks(int newMarks, String subject)
        {
            Console.WriteLine(Student.name + " has ordered recheck in " + subject);
            switch (subject)
            {
                case "subject1":
                    subject1 = newMarks;
                    break;
                case "subject2":
                    subject2 = newMarks;
                    break;
                case "subject3":
                    subject3 = newMarks;
                    break;
            }
            return ("Following is the new result: " + calculateResult());
        }

    }


    public class Main_class
    {
        public static void Main(String[] args)
        {
            String name = Console.ReadLine();
            int sclass = Convert.ToInt32(Console.ReadLine());
            Student s = new Student(name, sclass);
            Console.WriteLine("Enter the marks of the subjecs:");
            Console.WriteLine("physics:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chemistry:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maths:");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Result r = new Result(s1, s2, s3,name,sclass);
            Console.WriteLine(r.calculateResult());
        }
    }
}



 













