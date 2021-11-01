using HttpClientFactoryDemo.Models;
using HttpClientFactoryDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _service;

        public PostController(IPostService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Post>> GetAll()
        {
            var result = await _service.GetPostAll();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetById(int id)
        {
            var result = await _service.GetPostById(id);
            return Ok(result);
        }






    }
}
