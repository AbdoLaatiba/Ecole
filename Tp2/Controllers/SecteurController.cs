using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp2.Models;

namespace Tp2.Controllers
{
    public class SecteurController : Controller
    {
        EcoleContext _context;
        public SecteurController(EcoleContext ctx)
        {
            _context = ctx;
        }
        // GET: SecteurController
        public ActionResult Index()
        {
            return View(_context.secteurs.ToList());
        }

        // GET: SecteurController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.secteurs.FirstOrDefault(i => i.codeSecteur == id ));
        }

        // GET: SecteurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecteurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Secteur collection)
        {
            try
            {
                _context.secteurs.Add(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecteurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.secteurs.FirstOrDefault(i => i.codeSecteur == id));
        }

        // POST: SecteurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Secteur collection)
        {
            try
            {
                _context.Update(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecteurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.secteurs.FirstOrDefault(i => i.codeSecteur == id));
        }

        // POST: SecteurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Secteur collection)
        {
            try
            {
                _context.secteurs.Remove(collection);
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
