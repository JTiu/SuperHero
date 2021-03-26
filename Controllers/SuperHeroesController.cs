﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesNew.Data;
using SuperHeroesNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesNew.Controllers
    //Reloaded Visual Studio, all errors now not appearing
{//List<SuperHero> theSups = _context.SuperHeroes.ToList();
    //var person = _context.SuperHeroes.Where(s => s.Name == "Batman").Single();//not really here, but a search method
      //      return View(theSups);
    
    public class SuperHeroesController : Controller
    {
        private ApplicationDbContext _context;
        public SuperHeroesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHeroesController
        public ActionResult Index()
        {
            List<SuperHero> theSups = _context.SuperHeroes.ToList();
            //var person = _context.SuperHeroes.Where(s => s.Name == "Batman").Single();//not really here, but a search method
            return View(theSups);
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)
        {

            List<SuperHero> theSups = _context.SuperHeroes.ToList();
            var person = _context.SuperHeroes.Where(s => s.Id == id).Single();//not really here, but a search method
            return View(person);
        }

        // GET: SuperHeroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero newSup)
        {
            try
            {
                _context.SuperHeroes.Add(newSup);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Edit/5
        public ActionResult Edit(int id)
        {
           // List<SuperHero> theSups = _context.SuperHeroes.ToList();
            var person = _context.SuperHeroes.Where(s => s.Id == id).Single();//not really here, but a search method
            return View(person);
        }

        // POST: SuperHeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                SuperHero superHero = new SuperHero();
                superHero.Round_1_B1 = collection["Round_1_B1"];
                superHero.Round_1_B2 = collection["Round_1_B2"];
                superHero.Round_2_B1 = collection["Round_1_B2"];
                superHero.Round_2_B2 = collection["Round_2_B2"];
                superHero.Round_3_B1 = collection["Round_3_B2"];
                superHero.Round_3_B2 = collection["Round_1_B2"];
                superHero.Id = id;

                _context.SuperHeroes.Update(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Delete/5
        public ActionResult Delete(int id)
        {
            var person = _context.SuperHeroes.Where(s => s.Id == id).Single();
            return View(person);
        }

        // POST: SuperHeroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
               
                SuperHero superHero = new SuperHero();
                superHero.Round_1_B1 = collection["Round_1_B1"];
                superHero.Round_1_B2 = collection["Round_1_B2"];
                superHero.Round_2_B1 = collection["Round_2_B1"];
                superHero.Round_2_B2 = collection["Round_2_B2"];
                superHero.Round_2_B2 = collection["Round_3_B1"];
                superHero.Id = id;
                _context.SuperHeroes.Remove(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
