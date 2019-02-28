using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetMVCChallenge.Models;
using System.Net;
using Newtonsoft.Json;
using MyLibrary;
using static MyLibrary.AsteroidInformation;

namespace DotNetMVCChallenge.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var astrItems = new List<Asteroid[]>();
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"https://api.nasa.gov/neo/rest/v1/feed?start_date=2019-01-01&end_date=2019-01-02&api_key=RKPwe2Bns2ICWHTj890M6y0tEisOw4J5uN25rurq");
            var deserializedJson = JsonConvert.DeserializeObject<AsteroidInformation.RootObject>(json);

            foreach (KeyValuePair<string, Asteroid[]> astrDictionary in deserializedJson.near_earth_objects)
            {
                foreach (Asteroid[] asteroid in deserializedJson.near_earth_objects.Values)
                {
                    astrItems.Add(asteroid); 
                }
            }

            return View(astrItems);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
