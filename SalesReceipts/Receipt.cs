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
    }
}
