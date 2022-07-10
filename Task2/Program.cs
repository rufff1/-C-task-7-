using System;

namespace Task2
{

    public class Program
    {

    
    static void Main()
        {


            


            Invoice inv = new Invoice("678904", "Alex", "Foxtrot")
            {
                Article = "Usb-hab",
                Quantity = 6
            };

            inv.CostCalculation(false);


            Invoice inv2 = new Invoice("678904", "Alex", "Foxtrot")
            {
                Article = "Laptop",
                Quantity = 10
            };
           inv2.CostCalculation(true);


            Invoice inv3 = new Invoice("678904", "Alex", "Foxtrot")
            {
                Article = "SD-card",
                Quantity = 15
            };
         inv3.CostCalculation(true);
            




        }


    }
}