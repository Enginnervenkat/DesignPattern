    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DeliveryCostEstimation.Models;

public static class OfferRepository
{
    private static List<Offer> _offers = new List<Offer>
    {
        new Offer { Code="OFR001", DiscountPercent=10, MinDistance=0, MaxDistance=200, MinWeight=70, MaxWeight=200 },
        new Offer { Code="OFR002", DiscountPercent=7, MinDistance=50, MaxDistance=150, MinWeight=100, MaxWeight=250 },
        new Offer { Code="OFR003", DiscountPercent=5, MinDistance=50, MaxDistance=250, MinWeight=10, MaxWeight=150 },
    };

    public static Offer FindOffer(string code)
        => _offers.FirstOrDefault(o => o.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
}