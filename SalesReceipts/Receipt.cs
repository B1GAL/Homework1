using System;
using System.Collections.Generic;
using System.Text;

namespace SalesReceipts
{
    public class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }

        private double SalesTaxPercent;
        private double CogPrice;
        private double GearPrice;



        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00; //save 1
        }

        public Receipt(int id, int cog, int gear)
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00; //save 1
        }

        public double CalculateTotal()
        {
            double netAmount = CalculateNetAmount();

            double taxAmount = CalculateTaxAmount();

            double value = taxAmount + netAmount;
            return value;
        }

        public void PrintReceipt()
        {
            string receipt = $"\t{string.Empty.PadLeft(40, '#')}\n" +
                             $"\t{"".PadLeft(05, ' ') + "Customer:"} {CustomerID}\n" +
                             $"\t{string.Empty.PadLeft(40, '-')}\n" +
                             $"\t{"# of Cogs:".PadRight(15, ' ')}{CogQuantity.ToString("N0")}" +
                             $"\t{"# of Gears:"} + {GearQuantity.ToString("N0")}" +
                             $"\t{"Subtotal:"}{CalculateNetAmount().ToString("C")}" +
                             $"\t{"Sales Tax:"}{CalculateTaxAmount().ToString("C")}" +
                             $"\t{"Total:"}{CalculateTotal().ToString("C")}" +
                             $"\t{string.Empty.PadLeft(40, '#')}";




        }

        private double CalculateTaxAmount()
        {
            return CalculateNetAmount() * SalesTaxPercent;
        }

        private double CalculateNetAmount()
        {
            double netAmount, cogPriceWMarkup, gearPriceWMarkup;

             

            if (CogQuantity + GearQuantity > 16 || CogQuantity > 10 || GearQuantity > 10)
            {
                cogPriceWMarkup = CogPrice + CogPrice*.125;
                gearPriceWMarkup = GearPrice + GearPrice * .125;
            }
            else
            {
                cogPriceWMarkup = CogPrice + CogPrice * .15;
                gearPriceWMarkup = GearPrice + GearPrice * .15;
            }

            netAmount = CogQuantity * cogPriceWMarkup + GearQuantity * gearPriceWMarkup;

            return netAmount;
        }












    }
}
