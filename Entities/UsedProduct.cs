using System;
namespace ControleProdutos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate{ get; set; }
        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string text()
        {
            return base.text() + ($" (used) - {ManufactureDate.ToString("yyyy-MM-dd")}");
        }
    }
}