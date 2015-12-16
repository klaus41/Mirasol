using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{

    public class Apartment : AbstractModel
    {
        public string Address { get; set; }
        public int Bedrooms { get; set; }
        public int Sleeps { get; set; }
        public int Bathrooms { get; set; }
        public int Toilets { get; set; }
        public int LivingArea { get; set; }
        public int Terrace { get; set; }
        public string Pool { get; set; }
        public string Jacuzzi { get; set; }
        public bool WiFi { get; set; }
        public bool RoofTerrace { get; set; }
        public bool Garden { get; set; }
        public bool TerraceFurniture { get; set; }
        public bool Satellite { get; set; }
        public bool Balcony { get; set; }
        public bool AirCondition { get; set; }
        public bool Heating { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public int PriceLowSeason { get; set; }
        public int PriceMiddleSeason { get; set; }
        public int PriceHighSeason { get; set; }
        public virtual Facilities Facilities { get; set; }
        public List<string> PictureURLs { get; set; }
    }
}