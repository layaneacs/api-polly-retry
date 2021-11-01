using HttpClientFactoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public interface IPostService
    {
        Task<Post> GetPostById(int id);
        Task<List<Post>> GetPostAll();
    }
}
