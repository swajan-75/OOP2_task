//copy this code and paste to your Program.cs file
using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic;
public struct DateFormate
{
  private int day,month, year;
  public DateFormate(int dd, int mm, int yy){
    this.day = dd ;
    this.month = mm;
    this.year = yy ;
  }
  public int get_day(){
    return this.day;
  }
  public int get_moth(){
    return this.month ;
  }
  public int get_year(){
    return this.year;
  }
  public int DAY{
    set{day = value;}
    get{return day;}
  }
  public int MONTH{
    set{month = value;}
    get{return month;}
  }
  public int YEAR{
    set{year = value;}
    get{return year;}
  }
  public void show_date(){
    Console.WriteLine(this.day+" / "+this.month+" / "+this.year);
  }
  
}
public class Employee{
  private string name , id ;
  private double salary;
  private DateFormate joinDate ;
  public string Name{
    set{name = value;}
    get{return name;}
  }
  public string ID{
    set{
      id = value;
    }
    get{
      return id;
    }
  }
  public double Salary{
    set{salary = value;}
    get{return salary;}
  }
    public DateFormate JoinDate
    {
    set{joinDate = value;}
    get{ return joinDate;}
  }
  public Employee(){}
  public Employee(string name , string id , double salary , DateFormate joinDate){
    this.name = name ;
    this.id = id;
    this.salary = salary ;
    this.joinDate = joinDate ;
  }
  public void Show_Employee_data(){
    Console.WriteLine("Name : "+name);
    Console.WriteLine("ID : "+id);
    Console.WriteLine("Salary : "+salary);
    Console.Write("Join Date : ");
    joinDate.show_date();
  }
}
public class DayWorker : Employee{
    private double bonus;
    public DayWorker(string name , string id , double salary , DateFormate joindate):
  base(name,"D-"+id,salary,joindate)
  {
    //this.bonus = salary*(0.2);
  
  }
  public void calBonus(){
    this.bonus = Salary*0.2;
  }
  public double get_Bonus(){
    return this.bonus;
  }
}
public class NightWorker : Employee{
    public double bonus ;
    public NightWorker(string name , string id , double salary , DateFormate joinDate):base(name,"N-"+id,salary,joinDate){
      //bonus = salary *0.25 ;
    }
    public void calBonus(){
    this.bonus = Salary*0.25;
  }
  public double get_Bonus(){
    return this.bonus;
  }
}
class Program
{
  public static void Main(string[] args){
          DayWorker d1 = new DayWorker("Ratul", "123", 25000, new DateFormate(12,9,2023));
          d1.Show_Employee_data();
          Console.Write("\n");
          NightWorker[] list = new NightWorker[2];
          list[0] = new NightWorker("A", "111", 25000, new DateFormate(12,7,2023)); 
          list[1] = new NightWorker("B", "222", 25000, new DateFormate(23, 11, 2023));
          foreach (NightWorker w in list)
        {
            w.Show_Employee_data();
            Console.WriteLine();
}
  }
}
