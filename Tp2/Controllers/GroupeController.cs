using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp2.Models;

namespace Tp2.Controllers
{
    public class GroupeController : Controller
    {
        EcoleContext _context;
        public GroupeController(EcoleContext ctx)
        {
            _context = ctx;
        }
        // GET: GroupeController
        public ActionResult Index()
        {
            return View(_context.groupes.ToList());
        }

        // GET: GroupeController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.groupes.FirstOrDefault(g => g.codeG == id));
        }

        // GET: GroupeController/Create
        public ActionResult Create()
        {
            List<Filiere> filieres = _context.filieres.ToList();
            ViewBag.filieres = filieres;
            return View();
        }

        // POST: GroupeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Groupe collection)
        {
            try
            {
                Filiere filiere = _context.filieres.FirstOrDefault(f => f.codeF == collection.CodeF);
                collection.filiere = filiere;
                _context.groupes.Add(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GroupeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.groupes.FirstOrDefault(g => g.codeG == id));
        }

        // POST: GroupeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Groupe collection)
        {
            try
            {
                Filiere filiere = _context.filieres.FirstOrDefault(f => f.codeF == collection.CodeF);
                collection.filiere = filiere;
                _context.groupes.Update(collection);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GroupeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.groupes.FirstOrDefault(g => g.codeG == id));
        }

        // POST: GroupeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Groupe collection)
        {
            try
            {
                _context.groupes.Remove(collection);
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
