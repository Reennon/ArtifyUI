using UIArtify.Models;
using UIArtify.Models.Account;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Text;
//using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace UIArtify.Services
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task Login(Login model);
        Task Logout();
        Task Register(AddUser model);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }

    public class AccountService : IAccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";

        public User User { get; private set; }

        public AccountService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        ) {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<User>(_userKey);
        }

        public async Task Login(Login model)
        {
            User = await _httpService.Post<User>("/users/authenticate", model);
            await _localStorageService.SetItem(_userKey, User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("account/login");
        }
        
        public async Task Register(AddUser model)
        {

            HttpClient client = new HttpClient();
            var content = System.Text.Json.JsonSerializer.Serialize(new { password = "zdfgdor", email = "werf", username = "fsfsd" });
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var registrationResult = await client.PostAsync("http://127.0.0.1:4000/signup", bodyContent);
            var registrationContent = await registrationResult.Content.ReadAsStringAsync();
            var addItem = new { Name = "fsd", IsComplete = "erfvs" };
            //await System.Net.Http.PostAsJsonAsync("api/TodoItems", addItem);

            var Content = new StringContent(JsonConvert.SerializeObject(
                new
                {
                    username = "gfdgd"
                    ,
                    email = "fsdf"
                    ,
                    password = "gdf"
                }), Encoding.UTF8, "application/json");
            //var content3 = "{\"password\":\"Blazor\",\"email\":\"werf\",\"username\":\"fsfsd\"}";
            //var content = System.Text.Json.JsonSerializer.Serialize(content3);
            //var addItem = { "username" = "dfssdf", password = "ffffffffff", email = "fsdsfg" } ;
            // var response = client.PostAsync("api/AgentCollection", new StringContent(
            // new JavaScriptSerializer().Serialize(user), Encoding.UTF8, "application/json")).Result;
            
            var response2 = await client.SendAsync(new()
            {
                Method = HttpMethod.Post,
                RequestUri = new("http://127.0.0.1:4000/signup"),
                Content = Content
            });
            //var addItem = new { Name = newItemName, IsComplete = false };
            //await Http.PostAsJsonAsync("api/TodoItems", model);
            //HttpClient _client = new HttpClient();
            //var content = JsonSerializer.Serialize(new { password = "Blazor", email = "weïrf", username = "fsfsd" });
            //var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            //var registrationResult = await _client.PostAsync("http://127.0.0.1:4000/signup", bodyContent);
            //var registrationContent =  registrationResult.Content.ReadAsStringAsync();
            await _httpService.Post("http://127.0.0.1:4000/signup", model);
        }

        public async Task<IList<User>> GetAll()
        {
            return await _httpService.Get<IList<User>>("/users");
        }

        public async Task<User> GetById(string id)
        {
            return await _httpService.Get<User>($"/users/{id}");
        }

        public async Task Update(string id, EditUser model)
        {
            await _httpService.Put($"/users/{id}", model);

            // update stored user if the logged in user updated their own record
            if (id == User.Id) 
            {
                // update local storage
                User.FirstName = model.FirstName;
                User.LastName = model.LastName;
                User.Username = model.Username;
                await _localStorageService.SetItem(_userKey, User);
            }
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/users/{id}");

            // auto logout if the logged in user deleted their own record
            if (id == User.Id)
                await Logout();
        }
    }
}