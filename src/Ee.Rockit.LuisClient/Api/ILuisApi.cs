using Ee.Rockit.LuisClient.Client;
using Ee.Rockit.LuisClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Ee.Rockit.LuisClient.Api
{
    interface ILuisApi : IApiAccessor
    {
        string AppId { get; set; }

        Task<ApiResponse<Prediction>> GetPredictionsFromEndpointAsync(RequestDTO request, Method method);
    }
}
