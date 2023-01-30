using System;
using System.Globalization;

namespace Entities;

class UsedProduct : Product
{
    
    public DateTime manufactureDate { get; set; }

    public UsedProduct(string name, double price, DateTime ManufactureDate)
        : base(name, price)
    {
        manufactureDate = ManufactureDate;
    }

    public UsedProduct()
    {
        
    }

    public override string priceTag()
    {
        return $"{base.Name} (used) $ {base.Price.ToString("F2", CultureInfo.InvariantCulture)} " +
               $"(Manufacture date: {manufactureDate.Day/manufactureDate.Month/manufactureDate.Year})";
    }

}