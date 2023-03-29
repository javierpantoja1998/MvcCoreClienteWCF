using ServiceConversor;

namespace MvcCoreClienteWCF.Services
{
    public class ServicesConversor
    {
        NumberConversionSoapTypeClient client;

        public ServicesConversor()
        {
            this.client = new NumberConversionSoapTypeClient
                (NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);

        }

        public async Task<>
    }
}
