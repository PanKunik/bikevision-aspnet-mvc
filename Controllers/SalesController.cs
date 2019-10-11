﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bikevision.Models;

namespace bikevision.Controllers
{
    public class SalesController : Controller
    {
        private BikeVisionDBEntities2 db = new BikeVisionDBEntities2();

        // GET: Sales
        public ActionResult Index()
        {
            var sale = db.Sale.Include(s => s.Customer).Include(s => s.Employee).Include(s => s.SaleType);
            return View(sale.ToList());
        }

        // GET: Sales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            ViewBag.Customer_idCustomer = new SelectList(db.Customer, "idCustomer", "name");
            ViewBag.Employee_idEmployee = new SelectList(db.Employee, "idEmployee", "name");
            ViewBag.SaleType_idSaleType = new SelectList(db.SaleType, "idSaleType", "type");
            return View();
        }

        // POST: Sales/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idSale,date,value,Customer_idCustomer,SaleType_idSaleType,Employee_idEmployee")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Sale.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Customer_idCustomer = new SelectList(db.Customer, "idCustomer", "name", sale.Customer_idCustomer);
            ViewBag.Employee_idEmployee = new SelectList(db.Employee, "idEmployee", "name", sale.Employee_idEmployee);
            ViewBag.SaleType_idSaleType = new SelectList(db.SaleType, "idSaleType", "type", sale.SaleType_idSaleType);
            return View(sale);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.Customer_idCustomer = new SelectList(db.Customer, "idCustomer", "name", sale.Customer_idCustomer);
            ViewBag.Employee_idEmployee = new SelectList(db.Employee, "idEmployee", "name", sale.Employee_idEmployee);
            ViewBag.SaleType_idSaleType = new SelectList(db.SaleType, "idSaleType", "type", sale.SaleType_idSaleType);
            return View(sale);
        }

        // POST: Sales/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idSale,date,value,Customer_idCustomer,SaleType_idSaleType,Employee_idEmployee")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Customer_idCustomer = new SelectList(db.Customer, "idCustomer", "name", sale.Customer_idCustomer);
            ViewBag.Employee_idEmployee = new SelectList(db.Employee, "idEmployee", "name", sale.Employee_idEmployee);
            ViewBag.SaleType_idSaleType = new SelectList(db.SaleType, "idSaleType", "type", sale.SaleType_idSaleType);
            return View(sale);
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sale.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sale sale = db.Sale.Find(id);
            db.Sale.Remove(sale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
