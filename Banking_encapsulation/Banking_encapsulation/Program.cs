// See https://aka.ms/new-console-template for more information


class HDFC
{
    private int user_acc_no;
    private string user_name;
    private string user_branch;

    public int UserAccNo
    {
        get { return user_acc_no; }
        set { user_acc_no = value; }
    }

    public string UserName
    {
        get { return user_name; }
        set { user_name = value; }
    }
    public string UserBranch
    {
        get { return user_branch; }
        set { user_branch = value; }
    }
   
}

class Bank
{
    static void Main()
    {
        HDFC hDFC = new HDFC();
        hDFC.UserAccNo=12345;
        hDFC.UserName = "mani";
        hDFC.UserBranch = "bengalore";

        Console.WriteLine("User Acc No: " + hDFC.UserAccNo + "\nUser Name: " + hDFC.UserName + "\nUser Branch: " + hDFC.UserBranch);
    }
}
