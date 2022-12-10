using System;
using System.Collections.Generic;

namespace StudentClub
{
class Program
    {
       
        static void Main(string[] args)
        {
            var studentList = new List<Student>(); 
            int menuChoice;
            const int Exit = 5;
            do
            {
                
                Console.WriteLine("Student Club Management Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. List Students");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Which option would you like to select?");
                menuChoice = Convert.ToInt16(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        AddStudent(studentList);
                        break;
                    case 2:
                        DeleteStudent(studentList);
                        break;
                    case 3:
                        EditStudent(studentList);
                        break;
                    case 4:
                        ListStudent(studentList);
                        break;
                }
                
            } while (menuChoice != Exit);

            if (menuChoice == Exit)
            {
                Console.WriteLine("**List of students in Club**");
                foreach (var list in studentList)
                {
                    Console.WriteLine(list);
                }
                Console.WriteLine("Thank you for using Student Club Management!");
            }
        }

        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("What is the student's first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is the student's last name?"); 
            string lastName = Console.ReadLine(); 
            Console.WriteLine("What is the student's email address?");
            string email =Console.ReadLine();
            Student newStudent = new Student(firstName, lastName, email);
            studentList.Add(newStudent);
            Console.WriteLine("Student successfully added.");
        }

        static void ListStudent(List<Student> studentList)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student listall = studentList[i];
                Console.WriteLine($"{i + 1}. {listall}");
            }

            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club.");
                return;
            }
        }
        
        
        static void DeleteStudent(List<Student> studentList)
        {

            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club");
                return;
            }
            else
            {
                ListStudent(studentList);
                Console.WriteLine("Which student would you like to delete?");
                int delete = Convert.ToInt32(Console.ReadLine());
                studentList.RemoveAt(delete - 1);
                Console.WriteLine("Student successfully deleted.");
            }
        }

        static void EditStudent(List<Student> studentList)
        {
        
                
            if (studentList.Count == 0)
            {
                Console.WriteLine("Sorry there are no students in this Club");
                return;
            }
            else
            {
                ListStudent(studentList);
                Console.WriteLine("Which student would you like to edit?");
                int edit = Convert.ToInt32(Console.ReadLine());
                studentList.RemoveAt(edit -1);
                Console.WriteLine("Please enter the new first name:"); 
                string first = Console.ReadLine();
                Console.WriteLine("Please enter the new last name:"); 
                string last = Console.ReadLine();
                Console.WriteLine("Please enter the new email:");
                string newEmail = Console.ReadLine();
                Student update = new Student(first, last, newEmail);
                studentList.InsertRange(edit-1, new[] {update});
                Console.WriteLine("Student information successfully updated!");
                
            }
        }
        
    }
}
