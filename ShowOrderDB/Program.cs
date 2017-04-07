using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowOrderDB
{
    class Program
    {
        static void Main(string[] args)
        {

            NorthwindContext orderModel = new NorthwindContext();
            //var s = orderModel.Orders.Where(u => u.OrderID == 10248).Select(u => u.ShipName);
            using (var db = new NorthwindContext())
            {
                var query = (from b in db.Orders                            
                            select b).Take(20);
                //var query = (from b in db.Orders
                //             orderby b.OrderID descending
                //             select b).Take(20);


               


                Console.WriteLine("First 20 shipname in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine( item.ShipName);
                }
                
            Console.ReadLine();
            }

        }
    }
}
