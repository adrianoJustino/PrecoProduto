using System;
using System.Globalization;

namespace PrecoProduto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override String PriceTag()
        {
            return Name + " $" + (Price+CustomsFee).ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $"+CustomsFee.ToString("F2",CultureInfo.InvariantCulture)+")";
        }
    }
}
