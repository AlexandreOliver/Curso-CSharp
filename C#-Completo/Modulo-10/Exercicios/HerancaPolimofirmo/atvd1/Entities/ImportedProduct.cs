using System.Globalization;

namespace Entities;

class ImportedProduct : Product
{
    public double customsFee { get; set; }

    public ImportedProduct(string name, double price, double CustomsFee)
        : base(name, price)
    {
        customsFee = CustomsFee;
    }

    public ImportedProduct() 
    {  

    }

    public override string priceTag()
    {
        return $"{base.Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)}) ";
       //base.priceTag() + $"(Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})"; 
    }

    public double totalPrice()
    {
        return base.Price + customsFee; 
    }
}