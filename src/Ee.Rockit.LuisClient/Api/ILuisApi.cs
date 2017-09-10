namespace Ee.Rockit.LuisClient.Api
{
    using Ee.Rockit.LuisClient.Client;
    using Ee.Rockit.LuisClient.Model;
    using System.Threading.Tasks;
    using RestSharp;

    public interface ILuisApi : IApiAccessor
    {
        string AppId { get; set; }

        Task<ApiResponse<Prediction>> GetPredictionsFromEndpointAsync(RequestDTO request, Method method);
    }
}
