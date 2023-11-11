using System;

public class date
{
    public int day { set; get; }
    public int month { set; get; }
    public int year { set; get; }
    public date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
}

public class employee
{
    private string name, id;
    double salary;
    date joinDate;
    public string Name
    {
        set; get;
    }
    public string Id
    {
        set; get;
    }
    public double Salary
    {
        set; get;
    }
    public date JoinDate
    {
        set; get;
    }
    
    public employee(string name, string id, double salary, date joinDate)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
        this.joinDate = joinDate;
    }

    public void show()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Join Date: " + JoinDate.day + " / " + JoinDate.month + " / " + JoinDate.year);
    }
}

public class Regular_Employee : employee
{
    double bonus { set; get; }
    public Regular_Employee(string name, string id, double salary, date joinDate) : base(name, id, salary, joinDate)
    {
        bonus = salary * 0.15;
    }

    public void show()
    {
        base.show();
        Console.WriteLine("Bonus: " + bonus);
    }
}

public class Part_time_employee : employee
{
    double bonus { set; get; }
    double workHour
    {
        set; get;
    }
    public Part_time_employee(string name, string id, double salary, date joinDate, int workHour) : base(name, id, salary, joinDate)
    {
        this.workHour = workHour;
        this.bonus = salary * workHour * 0.01;
    }
    public void show()
    {
        base.show();
        Console.WriteLine("Working Hour: " + workHour);
        Console.WriteLine("Bonus: " + bonus);
    }
}

public class Program
{
    static void Main()
    {
        Part_time_employee o = new Part_time_employee("swajan", "123", 3000, new date(3, 3, 12), 65);
        o.show();
    }
}
