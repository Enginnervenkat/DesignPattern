using System;
namespace DeliveryCostEstimation.Models
{

public class Package
{
    public string Id { get; set; }
    public double Weight { get; set; }
    public double Distance { get; set; }
    public string OfferCode { get; set; }
}
}