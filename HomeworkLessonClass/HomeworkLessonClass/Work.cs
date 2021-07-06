using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLessonClass
{
    public class Work : IWorkOperations, IDelivery
    {
        public Work( bool sale)
        {
            Sale = sale;
        }

        public const string Name = "Я";
        public static bool Sale { get; set; }

        public void MoveToWork()
        {
            Console.WriteLine("Я пришел на работу");
        }

        public void CustomerSearch()
        {
            Console.WriteLine($"{Name} обзваниваю клиентов и ищу покупателей");
        }
        
        public void Invoicing()
        {
            Console.WriteLine($"{Name} Выставляю счёт на необходимые запчасти");
        }

        public void ClosingOfDeal()
        {
            Console.WriteLine("Я сделал продажу");           
        }
        public void Delivery()
        {
            Console.WriteLine("Отправил запчасти транспортной компанией");
        }
    }
}
