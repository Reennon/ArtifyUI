using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using UIArtify.Configurations;
using UIArtify.Interfaces;

namespace UIArtify.Services
{
    public class QueryService : IQueryService
    {
        public UInt16 LastQuery { get; set; } = 1;

        private readonly IOptions<Api> _apiConfiguration;

        public QueryService(IOptions<Api> apiConfiguration)
        {
            _apiConfiguration = apiConfiguration;
        }

        public async Task Post(
            (String name, String data, String? extension) file
            , HttpClient client
        )
        {
            // var route = new DirectoryInfo(@"Cache").Exists
            //     ? $"{new DirectoryInfo(@"Cache").FullName}/{file.name}"
            //     : $"{Directory.CreateDirectory(@"Cache").FullName}/{file.name}";
            // await File.WriteAllLinesAsync(route, file.data);
            //var file streeFile.Create(file.name);
            await client.PostAsJsonAsync(
                _apiConfiguration.Value.ScriptJson,
                new
                {
                    name = file.name       
                    , data = file.data       
                    , type = file.extension 
                });
            //Directory.Delete(route);
        }
    

        public async Task RunBuild(
            HttpClient client
            , String dllName
        ) => await client.PostAsJsonAsync(
            _apiConfiguration.Value.Build,
            new
            {
                dllName
            });
        
        public async Task<String> Output(
            HttpClient client
        ){ 
            var responseMessage = await client.GetAsync(_apiConfiguration.Value.Output);
            var content = await responseMessage.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Dictionary<String, String>>(content);
            Console.WriteLine(json["output"]);
            return json["output"].Trim('b','\'').Replace("\\r\\n",@"<br/>");
        }
        
        

    }
}