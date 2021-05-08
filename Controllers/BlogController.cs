using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository;
using Models;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository) => _blogRepository = blogRepository;
        [Route("Page")]
        [HttpGet]
        public async Task<Page<Post>> GetPosts (int pageIndex, string tag)
        {
            return await _blogRepository.GetPosts(pageIndex, 10, tag);
        }
        //public IActionResult Index()
        //{
         //   return View();
       // }
    }
}
