using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WikinimousMVC.Models;
using WikinimousMVC.Data;

namespace WikinimousMVC.Controllers
{
    public class PostsController : Controller
    {
        private readonly WikinimousMVCContext _context;

        public PostsController(WikinimousMVCContext context)
        {
            _context = context;
        }

        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Post.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
