using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public static class Operations
    {
        static UserRegistration currentDonor=null;

        static List<UserRegistration> userList=new List<UserRegistration>();
        static List<Donation> donationList=new List<Donation>();



        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select the option");
                System.Console.WriteLine("1.User Registration 2.User Login 3.Fetch Donor details 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:;
                    {
                        System.Console.WriteLine("Welcome to User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Ftech Donor Details");
                        break;
                    }
                    case 4:
                    {
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        } 



        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your Name: ");
            string donorName=Console.ReadLine();
            System.Console.WriteLine("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mobile Number: ");
            long mobileNumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your blood group A_positive or B_positive or O_positive or AB_positive");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Last Date of Donation dd/mm/yyy");
            DateTime lastDonation=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            UserRegistration user=new UserRegistration(donorName,mobileNumber,bloodGroup,age,lastDonation);
            userList.Add(user);
            System.Console.WriteLine("Your Donor Id is : "+user.DonorId);

        }


        public static void Login()
        {
            System.Console.WriteLine("Enter the Donor Id");
            string id=Console.ReadLine().ToUpper();
            foreach(UserRegistration user in userList)
            {
                if(id==user.DonorId)
                {
                    System.Console.WriteLine("Login successful");
                    currentDonor=user;
                    SubMenu();

                }
            }

        }

        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select your choice....");
                System.Console.WriteLine("1.Donate blood 2.Donation history 3.Next Eligible date 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Doante Blood");
                        DonateBlood();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Donation history");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Next eligible date");
                        bool temp=currentDonor.NextEligiblity(currentDonor.LastDonation);
                        break;
                    }
                    case 4:
                    {
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }


        public static void DonateBlood()
        {
            System.Console.WriteLine("Enter your Weight: ");
            double weight=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Blood pressure: ");
            double bloodPressure=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Haemoglobin count: ");
            double haemeglobinCoount=double.Parse(Console.ReadLine());
            bool temp=currentDonor.NextEligiblity(currentDonor.LastDonation);
            bool temp1=false;
            if(haemeglobinCoount>13&&weight>50&& bloodPressure<130)
            {
                temp1=true;
            }
            if(temp1||temp)
            {
                System.Console.WriteLine("Yor are not elligible for danation");
            }
            if(temp&&temp1)
            {
                foreach(Donation donation1 in donationList)
                {
                    Donation donation=new(currentDonor.DonorId,DateTime.Now,weight,bloodPressure,haemeglobinCoount);
                    donationList.Add(donation);
                    System.Console.WriteLine("Blood donated Successfully and your Donation Id is..."+donation1.DonationId);
                }
            }

        }


        
    }
}
