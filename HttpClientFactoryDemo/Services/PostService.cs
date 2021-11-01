using HttpClientFactoryDemo.Configuration;
using HttpClientFactoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public class PostService : IPostService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _client;

        public PostService(IApiConfig config, HttpClient client)
        {
            this._config = config;
            this._client = client;
        }

        public async Task<List<Post>> GetPostAll()
        {
            var url = $"{_client.BaseAddress}posts";
            var post = await _client.GetFromJsonAsync<List<Post>>(url);
            return post;
        }

        public async Task<Post> GetPostById(int id)
        {
            var url = $"{_client.BaseAddress}posts/{id}";
            var post = await _client.GetFromJsonAsync<Post>(url);
            return post;
        }
    }
}
