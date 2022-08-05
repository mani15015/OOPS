// See https://aka.ms/new-console-template for more information
 class cousre1
{
    public void sub(string c1)
    {
        Console.WriteLine("Course for students" + c1) ;
    }
}

class cousre2
{
    public void sub(string c2)
    {
        Console.WriteLine("Course for students" + c2);
    }
}

class student : cousre1, cousre2
{
    public void st(string c1, string c2)
    {
        Console.WriteLine("Students for course 1"+c1+ "Students for course 1"+c2 );
    }
}

class example
{
    static void Main()
    {
        student s = new student();
        s.st("java", "c#");
    }
}
