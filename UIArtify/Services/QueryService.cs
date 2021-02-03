using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using UIArtify.Configurations;
using UIArtify.Interfaces;

namespace UIArtify.Services
{
    public class QueryService : IQueryService
    {
        public UInt16 LastQuery { get; set; } = 1;

        private readonly HttpClient _client = new();
        private readonly IOptions<Api> _apiConfiguration;

        public QueryService(IOptions<Api> apiConfiguration)
        {
            _apiConfiguration = apiConfiguration;
        }

        public async Task Post(
            String data, String route
        ) => await _client.SendAsync(new()
        {
            Method = HttpMethod.Post, RequestUri = new(route), Content = new StringContent(data, Encoding.UTF8)
        });

        public async Task<Byte[]> Get(
            String route
        ) => await _client.GetByteArrayAsync(new Uri(route));
        
        

    }
}