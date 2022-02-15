using System;
using System.IO;


class Program
{
    
    public static void Main(string[]args)
    {
       


        Console.WriteLine("Enter thr Student Name");
        string name = Console.ReadLine();
        Console.WriteLine("Student ID");
        int Studentid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark 1");
        int mark1 = Convert.ToInt32(Console.ReadLine());
             
            
       Console.WriteLine("Enter the mark 2");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark 3");
        int mark3 = Convert.ToInt32(Console.ReadLine());



        Student obj = new Student(Studentid, mark1, mark2, mark3, name);
        obj.SaveFile();
        Console.WriteLine("hello world");
        
    }
}




