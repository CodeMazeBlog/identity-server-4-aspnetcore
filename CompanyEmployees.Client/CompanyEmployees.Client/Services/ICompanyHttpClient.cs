using System.Net.Http;
using System.Threading.Tasks;

namespace CompanyEmployees.Client.Services
{
    public interface ICompanyHttpClient
    {
        Task<HttpClient> GetClient();
    }
}
