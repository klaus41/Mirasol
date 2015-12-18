using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTOModel;
using System.Collections.Generic;
using MirasolProxy.Filter;

namespace MirasolTest
{
    [TestClass]
    public class FilterTest
    {

        #region 
        static Address address1 = new Address()
        {
            Id = 1,
            City = "Marbella",
            HouseNr = 1,
            StreetName = "Imginary street",
            ZipCode = 56000
        };

        static Address address2 = new Address()
        {
            Id = 2,
            City = "Torrox",
            HouseNr = 1,
            StreetName = "Imginary street",
            ZipCode = 56000

        };

        static Address addressKlaus = new Address()
        {
            Id = 3,
            City = "Esbjerg",
            Country = "Denmark",
            HouseNr = 46,
            Floor = 3,
            StreetName = "Strandbygade",
            ZipCode = 6700,
        };

        static Prices pricePuntaDelFaro = new Prices()
        {
            Id = 1,
            BeachTowels = 5,
            FinalCleaning = 80,
            LinenAndTowels = 12,
            LowSeason = 530,
            MidSeason = 695,
            HighSeason = 895
        };

        static Prices priceCalaceite = new Prices()
        {
            Id = 2,
            FinalCleaning = 85,
            LowSeason = 395,
            MidSeason = 495,
            HighSeason = 595
        };

        static Facilities facility1 = new Facilities()
        {
            Id = 1,
            Inside = "Wi-Fi, air conditioning, heating, tv, intercom, iron, ironing board",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, washing machine, dryer, hob, microwave, oven, kettle, toaster",
            Bathroom = "Shower, bath tub, hair dryer",
            Beds = "1 Double bed",
            Views = "Sea views, mountain views, pool views",
            SuitableFor = "Suitable for the elderly, pets not allowed, no smoking inside, car necessary",
        };

        static Facilities facility2 = new Facilities()
        {
            Id = 2,
            Inside = "Wi-fi, air conditioning, heating, tv, intercom, iron, ironing board",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, washing machine, dryer, hob, oven, kettle, toaster",
            Bathroom = "Shower, bath tub, hair dryer",
            Beds = "2 double beds (1 extra mattress)",
            Views = "Sea views, mountan views, pool views",
            SuitableFor = "Suitable for the elderly, pets not allowed, no smoking inside, car necessary"
        };

        static Facilities facility3 = new Facilities()
        {
            Id = 3,
            Inside = "Wi-fi, air conditioning, heating, washing machine, tv, intercom, iron, ironing board",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, oven, kettle, toaster",
            Bathroom = "Jacuzzi, shower, bath tub, hair dryer",
            Beds = "2 double beds",
            Views = "Sea views, mountain views, pool views",
            SuitableFor = "Wheelchair accessible, suitable for the elderly, pets not allowed, no smoking inside, car not neccessary",
            Notes = "There is sleeping accomodation for 2 extra people on air mattress in the living room"
        };

        static Facilities facility4 = new Facilities()
        {
            Id = 4,
            General = "Linen provided, towels provided",
            Outside = "Shared pool, outside jacuzzi, garden, terrace, terrace furniture, sunbeds, barbeque, parking, private parking, garage, lift",
            Inside = "Wi-fi, sattelite, air conditioning, heating, washing machine, tv, iron, ironing board, children's high chair, cradle",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, oven, kettle, toaster",
            Bathroom = "Shower, bath tub, hair dryer",
            Beds = "2 double beds",
            Views = "Sea views, mountain views, pool views",
            SuitableFor = "pets not allowed, no smoking inside, car not ncessary"
        };

        static Facilities facility5 = new Facilities()
        {
            Id = 5,
            General = "Linen provided, towels included",
            Outside = "Shared pool, private pool, roof terrace, garden, terrace, terrace furniture, parking, private parking, garage, lift",
            Inside = "Wi-Fi, air conditioning, heatin, washing machine, tv, tumble dryer, ceiling fan, intercom, iron, ironing board, children's high chair, cradle",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, microwave, oven, toaster",
            Bathroom = "Shower, bath tub, hair dryer",
            Beds = "1 double bed, 4 single beds",
            SuitableFor = "Pets not allowed, no smoking inside, car not necessary"
        };

        static Facilities facility6 = new Facilities()
        {
            Id = 6,
            General = "Linen provided, towels provided",
            Outside = "Shared pool, outside jacuzzi, roof terrace, terrace, terrace furniture, sunbeds, barbeque, parking, private parking, garage, lift",
            Inside = "Wi-Fi, sattelite, air conditioning, heating, dvd player, washing machine, tv, intercom, iron, ironing board, children's high chair, cradle",
            Kitchen = "Dishwasher, freezer, refridgerator, coffee machine, hob, microwave, oven, blender, toaster",
            Bathroom = "Jacuzzi, shower, bath tub, hair  dryer",
            Beds = "4 single beds, 2 sofa beds",
            Views = "Sea views, mountain views, pool views",
            SuitableFor = "Pets not allowed, no smoking inside, car not necessary"
        };



        static User user1 = new User()
        {
            Id = 1,
            Address = address1,
            Email = "klausgaarde@live.dk",
            Name = "Klaus Gaarde",
            Password = "240789"
        };


        static Apartment apartment1 = new Apartment()
        {
            Address = address2,
            Bedrooms = 1,
            Sleeps = 2,
            Bathrooms = 1,
            LivingArea = 70,
            Terrace = 55,
            WiFi = true,
            Balcony = true,
            Garden = true,
            TerraceFurniture = true,
            AirCondition = true,
            Heating = true,
            Prices = priceCalaceite,
            Facilities = facility1,
            Name = "1202"
        };

        Apartment apartment2 = new Apartment()
        {
            Address = address2,
            Bedrooms = 2,
            Bathrooms = 2,
            Sleeps = 5,
            LivingArea = 90,
            Terrace = 24,
            SharedPool = true,
            WiFi = true,
            Balcony = true,
            Garden = true,
            TerraceFurniture = true,
            AirCondition = true,
            Heating = true,
            Facilities = facility2,
            Prices = priceCalaceite,
            Name = "5332"
        };

        Apartment apartment3 = new Apartment()
        {
            Address = address1,
            Bedrooms = 2,
            Sleeps = 4,
            Bathrooms = 2,
            LivingArea = 90,
            Terrace = 30,
            SharedPool = true,
            WiFi = true,
            Balcony = true,
            Garden = true,
            TerraceFurniture = true,
            AirCondition = true,
            Heating = true,
            Facilities = facility3,
            Prices = pricePuntaDelFaro,
            Name = "13436"
        };

        Apartment apartment4 = new Apartment()
        {
            Address = address1,
            Bedrooms = 2,
            Sleeps = 4,
            Bathrooms = 2,
            LivingArea = 80,
            Terrace = 72,
            SharedPool = true,
            OutsideJacuzzi = true,
            WiFi = true,
            Garden = true,
            TerraceFurniture = true,
            Satellite = true,
            AirCondition = true,
            Facilities = facility4,
            Prices = pricePuntaDelFaro,
            Name = "19946"
        };

        Apartment apartment5 = new Apartment()
        {
            Address = address1,
            Bedrooms = 3,
            Sleeps = 7,
            Bathrooms = 2,
            Toilets = 1,
            LivingArea = 120,
            Terrace = 40,
            SharedPool = true,
            PrivatePool = true,
            WiFi = true,
            RoofTerrace = true,
            Garden = true,
            TerraceFurniture = true,
            Facilities = facility5,
            Prices = pricePuntaDelFaro,
            Name = "22176"
        };

        Apartment apartment6 = new Apartment()
        {
            Address = address1,
            Bedrooms = 3,
            Sleeps = 6,
            Bathrooms = 2,
            LivingArea = 80,
            Terrace = 72,
            SharedPool = true,
            OutsideJacuzzi = true,
            WiFi = true,
            RoofTerrace = true,
            Garden = true,
            TerraceFurniture = true,
            Satellite = true,
            Facilities = facility6,
            Prices = pricePuntaDelFaro,
            Name = "17576"
        };

        Apartment apartment7 = new Apartment()
        {
            Address = address1,
            Bedrooms = 2,
            Sleeps = 6,
            Bathrooms = 2,
            LivingArea = 80,
            Terrace = 72,
            SharedPool = true,
            OutsideJacuzzi = true,
            WiFi = true,
            RoofTerrace = true,
            Garden = true,
            TerraceFurniture = true,
            Satellite = true,
            Prices = pricePuntaDelFaro,
            Name = "22711"
        };

        Bookings booking1 = new Bookings()
        {
            Id = 1,
            Apartment = apartment1,
            EndDate = new DateTime(2015, 10, 10),
            StartDate = new DateTime(2015, 10, 17),
            User = user1,
        };
        #endregion

        [TestMethod]
        public void TorroxFilterTester()
        {
            ApartmentFilter apartFilter = new ApartmentFilter();
            IEnumerable<Apartment> expectedResult = new List<Apartment>() { apartment1, apartment2 };
            IEnumerable<Apartment> testResult = apartFilter.GetAllTorroxApartments();

            Assert.Equals(expectedResult, testResult);
        }
    }
}
