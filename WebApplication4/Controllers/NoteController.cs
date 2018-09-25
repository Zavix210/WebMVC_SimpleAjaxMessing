using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class NotesController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            return View();
        }

        // GET: Note/Details/5
        public ActionResult Details(int id)
        {
            NoteViewModel a = new NoteViewModel()
            {
                first = new decimal(23.2),
                second = DateTime.MinValue, 
                third = 22,
                fourth = "",
                fifth = "", 
                sixth = "", 
                seventh = "", 
                eigth = "", 
                nineth = DateTime.MaxValue
            };
            IEnumerable<NoteViewModel> n = new List<NoteViewModel>()
            {
                a
            };
            return PartialView(n);
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Note/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Note/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Note/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}