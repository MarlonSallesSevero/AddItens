using System.Globalization;
namespace ControleProdutos.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustAlfand { get; set; }
        public ImportedProduct(string name, double price, double custAlfand)
            : base(name, price)
        {
            CustAlfand = custAlfand;
        }

        public double TotalPrice()
        {
            return Price + CustAlfand;
        }

        public override string text()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustAlfand.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
