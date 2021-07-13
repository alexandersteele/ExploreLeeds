using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreLeeds.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreLeeds.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {

        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1, 12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "First post!",
                Posted = DateTime.Now,
                Author = "Alexander Steele",
                Body = "A good running start to the blog (now using a model)!"
            };



            return View(post);
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();

            return View();
        }

    }
}
