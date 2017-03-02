using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Products
    {
        private string productId;
        private string productName;
        private string supplierId;
        private string catagoryId;
        private int quantityPerUnit;
        private float unitPrice;
        private int unitsInStock;
        private int unitsInOrder;
        private int reorderLevel;
        private bool discontinued;

        public bool Discontinued
        {
            get { return discontinued; }
            set { discontinued = value; }
        }


        public int ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }


        public int UnitsInOrder
        {
            get { return unitsInOrder; }
            set { unitsInOrder = value; }
        }


        public int UnitsInStock
        {
            get { return unitsInStock; }
            set { unitsInStock = value; }
        }


        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }


        public int QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }


        public string CatagoryId
        {
            get { return catagoryId; }
            set { catagoryId = value; }
        }


        public string SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }


        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

    }
}
