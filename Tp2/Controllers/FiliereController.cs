using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp2.Models;

namespace Tp2.Controllers
{
    public class FiliereController : Controller
    {
        EcoleContext _context;
        public FiliereController(EcoleContext ctx)
        {
            _context = ctx;
        }
        // GET: FiliereController
        public ActionResult Index()
        {
            return View(_context.filieres.ToList());
        }

        // GET: FiliereController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.filieres.FirstOrDefault(f => f.codeF == id));
        }

        // GET: FiliereController/Create
        public ActionResult Create()
        {
            List<Secteur> secteurs = _context.secteurs.ToList();
            ViewBag.secteurs = secteurs;
            //ViewData["secteurs"] = secteurs;
            return View();
        }

        // POST: FiliereController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filiere collection)
        {
            try
            {
                Secteur secteur = _context.secteurs.FirstOrDefault(s => s.codeSecteur == collection.codeSecteur);
                collection.secteur = secteur;
                _context.filieres.Add(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FiliereController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.filieres.FirstOrDefault(f => f.codeF == id));
        }

        // POST: FiliereController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Filiere collection)
        {
            try
            {
                Secteur secteur = _context.secteurs.FirstOrDefault(s => s.codeSecteur == collection.codeSecteur);
                collection.secteur = secteur;
                _context.filieres.Update(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FiliereController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.filieres.FirstOrDefault(f => f.codeF == id));
        }

        // POST: FiliereController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Filiere collection)
        {
            try
            {
                _context.filieres.Remove(collection);
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
