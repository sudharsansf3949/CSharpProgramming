using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Department:Books
    {
        public string  DepartmentName { get; set; }
        public string Degree { get; set; }

        public Department(string departmentName,string degree,string bookId,string bookName,string authorName,int price):base( bookId, bookName, authorName, price)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }

        public void ShowDepartment()
        {
            showDetails();
            System.Console.WriteLine("Your Department is     :"+DepartmentName);
            System.Console.WriteLine("Your Degree is         :"+Degree);
        }



    }
}