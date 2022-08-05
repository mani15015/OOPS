// See https://aka.ms/new-console-template for more information
class Orders
{
    int no_hotel;
    string foodmenu;
    string userinfo;
    string addr;

    public void display(int no_hotel, string foodmenu)
    {
        this.no_hotel = no_hotel;
        this.foodmenu = foodmenu;
        Console.WriteLine("available no of hotels" + no_hotel + "\n foodmenu: " + foodmenu);
    }
    public void display(string userinfo, string addr, string foodmenu)
    {
        Console.WriteLine("--------------------------------------------Hotel-------------------------------");
        Console.WriteLine("user details\nuser name:" + userinfo + "\nuser addr:" + addr + "\norder food: " + foodmenu);
    }
}

class Customer : Orders
{
    public void display(string userinfo, string addr, string foodmenu)
    {
        Console.WriteLine("--------------------------------------------Hotel-------------------------------");
        Console.WriteLine("user details\nuser name:" + userinfo + "\nuser addr:" + addr + "\norder food: " + foodmenu);
    }
}
class Hotel
{
    static void Main()
    {
        Orders orders = new Customer();
        orders.display(5, "dosa");
        orders.display("mani", "bengalore", "dosa");
    }
}
