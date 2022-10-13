using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public static class Operation
    {
        static EmployeeDetails currnentEmployee=null;
        static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
       
        public static void MainMenu()
        {
            string choice="yes";
            do
            {

                System.Console.WriteLine("Select option 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();

                        break;
                    }

                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();

                        break;

                    }

                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;

                    }

                    default :
                    {
                        System.Console.WriteLine("Invalid output");
                        break;
                    }
                }

           
            }while(choice=="yes");

        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter Employee Details");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your roll: ");
            string roll=Console.ReadLine();
            System.Console.WriteLine("Enter your Team name");
            string teamName=Console.ReadLine();
            System.Console.WriteLine("Enter Wrok Location Mathura or Eymard ");
            WorkLocation location=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your date of joining in dd/mm/yyyy");
            DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
 

            EmployeeDetails details=new EmployeeDetails(name,roll,teamName,gender,location,days,leave,date);
            employeeList.Add(details); 
            System.Console.WriteLine("Your Employee Id: "+details.EmployeeId);                    
        }

        public static void Login()
        {
           System.Console.WriteLine("Enter your Registeration number: ");
            string empId=Console.ReadLine().ToUpper();
            foreach(EmployeeDetails employee in employeeList)
            {
                if(employee.EmployeeId==empId)
                {
                    System.Console.WriteLine("Login Successfull");
                    currnentEmployee=employee;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Invalid number");
                }

            }
            
        }

        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter submenu option: ");
                System.Console.WriteLine("1.Show details 2.Number of days 3.Calculate salary 4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        currnentEmployee.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter number of working days ");
                        int days=int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Enter number of leave taken: ");
                        int leave=int.Parse(Console.ReadLine());
                        
                        currnentEmployee.WorkedDays=days;
                        currnentEmployee.Leave=leave;

                        break;
                
                    }
                    case 3:
                    {
                        int days=currnentEmployee.WorkedDays-currnentEmployee.Leave;
                        int salary=days*500;
                        currnentEmployee.Salary=salary;
                        System.Console.WriteLine("Your salary is: "+currnentEmployee.Salary);
                        break;
                    }
                    case 4:
                    {

                        
                        break;
                    }
                }
            }
            
        }
        
    }
}