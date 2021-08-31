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
             //string receipt = $"Customer: 5" + 
        }

        private double CalculateTaxAmount()
        {
            return CalculateNetAmount() * SalesTaxPercent;
        }

        private double CalculateNetAmount()
        {
            double netAmount, cogPriceWMarkup, gearPriceWMarkup,
        }












    }
}
