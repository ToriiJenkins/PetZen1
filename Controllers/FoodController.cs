using PetZen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PetZen.Controllers
{
    public class FoodController : Controller
    {
        // Add link to database:Application DB context
        private ApplicationDbContext _db = new ApplicationDbContext();
        
        // GET: Food
        public ActionResult Index()
        {
            //Create a list of Foods
            List<Food> foodList = _db.Foods.ToList();
            List<Food> foodOrderedList = foodList.OrderBy(food => food.Name).ToList();
            return View(foodOrderedList);
        }

        //GET: Food/Create
        public ActionResult Create()
        {
            return View();

        }

        //POST: Food/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                _db.Foods.Add(food);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(food);
        }

        //GET: Food/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food  = _db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //POST: Food/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Food food = _db.Foods.Find(id);
            _db.Foods.Remove(food);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Food/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = _db.Foods.Find(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        //POST: Food/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Food food)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(food).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
        }

        //GET: Food/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = _db.Foods.Find(id);
            if (food== null)
            {
                return HttpNotFound();
            }
            return View(food);
        }
    }
}