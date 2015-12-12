using DTOModel;
using MirasolProxy.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy.Filter
{
    public class ApartmentFilter
    {
        public IEnumerable<Apartment> ReadAllApartments()
        {
            return new ApartmentProxyService().ReadAll();
        }

        public IEnumerable<Apartment> GetAllTorroxApartments()
        {
            List<Apartment> listOfTorroxApartments = new List<Apartment>();
            foreach(Apartment apartment in ReadAllApartments())
            {
                if (apartment.Address.Contains("Torrox"))
                {
                    listOfTorroxApartments.Add(apartment);
                }
            }
            return listOfTorroxApartments;
        }

        public IEnumerable<Apartment> GetAllMarbellaApartments()
        {
            List<Apartment> listOfMarbellaApartments = new List<Apartment>();
            foreach(Apartment apartment in ReadAllApartments())
            {
                if (apartment.Address.Contains("Marbella"))
                {
                    listOfMarbellaApartments.Add(apartment);
                }
            }
            return listOfMarbellaApartments;
        }
    }
}
