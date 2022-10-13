using System;
using System.Collections.Generic;
namespace FilterDeligates;
class program{
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="Jhon",Age=41};
        Person person2=new Person(){Name="Jane",Age=69};
        Person person3=new Person(){Name="Jake",Age=12};
        Person person4=new Person(){Name="Ravi",Age=25};
        Person person5=new Person(){Name="Baskaran",Age=30};
        Person person6=new Person(){Name="Sudharsan",Age=100};

        //Create  a list of person and object
        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};

        DisplayPeople("Children:",people,IsChildren);
        System.Console.WriteLine("");
        DisplayPeople ("Adults:",people,IsAdult);
        System.Console.WriteLine("");
        DisplayPeople ("Voters:",people,IsVoter);       
        System.Console.WriteLine("");         
        DisplayPeople("Senior:",people,IsSenior);
    }

    static void DisplayPeople(string tittle,List<Person>people,FilterDelegate filter)
    {
        System.Console.WriteLine($"People in {tittle} list are: ");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine($" {p.Name}, is {p.Age} years old ");
            }
        }
        
    }
    

    static  bool IsChildren(Person p){return p.Age<15;}
    static bool IsVoter(Person p){return p.Age>=18;}
    static bool IsAdult(Person p){if(p.Age>=18&&p.Age<50) {return true;} else {return false;}}
    static bool IsSenior(Person p){return p.Age>=50;}

}