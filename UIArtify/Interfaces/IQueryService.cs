using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UIArtify.Interfaces
{
    public interface IQueryService
    {
        public UInt16 LastQuery { get; set; }

        public Task Post(
            (String name, String data, String? extension) file
            , HttpClient client
        );

        Task RunBuild(
            HttpClient client
            , String dllName
        );

        Task<String> Output(
            HttpClient client
        );
    }
}