using System;

namespace CollegeApplication
{
    public delegate void EventManager();    //user defined deligate

    public static class Operations
    {
        public static event EventManager eventlink=null;     //user definied event
        public static StudentDetails currentStudent=null;

        public static List<StudentDetails> studentList=new List<StudentDetails>();

        public static List<DepartmentDetails>departmentList=new List<DepartmentDetails>();

        public static List<AdmissionDetails>admissionList=new List<AdmissionDetails>();

        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operations.MainMenu);
            eventlink+=new EventManager(Files.WritetoFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }

        public static void MainMenu()
        {
            DefaultData();

            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option 1.Registration 2.Student Login 3.Check Department wise seat 4.Exit");
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
                        System.Console.WriteLine("Student Login");
                        StudentLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Check Department wise seat");
                        CheckSeat();
                        break;
                    }
                    case 4:
                    {
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Input");
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void DefaultData()
        {
            studentList.Add(new StudentDetails("Ravichandran S","Ettaparajan",new DateTime(1999/11/11),Gender.Male,95,95,95));
            studentList.Add(new StudentDetails("Baskaran S","Sethurajan",new DateTime(1999/11/11),Gender.Male,95,95,95));

            departmentList.Add(new DepartmentDetails("DID101","EEE",29));
            departmentList.Add (new DepartmentDetails("DID102","CSE",29));
            departmentList.Add(new DepartmentDetails("DID103","MECH",30));
            departmentList.Add(new DepartmentDetails("DID104","ECE",30));

            admissionList.Add(new AdmissionDetails("DID101",DateTime.Now,AdmissionStatus.Booked,"SF3003","AID1001"));
            admissionList.Add(new AdmissionDetails("DID102",DateTime.Now,AdmissionStatus.Booked,"SF3003","AID1002"));

        }
        public static void Registration()
        {   
            System.Console.WriteLine("Enter Student Details ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Enter your Name: ");
            string studentName=Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your Dato of Birth in dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter Gender Male, Female, Transgender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter Physics mark: ");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Chemistry mark: " );
            int chemistry=int.Parse (Console.ReadLine());
            System.Console.WriteLine("Enter your Maths mark: ");
            int maths=int.Parse(Console.ReadLine());
            StudentDetails student=new StudentDetails(studentName,fatherName,dob,gender,physics,chemistry,maths);
            studentList.Add(student);
            System.Console.WriteLine("LOgin id is"+student.StudentId);
        }
       
        public static void StudentLogin()
        {
            System.Console.WriteLine("Enter a Student id ");
            string id=Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(student.StudentId==id)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentStudent=student;
                    subMenu();
                }
            }
        }

        public static void TakeAdmission()
        {
        
           System.Console.WriteLine("The list available department and no of seats");
            foreach(DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine("The department Id is: "+department.DepartmentId);
                System.Console.WriteLine("The department name is: "+ department.DepartmentName);
                System.Console.WriteLine("The number of seats in department is : "+ department.NoofSeats);
            }
            System.Console.WriteLine("Enter the department ID: ");
            string id=(Console.ReadLine().ToUpper());

            foreach(DepartmentDetails department in departmentList)
            {
                if(id==department.DepartmentId)
                {
                    if(department.NoofSeats>=1 )
                    {
                        bool eligiblity =currentStudent.CheckEligiblity(75);
                        if(eligiblity)
                        {
                            foreach(AdmissionDetails add in admissionList)
                            {
                                if(currentStudent.StudentId!=add.AdmissionId)
                                {
                                    department.NoofSeats--;
                                    
                                    AdmissionDetails student =new(id,DateTime.Now,AdmissionStatus.Booked,currentStudent.StudentId,"");
                                    admissionList.Add(student);
                                    System.Console.WriteLine("Admissison was Successful and your admission id is"+student.AdmissionId);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("You are not elligible");
                        }
                        
                    }
                }
                else
                {
                    System.Console.WriteLine("Seats not available");
                }
            }
        }

        public static void CancelAdmission()
        {
            System.Console.WriteLine("Enter your admission id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(AdmissionDetails details in admissionList)
            {
                if(id==details.AdmissionId)
                {
                    if(details.AdmissionStatus==AdmissionStatus.Booked)
                    {
                        details.AdmissionStatus=AdmissionStatus.Cancelled;
                        foreach(DepartmentDetails detail in departmentList)
                        {
                            detail.NoofSeats--;
                        }
                        System.Console.WriteLine("Admission Cancelled");
                    }

                }
            }            
        }

        public static void CheckSeat()
        {

            System.Console.WriteLine("The list of available department");
            foreach(DepartmentDetails department in departmentList)
            {
                System.Console.WriteLine("The department Id is: "+department.DepartmentId);
                System.Console.WriteLine("The department name is: "+ department.DepartmentName);
            }
            
            System.Console.WriteLine("Enter department Id: ");
            string id=Console.ReadLine().ToUpper();
   
            foreach(DepartmentDetails dep in departmentList)
            {
                if(id==dep.DepartmentId)
                System.Console.WriteLine($"There are {dep.NoofSeats} Seats in {dep.DepartmentName} department");
                
            }
        }

        public static void ShowAdmissionDetails()
        {
            System.Console.WriteLine("Enter your admission id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(AdmissionDetails details in admissionList)
            {
                if(id==details.AdmissionId)
                {
                    System.Console.WriteLine(details.AdmissionId);
                    System.Console.WriteLine(details.StudentId);
                    System.Console.WriteLine(details.DepartmentId);
                    System.Console.WriteLine(details.AdmissionDate);
                    System.Console.WriteLine(details.AdmissionStatus);
                }
            }
        }



        public static void subMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Enter option");
                System.Console.WriteLine("1.Check Eligiblity 2.show details 3.Take Admission 4. Cancel Admission 5.Show Admission details6.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 2:
                    {
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 1:
                    {
                        bool eligible=currentStudent.CheckEligiblity(75.0);
                        if(eligible)
                        {
                            System.Console.WriteLine("The student is Eligible for Admission");

                        }
                        else
                        {
                            System.Console.WriteLine("The student is not eligible for admission");
                        }
                        break;
                    }
                    case 3:
                    {
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        ShowAdmissionDetails();
                        break;
                    }
                    case 6:
                    {
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid option");
                        choice="no";
                        break;
                    }

                }
            }while(choice=="yes");
        }

    }
}