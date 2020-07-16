using System;


class  Employee{
private string firstname;
private string lastname;
private string id;
private int age;
private string address;
private string title;
private double yearlysalary;
private string employmentstatus;
string active;

public string FirstName
{get;set;}

public string LastName
  {get;set;}

public int Age
{
  get{ return age;}
  set{ if(value<18)
  {
    age = 18; 
  }
  else{
    age=value;
  }
}
}
public double YearlySalary
{
  get{return yearlysalary;}
  set
  {
    if(value<1000)
    yearlysalary =1000;
    else{
      yearlysalary=value;
    }
  }
}
public string ID
  {get;set;}

public string EmploymentStatus
  {get;set;}

public Employee()
{

  FirstName = "Unknown";
  LastName ="Unknown";
  ID = "Unknown";
  Age=0;
}
public Employee(string employeefirstname, string employeelastname, string employeeid, int employeeage){
  FirstName=employeefirstname;
  LastName=employeelastname;
  ID=employeeid;
  Age=employeeage;
  EmploymentStatus = "active";
}

public void Intro()
{
  Console.WriteLine("Firstname:"+FirstName);
  Console.WriteLine("Lastname:"+LastName);
  Console.WriteLine("ID:" +ID);
  Console.WriteLine("Age:"+Age);
  
  
}
public double IncreaseSalary(double percent)
{
  double salaryincrease= (percent/100) *YearlySalary;
  double total=salaryincrease+YearlySalary;
  if (percent<0)
  {
    Console.WriteLine("Invalid Input. Yearly Salary not updated");
  }
  else 
  {
    Console.WriteLine("Yearly salary updated to"+ " "+total);
  }
  return salaryincrease;
}
public void RemoveEmployee()
{  
   
  if(employmentstatus==active)
  {
    employmentstatus="inactive";
    Console.WriteLine("Employee removed successfully");
  }
  else
  {
    Console.WriteLine("Employee already inactive" );
  }

}








}