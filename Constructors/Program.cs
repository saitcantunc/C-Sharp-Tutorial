using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor bir classı newlediğimiz zaman ilk çalışan yapıcı bloktur.
            Customer customer1 = new Customer {Id=1,FirstName = "Engin", LastName = "Demiroğ",City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;


            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }

    }

    class Customer
    {
        //default consturctor
        public Customer()
        {

        }
        
        public Customer(int id, string firstName, string lastname, string city)
        {
            FirstName = firstName;
            LastName = lastname;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
    }
}
