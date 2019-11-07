using System;

namespace Multi_Form_and_Panel
{
	public class ShopWholesale
	{
        private int quantity;
        private double total;
        private string itemName;
        private int stockAvailable;

        public int Quantity { get => quantity; set => quantity = value; }
        public double Total { get => total; set => total = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int StockAvailable { get => stockAvailable; set => stockAvailable = value; }
    }
}
