using MirasolProxy.Converters;
using MirasolProxy.Filter;
using MirasolProxy.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolProxy
{
    public class Facade
    {

        private ApartmentProxyService apartmentProxy;
        private ApartmentFilter apartmentFilter;
        private FacilitiesProxyService facilitiesProxy;
        private AddressProxyService addressProxy;
        private BookingsProxyService bookingsProxy;
        private PricesProxyService pricesProxy;
        private UserProxyService userProxy;
        private CurrencyConverter currencyConverter;

        public ApartmentFilter GetApartmentFilter()
        {
            if (apartmentFilter == null)
            {
                apartmentFilter = new ApartmentFilter();
            }
            return apartmentFilter;
        }

        public ApartmentProxyService GetApartmentProxyService()
        {
            if (apartmentProxy == null)
            {
                apartmentProxy = new ApartmentProxyService();
            }
            return apartmentProxy;
        }

        public FacilitiesProxyService GetFacilitiesProxyService()
        {
            if (facilitiesProxy == null)
            {
                facilitiesProxy = new FacilitiesProxyService();
            }
            return facilitiesProxy;
        }

        public AddressProxyService GetAddressProxyService()
        {
            if (addressProxy == null)
            {
                addressProxy = new AddressProxyService();
            }
            return addressProxy;
        }

        public BookingsProxyService GetBookingsProxyService()
        {
            if (bookingsProxy == null)
            {
                bookingsProxy = new BookingsProxyService();
            }
            return bookingsProxy;
        }

        public PricesProxyService GetPricesProxyService()
        {
            if (pricesProxy == null)
            {
                pricesProxy = new PricesProxyService();
            }
            return pricesProxy;
        }

        public UserProxyService GetUserProxyService()
        {
            if (userProxy == null)
            {
                userProxy = new UserProxyService();
            }
            return userProxy;
        }

        public CurrencyConverter GetCurrencyConverter()
        {
            if (currencyConverter == null)
            {
                currencyConverter = new CurrencyConverter();
            }
            return currencyConverter;
        }
    }
}
