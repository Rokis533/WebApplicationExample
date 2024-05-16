using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class InfoController : Controller
    {
        public static List<string> _info = new List<string> { "Rokas", "Lukas", "Paulius", "Diana", "Justas" };

        // GET: InfoController
        public ActionResult Index()
        {
            return View(_info);
        }

        // GET: InfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string name)
        {
            try
            {
                _info.Add(name);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InfoController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;

            var name = _info[id];
            return View((object)name);
        }

        // POST: InfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string name)
        {
            try
            {
                _info[id] = name;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
