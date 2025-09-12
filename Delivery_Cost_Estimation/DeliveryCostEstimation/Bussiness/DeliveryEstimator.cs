using System;
using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Repo;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace DeliveryCostEstimation.Bussiness
{
public static class DeliveryEstimator
{
    public static PackageResult Estimate(double baseCost, Package pkg)
    {
        double deliveryCost = baseCost + pkg.Weight * 10 + pkg.Distance * 5;

        var offer = OfferRepository.FindOffer(pkg.OfferCode);
        double discount = 0;

        if (offer != null && offer.IsValidFor(pkg))
            discount = deliveryCost * (offer.DiscountPercent / 100);

        double totalCost = deliveryCost - discount;

        return new PackageResult
        {
            Id = pkg.Id,
            Discount = Math.Round(discount, 0),
            TotalCost = Math.Round(totalCost, 0)
        };
    }
}
}