using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    public class BeersController : Controller
    {
        [HttpGet("")]
        public IEnumerable<Beer> Get()
        {
            return new List<Beer>(){ 
                new Beer{
                    Title = "Punk IPA",
                    Description = "POST MODERN CLASSIC - SPIKY. TROPICAL. HOPPY.",
                    Abv = "5.6%",
                    ImagePath = "punkipa.png",
                    IsInStock = true
                },
                new Beer{
                    Title = "Dead Pony Club",
                    Description = "WEST COAST KICKS - CITRUSY. ZESTY. BRIGHT.",
                    Abv = "3.8%",
                    ImagePath = "dpc.png",
                    IsInStock = true
                },
                new Beer{
                    Title = "5am Saint",
                    Description = "BITTER SWEET CHAOS - MALTY. FRUITY. BITE.",
                    Abv = "5%",
                    ImagePath = "5am.png"
                },
            };
        }

        public class Beer
        {
            public string Title { get; set; }
            public string Description {get; set;}
            public string ImagePath { get; set; }
            public string Abv { get; set; }
            public bool IsInStock { get; set; }
        }
    }
}
