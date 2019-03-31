using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214Lab2.AssetTracking.BLL;
using CPRG214Lab2.AssetTracking.domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CPRG214Lab2.AssetTracking.App.Controllers
{
    public class AssetTypeController : Controller
    {
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
        public ActionResult Create(AssetType assetType)
        {
            try
            {
                // TODO: Add insert logic here
                AssetTypeManager.Add(assetType);

                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var Type = AssetTypeManager.Find(id);
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(assetTypes, "Id", "Name");
            ViewBag.AssetTypeId = list;
            return View(Type);
        }

        // POST: Assets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AssetType assetType)
        {
            try
            {
                // TODO: Add update logic here
                AssetTypeManager.Update(assetType);
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }
    }
}