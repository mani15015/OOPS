// See https://aka.ms/new-console-template for more information

interface branch
{
    //abstract int no_branch=10;
    void branch(int no_branch);
}

class Eng_branch : branch
{
    public void branch(int no_branch)
    {
        Console.WriteLine("Number of branches in Engineering: "+no_branch);
    }
}

interface exams
{
    void exam(int no_exams);
}

class Eng_exams : exams
{
    public void exam(int no_exams)
    {
        Console.WriteLine("Number of exams in Engineering: "+no_exams);
    }
}

class Engineer
{
    static void Main()
    {
        Eng_branch eng = new Eng_branch();
        eng.branch(5);

        Eng_exams exams = new Eng_exams();
        exams.exam(10);
    }
}