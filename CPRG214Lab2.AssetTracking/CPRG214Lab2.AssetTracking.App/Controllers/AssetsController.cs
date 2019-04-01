using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214Lab2.AssetTracking.App.Models;
using CPRG214Lab2.AssetTracking.BLL;
using CPRG214Lab2.AssetTracking.domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CPRG214Lab2.AssetTracking.App.Controllers
{
    public class AssetsController : Controller
    {
        // GET: Assets
        public ActionResult Index()
        {
            var assets = AssetsManager.GetAll().
               Select(a => new AssetsViewModel
               {
                   TagNumber = a.TagNumber,
                   Manufacturer = a.Manufacturer,
                   Id = a.Id,
                   Model = a.Model,
                   AssetType = a.AssetType.Name,
                   Description = a.Description,
                   SerialNumber = a.SerialNumber
               }).ToList();

            //pass the model to the view
            return View(assets);
            
        }

        // GET: Assets/Details/5
        public ActionResult Details(int id)
        {
            var asset = AssetsManager.Find(id);
            return View(asset);
        }

        // GET: Assets/Create
        public ActionResult Create()
        {    //get property types and owners from their managers
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(assetTypes, "Id", "Name");
            ViewBag.AssetTypeId = list;
            return View();
           
        }

        // POST: Assets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asset asset)
        {
            try
            {
                // TODO: Add insert logic here
                AssetsManager.Add(asset);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assets/Edit/5
        public ActionResult Edit(int id)
        {
            var asset = AssetsManager.Find(id);
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(assetTypes, "Id", "Name");
            ViewBag.AssetTypeId = list;
            return View(asset);
        }

        // POST: Assets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Asset asset)
        {
            try
            {
                // TODO: Add update logic here
                AssetsManager.Update(asset);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Search()
        {
            //need to get the property types collection and assign to the ViewBag
            //Working with a SelectListItem List collection so we can insert a
            //SelectLitItem for selecting all rentals base on an id of 0 
            List<SelectListItem> items = AssetTypeManager.GetAll().
                Select(a => new SelectListItem
                {
                    Text = a.Name,
                    Value = a.Id.ToString()
                }).ToList();

            //This list item is inserted at the first position in the collection and
            //has a value of 0.  This value of 0 is tested in the ViewComponent.  If
            //the property type id is 0 we want all rentals returned otherwise we will
            //use the id in the query.
            items.Insert(0, new SelectListItem { Text = "AssetType Name", Value = "0" });

            //Pass the SelectListItem collection to the view through the ViewBag
            //ViewBag is strongly-typed
            ViewBag.AssetTypes = items;

            //return the view
            return View();
        }

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetByType", id);
        }


    }
}