using System;

  class MainClass {
    public static void Main (string[] args) {
    Employee employee1 =new Employee();
    employee1.Intro();

    Employee employee2=new Employee ("Robert","Downey","12321", 12);
    employee2.YearlySalary=100;
    employee2.Intro();
    Console.WriteLine("YearlySalary:"+employee2.YearlySalary);
    Employee employee3=new Employee("John","Smith","S0089",38);
    employee3.Intro();
    employee3.YearlySalary=50000;
    Console.WriteLine("YearlySalary:"+employee3.YearlySalary);
    employee3. IncreaseSalary(-2);
    employee3.RemoveEmployee();
    Employee employee4=new Employee("Maria","Lambert","S0100",26);
    employee4.Intro();
    employee4.YearlySalary=80000;
    Console.WriteLine("YearlySalary:"+employee4.YearlySalary);
    employee4.IncreaseSalary(7);
    employee4.RemoveEmployee();
    employee4.RemoveEmployee();
   




    
    
    

    
    
    
  }
}