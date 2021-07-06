using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLessonClass
{
    public class Clients : IWorkOperations,IDelivery
    {
        public Clients(string firstName, string companyName)
        {
            FirstName = firstName;
            CompanyName = companyName;
        }
        public string FirstName { get; set; }
        public string CompanyName { get; set; }

        //public void MoveToWork()
        //{
        //    Console.WriteLine($"Клиент {FirstName} {CompanyName} пришел на работу");
        //}
        public void ClosingOfDeal()
        {
            Console.WriteLine($"Клиент {FirstName} {CompanyName} купил запчасти");
        }
        public void Delivery()
        {
            Console.WriteLine($"{FirstName} {CompanyName} Забрал запчасти с транспортной компании");
        }
    }
}
