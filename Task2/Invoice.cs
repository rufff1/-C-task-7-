using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Invoice
    {

        public string acount;
        public string customer;
        public string provider;

        public string Article { get; set; }

        public int Quantity { get; set; }


        public Invoice(string acount, string customer, string provider)
        {
            this.acount = acount;
            this.customer = customer;
            this.provider = provider;
        }



        public void CostCalculation(bool NeedEdv)
        {
            if (NeedEdv == true)
            {
                if (Article == "Usb-hab")
                {
                    Console.WriteLine($"{(12 * Quantity) + 12 * 0.18}");
                    Console.WriteLine($" Article:{Article} Quantity:{Quantity} Price:{12} ");
                }


                else if (Article == "Laptop")
                {
                    Console.WriteLine($"Mehsulun deyeri:{(1400 * Quantity) + 1400 * 0.18}");
                    Console.WriteLine($" Article:{Article} Quantity:{Quantity} Price:{1400}");
                }
                else if (Article == "SD-card")
                {
                    Console.WriteLine($"Mehsulun deyeri:{(30 * Quantity) + 30 * 0.18}");
                    Console.WriteLine($"Article:{Article} Quantity:{Quantity} Price:{30}");
                }

            }
            else
            {
                if (Article == "Usb-hab")
                {
                    Console.WriteLine($"Mehsulun umumi deyeri:{12 * Quantity}");
                    Console.WriteLine($"Article:{Article} Quantity:{Quantity} Price:{12} ");
                }
                else if (Article == "Laptop")
                {
                    Console.WriteLine($"Mehsulun umumi deyeri:{1400 * Quantity}");
                    Console.WriteLine($"Article:{Article} Quantity:{Quantity} Price:{1400}");
                }
                else if (Article == "SD-card")
                {
                    Console.WriteLine($"Mehsulun umumi deyeri{30 * Quantity}");
                    Console.WriteLine($"Article:{Article} Quantity:{Quantity} Price:{30}");
                }
            }
        }
    }
}
