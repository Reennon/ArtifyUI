using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Options;
using UIArtify.Configurations;
using UIArtify.Interfaces;

namespace UIArtify.Services
{
    public sealed class ApiService : IApiService
    {
        public HttpClient HttpClient { get; } = new ();
        //public static string Cookie { get; private set; } = String.Empty;

        public void AddCookie(string cookie)
        {
            HttpClient.DefaultRequestHeaders.Add("COOKIE", "cookie");
            //Cookie = cookie;
        }

        public string GetCookie(HttpResponseMessage httpResponseMessage) =>
            httpResponseMessage.Headers.GetValues("Set-Cookie").First();
        
    }
}