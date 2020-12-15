using PetZen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static PetZen.Models.Pet;

namespace PetZen.Controllers
{
    public class PetController : Controller
    {

        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Pet
        public ActionResult Index()
        {
            List<Pet> petList = _db.Pets.ToList();
            List<Pet> orderedPetList = petList.OrderBy(pet => pet.DateOfBirth).ToList();

            return View(orderedPetList);
        }

        //GET: PET/CREATE
        public ActionResult Create()
        {
            return View();

        }

        //POST: Pet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                _db.Pets.Add(pet);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }

        //GET: Pet/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet= _db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        //POST: Pet/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Pet pet = _db.Pets.Find(id);
            _db.Pets.Remove(pet);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Pet/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = _db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        //POST: Pet/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pet pet)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        //GET: Product/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet= _db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }


    }
}