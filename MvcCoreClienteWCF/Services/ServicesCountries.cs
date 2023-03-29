using ServiceReference1;

namespace MvcCoreClienteWCF.Services
{
    public class ServicesCountries
    {
        CountryInfoServiceSoapTypeClient client;

        public ServicesCountries()
        {
            this.client = new CountryInfoServiceSoapTypeClient
                (CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }



        public async Task<tCountryCodeAndName[]> GetCountriesAsync()
        {
            //LAS PETICIONES SE BASAN EN OBJETOS RESPONSE
            ListOfCountryNamesByNameResponse response =
                await this.client.ListOfCountryNamesByNameAsync();
            tCountryCodeAndName[] datos =
                response.Body.ListOfCountryNamesByNameResult;

            return datos;
        }



        public async Task<tCountryInfo> GetCountryInfoAsync(string isoCode)
        {
            FullCountryInfoResponse response =
                await this.client.FullCountryInfoAsync(isoCode);
            tCountryInfo countryInfo = response.Body.FullCountryInfoResult;
            return countryInfo;
        }








    }
}
