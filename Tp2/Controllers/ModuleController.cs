using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp2.Models;

namespace Tp2.Controllers
{
    public class ModuleController : Controller
    {
        EcoleContext context;
        public ModuleController(EcoleContext ctx)
        {
            context = ctx;
        }
        // GET: ModuleController
        public ActionResult Index()
        {
            return View(context.modules.ToList());
        }

        // GET: ModuleController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.modules.FirstOrDefault(m => m.codeM == id));
        }

        // GET: ModuleController/Create
        public ActionResult Create()
        {
            List<Filiere> filieres = context.filieres.ToList();
            ViewBag.filieres = filieres;
            return View();
        }

        // POST: ModuleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Module collection)
        {
            try
            {
                Filiere filiere = context.filieres.FirstOrDefault(f => f.codeF == collection.codeF);
                collection.filiere = filiere;
                context.modules.Add(collection);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModuleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.modules.FirstOrDefault(m => m.codeM == id));
        }

        // POST: ModuleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Module collection)
        {
            try
            {
                Filiere filiere = context.filieres.FirstOrDefault(f => f.codeF == collection.codeF);
                collection.filiere = filiere;
                context.modules.Update(collection);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModuleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.modules.FirstOrDefault(m => m.codeM == id));
        }

        // POST: ModuleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Module collection)
        {
            try
            {
                context.modules.Remove(collection);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
