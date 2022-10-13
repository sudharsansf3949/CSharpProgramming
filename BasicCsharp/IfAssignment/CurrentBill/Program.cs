using System;
namespace CurrentBill;
class program{
    public static void Main(string[] args)
    {
        int userId,units;
        double total=0,surCharge=0;
        System.Console.WriteLine("Enter name: ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter user id: ");
        userId=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter amount of units: ");
        units=Convert.ToInt32(Console.ReadLine());
        if(units<200){
            total=units*1.20;
            System.Console.WriteLine("Amount charges at rs 1.20 per unit: "+total);
        }
        else if(units>=200 && units<400){
            total=units*1.5;
            System.Console.WriteLine( "Amount charges at rs 1.50 per unit: "+(total));
        }
        else if(units>=400 && units<600){
            total=units*1.8;
            System.Console.WriteLine("Amount charges at rs 1.80 per unit: "+(total));
        }
        else if(units>=600){
            total=units*2;
            System.Console.WriteLine("Amount charges at rs 2.0 per unit: "+(total));
        }
        if(total<100){
            System.Console.WriteLine("The minimum bill value is rs 100");
        }
        if(total>400){
            surCharge=total*0.15;
            System.Console.WriteLine("Sur charge amount is: "+surCharge);
            System.Console.WriteLine("The net amount paid by the customer: "+(surCharge+total));
        }


    }
}