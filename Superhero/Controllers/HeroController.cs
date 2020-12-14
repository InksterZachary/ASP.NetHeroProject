using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Superhero.Data;
using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero.Controllers
{
    public class HeroController : Controller
    {
        private ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HeroController
        public ActionResult Index()
        {
            var listHeroes = new List<Hero>()
            return View();
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                _context.Heroes.Add(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(Hero hero)
        {
            return View();
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                _context.Heroes.Remove(hero);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
