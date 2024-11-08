using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product_Internal internalobj =new Product_Internal();
            //ElectronicsProducts ep = new ElectronicsProducts();
            
            Mobiles m = new Mobiles();
            Console.WriteLine("Enter electronic Product ID");
            m.ElectronicProducID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m.ElectronicProducID);
            Console.Read();
        }
    }
}
