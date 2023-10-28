using System;
using System.Reflection.Metadata;

public class Account{
  private string accName , acid ;
  private int balance ;
  public String Acc_Name{
    get{return accName;}
    set{accName = value;}
  }
  public String AC_id{
    get{return acid;}
    set{acid = value;}
  }
  public int Balance{
    get{return balance;}
    set{balance = value;}
  }
  public Account(){}
  public Account(string accName , string acid , int balance){
    this.accName = accName ;
    this.acid = acid ;
    this.balance = balance ;
  }
  public void Deposit(int amount){
    this.balance = this.balance+amount;
  }
  public void Withdraw(int amount){
    if(this.balance-amount<0){
      Console.WriteLine("Insufficient Balance");
    }else{
       this.balance = this.balance-amount;
    }
  }
  public void Transfer(int amount , Account receiver){
    if(this.balance-amount<0){
      Console.WriteLine("Insufficient Balance ***** Transfer Failed \n");
    }else{
      this.Withdraw(amount);
      receiver.Deposit(amount);
    }
    
  }
  public void Show_acc_info(){
    Console.WriteLine("Name : "+accName);
    Console.WriteLine("ID : "+acid);
    Console.WriteLine("Balance : "+balance);
  }
}
public class Program
{
  public static void Main(string[] args)
  {
    Account a1 = new Account("swajan","1181",1000);
    Account a2 = new Account("barua","1182",5000);
    a1.Show_acc_info();
    Console.WriteLine();
    a2.Show_acc_info();
    Console.WriteLine();
    a1.Transfer(10000,a2);
     a1.Show_acc_info();
    Console.WriteLine();
    a2.Show_acc_info();

   

  }
}
