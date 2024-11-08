using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo
{
    internal class ElectronicsProducts
    {
        internal int Watt { get; set; }
        protected int EP_ID { get; set; }

        public int ShowDetails()
        { 
        Product_Internal internalporoduct=new Product_Internal();
            return internalporoduct.Price;
        }
        

        protected internal int show_ElectronicProductID()
        {
            return EP_ID;
        }


    }

    internal class Mobiles : ElectronicsProducts
    {
        public int ElectronicProducID 
        {
            get { return base.EP_ID; }
            set { base.EP_ID=value; }
        }


        public int MyProperty { get {
                return base.ShowDetails();
            }
        }



    }


    internal class Product_Internal
    {
        private string productname;

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Productid { get; set; }

        protected internal int Price { get; set; }
    }

















}
