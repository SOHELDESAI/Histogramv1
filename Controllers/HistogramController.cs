using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class HistogramController : Controller
{
    private List<DataPoint> GenerateRandomData(int count)
    {
        var random = new Random();
        return Enumerable.Range(1, count)
            .Select(x => new DataPoint { X = x, Y = random.Next(1, 10) })
            .ToList();
    }

    public IActionResult Index()
    {
        var histogramData = new List<DataPoint>(GenerateRandomData(10));

        return View(histogramData);
    }

    [HttpGet]
    public IActionResult RefreshData()
    {
        var refreshedData = GenerateRandomData(10); // Modify this to fetch updated data
        return Json(refreshedData);
    }
}
