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
    public class CommentsController : Controller
    {
      private readonly WikinimousMVCContext _context;

      public CommentsController(WikinimousMVCContext context)
      {
        _context = context;
      }
      //GET: /New
      public IActionResult New(int id)
      {
          var Comment = new Comment();
          Comment.PostId = id;
          return View(Comment);
      }

      //POST: /Create
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Create([Bind("Id,Author,Title,Content,CommentDate,PostId")] Comment comment)
      {
        if (ModelState.IsValid)
        {
          _context.Add(comment);
          await _context.SaveChangesAsync();
          return RedirectToAction("Index", "Posts");
        }
        return RedirectToAction("Index", "Posts");
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
    }
}
