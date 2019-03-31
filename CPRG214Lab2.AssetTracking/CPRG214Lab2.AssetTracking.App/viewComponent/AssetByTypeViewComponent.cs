using CPRG214Lab2.AssetTracking.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static CPRG214Lab2.AssetTracking.BLL.AssetManager;

namespace CPRG214Lab2.AssetTracking.App.Models.viewComponent
{
    public class AssetByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            //get the model asynchronously and pass to the view (ViewModel)
            var assets =AssetsManager.GetAllByPropertyType(id).
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

            return View(assets);
        }
    }
}
