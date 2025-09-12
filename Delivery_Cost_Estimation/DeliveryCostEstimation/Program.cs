//Main file which starts the application
using System;
using System.Collections.Generic;
using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Bussiness;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using DeliveryCostEstimation.Repo;

        var settings = Console.ReadLine().Split();
        double baseCost = double.Parse(settings[0]);
        int n = int.Parse(settings[1]);

        var results = new List<PackageResult>();
        for (int i = 0; i < n; i++)
        {
            var vals = Console.ReadLine().Split();
            var pkg = new Package
            {
                Id = vals[0],
                Weight = double.Parse(vals[1]),
                Distance = double.Parse(vals[2]),
                OfferCode = vals.Length > 3 ? vals[3] : ""
            };
            results.Add(DeliveryEstimator.Estimate(baseCost, pkg));
        }

        // Output
        foreach (var r in results)
        {
            Console.WriteLine($"{r.Id} {r.Discount} {r.TotalCost}");
        }