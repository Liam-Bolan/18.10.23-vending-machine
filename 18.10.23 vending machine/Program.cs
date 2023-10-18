using _18._10._23_vending_machine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _18._10._23_vending_machine
{
    internal class Program
    {
        public struct products
        {
            public string prodname;
            public double prodprice;
            public double prodstock;

        }

        static void Main(string[] args)
        {
            int selectproduct;
            int insertcoins;
            products[] machine = new products[10];
            LoadItems(machine);
            displayItems(machine);
            Console.ReadLine();
        }

        public static void LoadItems(products[] machine)
        {
            machine[0].prodname = "M&Ms";
            machine[0].prodprice = 0.80;
            machine[0].prodstock = 10;

            machine[1].prodname = "Kinder Bueno";
            machine[1].prodprice = 1.30;
            machine[1].prodstock = 4;

            machine[2].prodname = "Skittles";
            machine[2].prodprice = 1.00;
            machine[2].prodstock = 2;

            machine[3].prodname = "Walkers: Salt and Vinegar";
            machine[3].prodprice = 1.50;
            machine[3].prodstock = 8;

            machine[4].prodname = "Starbursts";
            machine[4].prodprice = 0.75;
            machine[4].prodstock = 9;

            machine[5].prodname = "Milkyway";
            machine[5].prodprice = 0.60;
            machine[5].prodstock = 10;

            machine[6].prodname = "Smart Water";
            machine[6].prodprice = 1.30;
            machine[6].prodstock = 0;

            machine[7].prodname = "Lucozade Sport Orange";
            machine[7].prodprice = 1.50;
            machine[7].prodstock = 6;

            machine[8].prodname = "Wotsits";
            machine[8].prodprice = 1.25;
            machine[8].prodstock = 3;

            machine[9].prodname = "Monster Energy";
            machine[9].prodprice = 1.60;
            machine[9].prodstock = 6;
           
        }

        static void displayItems(products[] machine)
        {
            foreach (products item in machine)
            {
                Console.WriteLine($"{item.prodname,-40}£{item.prodprice,-10}{item.prodstock}");
            }
        }



}
    }
   
 
    




    

