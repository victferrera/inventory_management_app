using GE.BL.Entities;
using GE.BL.Interfaces;
using GE.BL.Messages;
using RestSharp;
using System.Net;
using System.Text.Json;

namespace GE.Services.ZipCode
{
    public class ZipCodeService : IZipCodeService
    {
        private RestClient _restClient;
        private readonly string _baseUrl = "https://viacep.com.br/ws/";
        private readonly string _responseFormat = "json";

        public ZipCodeService()
        {
            _restClient = new RestClient();
        }

        public Address GetZipCodeInfo(string zipCode)
        {
            string resource = $"{_baseUrl}{zipCode}/{_responseFormat}/";
            RestRequest request = new RestRequest(resource, Method.Get);

            try
            {
                var response = _restClient.Execute(request);

                if (response.StatusCode.Equals(HttpStatusCode.BadRequest))
                    throw new FormatException(ErrorMessages.invalidZipCodeFormat);

                if (response != null)
                {
                    return JsonSerializer.Deserialize<Address>(response.Content);
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
