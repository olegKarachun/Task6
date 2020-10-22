using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task6.Models;

namespace Task6.Controllers
{
    public class HomeController : Controller
    {
        MainContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MainContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            ViewBag.Count = db.Notes.Count();
            ViewBag.Notes = db.Notes;
            return View();
        }        
        public void Change(string id, string posX, string posY, int height, int width, string content, string color)
        {     
            Note note = db.Notes.FirstOrDefault(n => n.NoteId == id);
            if (note != null)
            {
                note.PosX = posX;
                note.PosY = posY;
                note.Height = height;
                note.Width = width;
                note.Color = color;
                note.Content = content;
                db.SaveChanges();
            }
            else
            {
                db.Notes.Add(new Note { NoteId = id, PosX = posX, PosY = posY, Color = color, Content = content, Height = height, Width = width });
                db.SaveChanges();
            }
            
        }

        public void Delete(string id)
        {
            Note note = db.Notes.FirstOrDefault(n => n.NoteId == id);            
            db.Notes.Remove(note);
            db.SaveChanges();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
