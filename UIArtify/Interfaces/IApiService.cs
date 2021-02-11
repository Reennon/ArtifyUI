using System;
using System.Net.Http;

namespace UIArtify.Interfaces
{
    public interface IApiService
    {
        public HttpClient HttpClient { get; }
        
       // public static string Cookie { get; private set; }

        void AddCookie(string cookie);

        string GetCookie(HttpResponseMessage httpResponseMessage);
    }
}