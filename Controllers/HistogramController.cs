using Microsoft.AspNetCore.Mvc;
using Histogramv1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class HistogramController : Controller
{
    //private List<DataPoint> GenerateRandomData(int count)
    //{
    //    var random = new Random();
    //    return Enumerable.Range(1, count)
    //        .Select(x => new DataPoint { X = x, Y = random.Next(1, 10) })
    //        .ToList();
    //}

    public IActionResult Index()
    {
        var random = new Random();
        var histogramData = new DataPoint
        {
            //Values = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 }
            Values = GenerateRandomData(15, random, 1, 5)
        };

        return View(histogramData);
    }
    private List<int> GenerateRandomData(int count, Random random, int minValue, int maxValue)
    {
        var data = new List<int>();
        for (int i = 0; i < count; i++)
        {
            data.Add(random.Next(minValue, maxValue + 1));
        }
        return data;
    }

    //[HttpGet]
    //public IActionResult RefreshData()
    //{
    //    var refreshedData = GenerateRandomData(10); // Modify this to fetch updated data
    //    return Json(refreshedData);
    //}
}
