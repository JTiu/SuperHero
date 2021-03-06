﻿using BoxThemeF_Solution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesNew.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesNew.Controllers
    //Reloaded Visual Studio, all errors now not appearing
{//List<SuperHero> theSups = _context.SuperHeroes.ToList();
    //var person = _context.SuperHeroes.Where(s => s.Name == "Batman").Single();//not really here, but a search method
      //      return View(theSups);
    
    public class BoxTheme : Controller
    {
        private ApplicationDbContext _context;
        public BoxTheme(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHeroesController
        public ActionResult Index()
        {
            List<ScoreCard> theSups = _context.SuperHeroes.ToList();
            //var person = _context.SuperHeroes.Where(s => s.Name == "Batman").Single();//not really here, but a search method
            return View(theSups);
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)
        {

            List<ScoreCard> theSups = _context.SuperHeroes.ToList();
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
        public ActionResult Create(ScoreCard newSup)
        {
            try
            {
                int total_B1 = 0;
                int total_B2 = 0;

                total_B1 += newSup.Round_1_B1;//here to work  Round_1_B2
                total_B2 += newSup.Round_1_B2;//here to work
                total_B1 += newSup.Round_2_B1;
                total_B2 += newSup.Round_2_B2;
                total_B1 += newSup.Round_3_B1;
                total_B2 += newSup.Round_3_B2;
                total_B1 += newSup.Round_4_B1;
                total_B2 += newSup.Round_4_B2;
                total_B1 += newSup.Round_5_B1;
                total_B2 += newSup.Round_5_B2;
                total_B1 += newSup.Round_6_B1;
                total_B2 += newSup.Round_6_B2;
                total_B1 += newSup.Round_7_B1;
                total_B2 += newSup.Round_7_B2;
                total_B1 += newSup.Round_8_B2;
                total_B2 += newSup.Round_8_B2;
                total_B1 += newSup.Round_9_B1;
                total_B2 += newSup.Round_9_B2;
                total_B1 += newSup.Round_10_B1;
                total_B2 += newSup.Round_10_B1;
                total_B1 += newSup.Round_11_B1;
                total_B2 += newSup.Round_11_B2;
                total_B2 += newSup.Round_12_B2;

                
                newSup.Total_B1 = total_B1;
                newSup.Total_B2 = total_B2;
                
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
                //SuperHero superHero = new SuperHero();
                //superHero.Round_1_B1 = collection["Round_1_B1"];
                //superHero.Round_1_B2 = collection["Round_1_B2"];
                //superHero.Round_2_B1 = collection["Round_2_B1"];
                //superHero.Round_2_B2 = collection["Round_2_B2"];
                //superHero.Round_3_B1 = collection["Round_3_B1"];
                //superHero.Round_3_B2 = collection["Round_3_B2"];
                //superHero.Round_3_B1 = collection["Round_4_B1"];
                //superHero.Round_3_B2 = collection["Round_4_B2"];
                //superHero.Round_1_B1 = collection["Round_5_B1"];
                //superHero.Round_1_B2 = collection["Round_5_B2"];
                //superHero.Round_2_B1 = collection["Round_6_B2"];
                //superHero.Round_2_B2 = collection["Round_6_B2"];
                //superHero.Round_3_B1 = collection["Round_7_B2"];
                //superHero.Round_3_B2 = collection["Round_7_B2"];
                //superHero.Round_3_B1 = collection["Round_8_B1"];
                //superHero.Round_3_B2 = collection["Round_8_B2"];
                //superHero.Round_1_B1 = collection["Round_9_B1"];
                //superHero.Round_1_B2 = collection["Round_9_B2"];
                //superHero.Round_2_B1 = collection["Round_10_B2"];
                //superHero.Round_2_B2 = collection["Round_10_B2"];
                //superHero.Round_3_B1 = collection["Round_11_B2"];
                //superHero.Round_3_B2 = collection["Round_11_B2"];
                //superHero.Round_3_B1 = collection["Round_12_B1"];
                //superHero.Round_3_B2 = collection["Round_12_B2"];

                //superHero.Id = id;

                //_context.SuperHeroes.Update(superHero);
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
               
                ScoreCard superHero = new ScoreCard();
                //superHero.Round_1_B1 = collection["Round_1_B1"];
                //superHero.Round_1_B2 = collection["Round_1_B2"];
                //superHero.Round_2_B1 = collection["Round_2_B1"];
                //superHero.Round_2_B2 = collection["Round_2_B2"];
                //superHero.Round_2_B2 = collection["Round_3_B1"];
                //superHero.Round_2_B2 = collection["Round_3_B2"];
                //superHero.Round_1_B1 = collection["Round_4_B1"];
                //superHero.Round_1_B2 = collection["Round_4_B2"];
                //superHero.Round_2_B1 = collection["Round_5_B1"];
                //superHero.Round_2_B2 = collection["Round_5_B2"];
                //superHero.Round_2_B2 = collection["Round_6_B1"];
                //superHero.Round_2_B2 = collection["Round_6_B2"];
                //superHero.Round_1_B1 = collection["Round_7_B1"];
                //superHero.Round_1_B2 = collection["Round_7_B2"];
                //superHero.Round_2_B1 = collection["Round_8_B1"];
                //superHero.Round_2_B2 = collection["Round_8_B2"];
                //superHero.Round_2_B2 = collection["Round_9_B1"];
                //superHero.Round_2_B2 = collection["Round_9_B2"];
                //superHero.Round_1_B1 = collection["Round_10_B1"];
                //superHero.Round_1_B2 = collection["Round_10_B2"];
                //superHero.Round_2_B1 = collection["Round_11_B1"];
                //superHero.Round_2_B2 = collection["Round_11_B2"];
                //superHero.Round_2_B2 = collection["Round_12_B1"];
                //superHero.Round_2_B2 = collection["Round_12_B2"];





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
