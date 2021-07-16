using ex2.Handler;
using System;
using System.Collections.Generic;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");

            var Manager = new ManagerHandler();
            var Operational = new CeoHandler();
            var CEO = new OpManHandler();

            //CREO LA CATENA
            Manager.SetNext(Operational).SetNext(CEO);

            

            //List<double> spese= new List<double> { 200, 1200, 956 };
            //foreach (var item in spese)
            //{
            //    Console.WriteLine($"check {item}");
            //    var result = Manager.Handle(item);
            //    if (result != null)
            //    {
            //        Console.WriteLine($" \t {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item}not approved");
            //    }

            //}


            // ======works if hard coded like I did before
            // ======but data need to be uploaded from file

            

            var expenses = new Expenses();
            List<Expenses> spese = new List<Expenses>();

            foreach (var s in spese)
            {
                var importi = new List<double>();
                importi.Add(expenses.Import);

                    foreach (var item in importi)
                {
                    Console.WriteLine($"check {item}");
                    var result = Manager.Handle(item);
                    if (result != null)
                    {
                        Console.WriteLine($" \t {result}");
                    }
                    else
                    {
                        Console.WriteLine($"{item}not approved");
                    }

                }
            };
            

        }
    }
}
