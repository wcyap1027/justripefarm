using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Form_and_Panel
{
    public class Stock
    {
        private int type;
        private int quantity;
        private int supplierId;
        private DateTime purchaseDate;
        private DateTime expiryDate;

        public int Type { get => type; set => type = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
