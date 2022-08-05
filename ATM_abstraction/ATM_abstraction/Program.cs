// See https://aka.ms/new-console-template for more information

abstract class ATM
{
    public int pin;
    public void display()
    {
        Console.WriteLine("Please enter pin");
    }
    public abstract void Epin();
}

class Verifypin : ATM
{
    public override void Epin()
    {
       pin =Convert.ToInt32( Console.ReadLine());

        if(pin == 1234)
        {
            Console.WriteLine("Welcome to ATM");
        }
        else
        {
            Console.WriteLine("Please Enter correct password");
        }
        
    }

    class UserATM
    {
        static void Main()
        {
            Verifypin verifypin = new Verifypin();
            verifypin.display();
            verifypin.Epin();
        }
    }
}

