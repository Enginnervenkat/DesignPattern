using System;
namespace DeliveryCostEstimation.Models
{
public class PackageResult
{
    public string Id { get; set; }
    public double Discount { get; set; }
    public double TotalCost { get; set; }
}
}