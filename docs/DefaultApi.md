# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://westus.api.cognitive.microsoft.com/luis/v2.0/apps*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V20ResponseGetPredictionsFromEndpoint**](DefaultApi.md#v20responsegetpredictionsfromendpoint) | **GET** /{appId} | 
[**V20ResponseGetPredictionsFromEndpointPost**](DefaultApi.md#v20responsegetpredictionsfromendpointpost) | **POST** /{appId} | 


<a name="v20responsegetpredictionsfromendpoint"></a>
# **V20ResponseGetPredictionsFromEndpoint**
> void V20ResponseGetPredictionsFromEndpoint (string appId, string q, decimal? timezoneOffset = null, bool? verbose = null, bool? spellCheck = null, bool? staging = null)



Gets the published endpoint predictions for the given query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V20ResponseGetPredictionsFromEndpointExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");
            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var appId = appId_example;  // string | Format - guid. The application ID
            var q = q_example;  // string | The query to predict
            var timezoneOffset = 3.4;  // decimal? | The timezone offset for the location of the request (optional) 
            var verbose = true;  // bool? | If true will return all intents instead of just the topscoring intent (optional) 
            var spellCheck = true;  // bool? | Enable spell checking (optional) 
            var staging = true;  // bool? | Use staging endpoint (optional) 

            try
            {
                apiInstance.V20ResponseGetPredictionsFromEndpoint(appId, q, timezoneOffset, verbose, spellCheck, staging);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V20ResponseGetPredictionsFromEndpoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Format - guid. The application ID | 
 **q** | **string**| The query to predict | 
 **timezoneOffset** | **decimal?**| The timezone offset for the location of the request | [optional] 
 **verbose** | **bool?**| If true will return all intents instead of just the topscoring intent | [optional] 
 **spellCheck** | **bool?**| Enable spell checking | [optional] 
 **staging** | **bool?**| Use staging endpoint | [optional] 

### Return type

void (empty response body)

### Authorization

[apiKeyQuery](../README.md#apiKeyQuery), [apiKeyHeader](../README.md#apiKeyHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v20responsegetpredictionsfromendpointpost"></a>
# **V20ResponseGetPredictionsFromEndpointPost**
> void V20ResponseGetPredictionsFromEndpointPost (string appId, decimal? timezoneOffset = null, bool? verbose = null, bool? spellCheck = null, bool? staging = null, string q = null)



Gets the published endpoint prediction for the given long query

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V20ResponseGetPredictionsFromEndpointPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");
            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DefaultApi();
            var appId = appId_example;  // string | Format - guid. The application ID
            var timezoneOffset = 3.4;  // decimal? | The timezone offset for the location of the request (optional) 
            var verbose = true;  // bool? | If true will return all intents instead of just the topscoring intent (optional) 
            var spellCheck = true;  // bool? | Enable spell checking (optional) 
            var staging = true;  // bool? | Use staging endpoint (optional) 
            var q = q_example;  // string | The query to predict (optional) 

            try
            {
                apiInstance.V20ResponseGetPredictionsFromEndpointPost(appId, timezoneOffset, verbose, spellCheck, staging, q);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V20ResponseGetPredictionsFromEndpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appId** | **string**| Format - guid. The application ID | 
 **timezoneOffset** | **decimal?**| The timezone offset for the location of the request | [optional] 
 **verbose** | **bool?**| If true will return all intents instead of just the topscoring intent | [optional] 
 **spellCheck** | **bool?**| Enable spell checking | [optional] 
 **staging** | **bool?**| Use staging endpoint | [optional] 
 **q** | **string**| The query to predict | [optional] 

### Return type

void (empty response body)

### Authorization

[apiKeyQuery](../README.md#apiKeyQuery), [apiKeyHeader](../README.md#apiKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

