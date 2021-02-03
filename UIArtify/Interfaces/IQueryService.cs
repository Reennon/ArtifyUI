using System;
using System.Threading.Tasks;

namespace UIArtify.Interfaces
{
    public interface IQueryService
    {
        public UInt16 LastQuery { get; set; }

        public Task Post(String data, String route);

        public Task<Byte[]> Get(String route);
    }
}