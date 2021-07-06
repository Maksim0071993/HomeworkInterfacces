using System;

namespace HomeworkLessonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work(true);
            Clients clients = new Clients("Иван", "АгроСлобода");
            work.MoveToWork();
            clients.MoveToWork();
            work.CustomerSearch();
            work.Invoicing();

            if (Work.Sale == true)
            {
                clients.ClosingOfDeal();
                work.ClosingOfDeal();
                work.Delivery();
                clients.Delivery();
            }

            Console.WriteLine();
        }
    }
}
