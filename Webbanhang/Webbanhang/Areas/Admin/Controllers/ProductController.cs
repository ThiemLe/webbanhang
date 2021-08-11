using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbanhang.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        WebbanhangDbContext _database = new WebbanhangDbContext();
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View(_database.Products.ToList());
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View(_database.Products.Where(s => s.ID == id).FirstOrDefault());
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            Product pro = new Product();
            return View(pro);
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            try
            {
                // TODO: Add insert logic here

                if (pro.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(pro.ImageUpload.FileName);
                    string extension = Path.GetExtension(pro.ImageUpload.FileName);
                    fileName = fileName + extension;
                    pro.Image = "/Asset/Product/" + fileName;
                    pro.ImageUpload.SaveAs(Path.Combine(Server.MapPath("/Asset/Product/"), fileName));
                }
                _database.Products.Add(pro);
                _database.SaveChanges();
                return RedirectToAction("Index");

            }

            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_database.Products.Where(s => s.ID == id).FirstOrDefault());
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product pro)
        {
            try
            {
                // TODO: Add update logic here
                if (pro.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(pro.ImageUpload.FileName);
                    string extension = Path.GetExtension(pro.ImageUpload.FileName);
                    fileName = fileName + extension;
                    pro.Image = "/Asset/Product/" + fileName;
                    pro.ImageUpload.SaveAs(Path.Combine(Server.MapPath("/Asset/Product/"), fileName));
                }
                _database.Entry(pro).State = EntityState.Modified;
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_database.Products.Where(s => s.ID == id).FirstOrDefault());
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product pro)
        {
            try
            {
                // TODO: Add delete logic here
                pro = _database.Products.Where(s => s.ID == id).FirstOrDefault();
                _database.Products.Remove(pro);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}