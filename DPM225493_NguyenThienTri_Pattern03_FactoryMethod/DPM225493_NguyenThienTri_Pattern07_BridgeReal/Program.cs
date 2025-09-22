using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern07_BridgeReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customers();
            
            customers.Data = new CustomersData("Chicago");
            
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            
            Console.ReadKey();
        }
    }
}
