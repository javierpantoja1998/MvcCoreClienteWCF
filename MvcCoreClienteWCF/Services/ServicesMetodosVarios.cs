using ServiceReference2;

namespace MvcCoreClienteWCF.Services
{
    public class ServicesMetodosVarios
    {
        MetodosVariosContractClient client;

        public ServicesMetodosVarios(MetodosVariosContractClient client)
        {
            this.client = client;
        }

        public async Task<int[]> GetTablasMultiplicarAsync(int numero)
        {
            int[] result = await 
                this.client.GetTablaMultiplicarAsync(numero);
            return result;
        }
    }
}
