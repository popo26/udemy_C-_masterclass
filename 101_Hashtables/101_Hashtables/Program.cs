/*
 * Write a program that will interate through each element of the students array and insert them into a hashtable.
 * If a student with the same ID already exists in the hashtable skip it and display the following error:
 * "Sorry, A student with the same ID already exists".
 * Hint: Usee the method ContainsKey(0 to check weather a student with the same ID already exists.
 */

using System;
using System.Collections;

namespace _101_Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ranger", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student s in students)
            {
                if (!studentTable.Contains(s.Id))
                {
                    studentTable.Add(s.Id, s);
                    Console.WriteLine("Student ID {0} was added.", s.Id);
                }
                else 
                {
                    Console.WriteLine("Student ID already exits. ID:{0}", s.Id);
                }
            }
        }
    }

    class Student
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
        
    }
    
}
