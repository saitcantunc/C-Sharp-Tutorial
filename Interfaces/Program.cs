using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer { Id = 1, FirstName = "Sait", LastName = "Tunç", Address = "Ankara" });

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Zeynep",
            //    LastName = "Tunç",
            //    Departmant = "Fizyoterapi"
            //};
            //manager.Add(student); // interface tek başına newlenemez.

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; } // interfacelerde sadece imza yazılır.
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
