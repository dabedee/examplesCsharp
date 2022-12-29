using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referansTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int decimal float enum boolean değer tipleri
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);
            int[] myArr = new int[] { 1, 2, 3 };
            int[] myArr2 = new int[] { 10, 20, 30 };
            myArr = myArr2;
            myArr2[0] = 1000;
            Console.WriteLine(myArr[0]);

            // array class interface referans tip dir 
            Person person1 = new Person();
            Person person2 = new Person();
            
            person1.FirstName = "deniz";
            person2 = person1;
            person1.FirstName = "rukiye";

            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();

            Person person3 = customer;
            

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
           









            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }
    class Customer : Person
    {
        public int CreditCartNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }

    }
}
