using AdoNet_SP_AspNetFramework.DAL;
using AdoNet_SP_AspNetFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNet_SP_AspNetFramework.Controllers
{
    public class ProductsController : Controller
    {
        Product_DAL product_DAL = new Product_DAL();
        // GET: Products
        public ActionResult Index()
        {
            var productList = product_DAL.GetAllProducts();
            if(productList.Count == 0)
            {
                TempData["infoMessage"] = "Productos no encontrados";
            }
            return View(productList);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(ProductModels product)
        {
            try
            {
                // TODO: Add insert logic here

                bool isInserted = false;
                if (ModelState.IsValid)
                {
                    isInserted = product_DAL.InsertProduct(product);
                    if (isInserted)
                    {
                        TempData["successMessage"] = "Producto insertado correctamente";
                    }
                    else
                    {
                        TempData["errorMessage"] = "No se pudo completar la insercion";
                    }
                }
                else
                {
                    TempData["errorMessage"] = "No se pudo completar la insercion";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            var product = product_DAL.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            else
            {
                TempData["errorMessage"] = "Producto no encontrado";
                return RedirectToAction("Index");
            }
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModels product)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    bool isUpdate = product_DAL.UpdateProduct(product);
                    if (isUpdate)
                    {
                        TempData["successMessage"] = "Producto actualizado correctamente";
                    }
                    else
                    {
                        TempData["errorMessage"] = "No se pudo actualizar el producto";
                    }
                }
                else
                {
                    TempData["errorMessage"] = "No se pudo actualizar el producto";
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
