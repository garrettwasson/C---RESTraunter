using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTraunter.Models;

namespace RESTraunter.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ReviewContext _context;
        public ReviewController(ReviewContext context)
        {
            _context = context;
        }
        // GET: /
        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }
        // GET: /reviews 
        [HttpGet("reviews")]
        public IActionResult Reviews()
        {
            ViewBag.allReviews = _context.Reviews.OrderByDescending(review => review.createdAt).ToList();
            return View();
        }
        // POST: /create
        [HttpPost("create")]
        public IActionResult Create(Review reviews)
        {
            if(ModelState.IsValid)
            {
                _context.Reviews.Add(reviews);
                _context.SaveChanges();
                return RedirectToAction("Reviews");
            }
            return View("Home");
        }
    }
}