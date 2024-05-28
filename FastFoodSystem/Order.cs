using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem
{
    internal class Order
    {
        private int orderNumber;
        private DateTime dateTimeOfOrder;
        private string orderName;
        private string orderAddress;
        private int orderTelephone;
        private decimal totalCost;


        public Order(int orderNumber, DateTime dateTimeOfOrder, string orderName, string orderAddress, int orderTelephone, decimal totalCost)
        {
            this.orderNumber = orderNumber;
            this.dateTimeOfOrder = dateTimeOfOrder;
            this.orderName = orderName;
            this.orderAddress = orderAddress;
            this.orderTelephone = orderTelephone;
            this.totalCost = totalCost;
        }

        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }

            set
            {
                orderNumber = value;
            }
        }


        public DateTime DateTimeOfOrder
        {
            get
            {
                return dateTimeOfOrder;
            }

            set
            {
                dateTimeOfOrder = value;
            }
        }

        public string OrderName
        {
            get
            {
                return orderName;
            }

            set
            {
                orderName = value;
            }
        }

        public decimal TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        public string OrderAddress
        {
            get
            {
                return orderAddress;
            }

            set
            {
                orderAddress = value;
            }
        }

        public int  OrderTelephone
        {
            get
            {
                return orderTelephone;
            }

            set
            {
                orderTelephone = value;
            }
        }

        public override string? ToString()
        {
            return orderNumber.ToString() + " " + totalCost + " " + dateTimeOfOrder.ToString();
        }


    }
}
