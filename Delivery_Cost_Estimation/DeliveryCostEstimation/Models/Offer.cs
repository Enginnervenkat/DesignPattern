using System;
namespace DeliveryCostEstimation.Models
{

public class Offer
{
    public string Code { get; set; }
    public double DiscountPercent { get; set; }
    public double MinDistance { get; set; }
    public double MaxDistance { get; set; }
    public double MinWeight { get; set; }
    public double MaxWeight { get; set; }

    public bool IsValidFor(Package pkg)
    {
        return pkg.Distance >= MinDistance && pkg.Distance <= MaxDistance &&
               pkg.Weight >= MinWeight && pkg.Weight <= MaxWeight;
    }
}
}