using System.IO;

class Student
{
    int studentid,  mark1, mark2, mark3;
    string name;

    public Student(int studentid,  int mark1, int mark2, int mark3, string name)
    {
        this.studentid = studentid;
       
        this.Mark1 = mark1;
        this.Mark2 = mark2;
        this.Mark3 = mark3;
        this.Name = name;
       
    }

    public int Studentid { get => studentid; set => studentid = value; }
  
    public int Mark1 { get => mark1; set => mark1 = value; }
    public int Mark2 { get => mark2; set => mark2 = value; }
    public int Mark3 { get => mark3; set => mark3 = value; }
    public string Name { get => name; set => name = value; }
  

    public void SaveFile()
    {
        FileStream fs = new FileStream("Student.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Student ID :" + studentid);
        sw.WriteLine("Name :" + name);
        sw.WriteLine("Mark 1 :" + mark1);
        sw.WriteLine("Mark 2 :" + mark2);
        sw.WriteLine("Mark 3 :" + mark3);

        sw.Close();
        fs.Close();
    }

}

