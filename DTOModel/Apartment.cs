using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{

    public class Apartment : AbstractModel
    {
        public Address Address { get; set; }
        public int Bedrooms { get; set; }
        public int Sleeps { get; set; }
        public int Bathrooms { get; set; }
        public int Toilets { get; set; }
        public int LivingArea { get; set; }
        public int Terrace { get; set; }
        public bool SharedPool { get; set; }
        public bool PrivatePool { get; set; }
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
        public Prices Prices { get; set; }
        public bool OutsideJacuzzi { get; set; }
        public virtual Facilities Facilities { get; set; }
        public List<string> PictureURLs { get; set; }
        public string Description { get; set; }
    }
}