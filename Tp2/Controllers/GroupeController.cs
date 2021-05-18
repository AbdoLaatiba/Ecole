using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp2.Controllers
{
    public class GroupeController : Controller
    {
        // GET: GroupeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GroupeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GroupeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GroupeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: GroupeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GroupeController/Edit/5
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

        // GET: GroupeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GroupeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
