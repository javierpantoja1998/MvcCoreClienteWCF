using ReferenceCatastro;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceCatastro
    {
        CallejerodelasedeelectrónicadelcatastroSoapClient client;

        public ServiceCatastro(CallejerodelasedeelectrónicadelcatastroSoapClient client)
        {
            this.client = client;
        }


    }
}
