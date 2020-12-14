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
            List<Hero> AllHeroes = _context.Heroes.ToList();
            return View(AllHeroes);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int Id)
        {
            Hero chosenHero = _context.Heroes.Where(i => i.Id == Id).FirstOrDefault();
            return View(chosenHero);
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
            Hero heroToEdit = _context.Heroes.Where(h => h.Id == id).FirstOrDefault();
            return View();
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hero updatedHero)
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
        public ActionResult Delete(int Id)
        {
            Hero deleteHero = _context.Heroes.Where(h => h.Id == Id).FirstOrDefault();
            return View(deleteHero);
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
