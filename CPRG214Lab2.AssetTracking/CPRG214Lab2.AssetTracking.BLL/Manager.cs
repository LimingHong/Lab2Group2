using CPRG214Lab2.AssetTracking.Data;
using CPRG214Lab2.AssetTracking.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CPRG214Lab2.AssetTracking.BLL
{
    public class AssetTypeManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetTrackingContext();
            var types = context.AssetTypes.Select(o => new
            {
                o.Id,
                o.Name
            }).ToList();
            return types;
        }
        public static List<AssetType> GetAll()
        {
            var context = new AssetTrackingContext();
            return context.AssetTypes.ToList();
        }
        public static void Add(AssetType assetType)
        {
            var context = new AssetTrackingContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }
        public static AssetType Find(int id)
        {
            var context = new AssetTrackingContext();
            //find the domain entity with this context  that has the same id as the entity passed in
            var AssetType =
                context.AssetTypes.SingleOrDefault(A => A.Id == id);
            return AssetType;
        }
        public static void Update(AssetType assetType)
        {

            var context = new AssetTrackingContext();
            //find the domain entity with this context  that has the same id as the entity passed in
            var assetTypeName =
                context.AssetTypes.SingleOrDefault(r => r.Id == assetType.Id);
            //assign the state from rental to propertyRental
            assetTypeName.Name = assetType.Name;
           
            context.SaveChanges();


        }

    }
        public class AssetsManager
        {
            public static List<Asset> GetAll()
            {
                var context = new AssetTrackingContext();
                var Assets = context.Assets.
                    Include(Asset => Asset.AssetType).ToList();
                return Assets;
            }



            public static List<Asset> GetAllByPropertyType(int assetId)
            {
                var context = new AssetTrackingContext();
                var Assets =
                    context.Assets.
                    Include(Asset => Asset.AssetType).
                    Where(A => A.Id == assetId).ToList();
                return Assets;
            }
            public static void Add(Asset asset)
            {
                var context = new AssetTrackingContext();
                context.Assets.Add(asset);
                context.SaveChanges();
            }
            public static Asset Find(int id)
            {
                var context = new AssetTrackingContext();
                //find the domain entity with this context  that has the same id as the entity passed in
                var Asset =
                    context.Assets.SingleOrDefault(A => A.Id == id);
                return Asset;
            }

            public static void Update(Asset asset)
            {

                var context = new AssetTrackingContext();
                //find the domain entity with this context  that has the same id as the entity passed in
                var assetAtt =
                    context.Assets.SingleOrDefault(r => r.Id == asset.Id);
                //assign the state from rental to propertyRental
                assetAtt.TagNumber = asset.TagNumber;
                assetAtt.AssetTypeId = asset.AssetTypeId;
                assetAtt.Manufacturer = asset.Manufacturer;
                assetAtt.Model = asset.Model;
                assetAtt.Description = asset.Description;
                assetAtt.SerialNumber = asset.SerialNumber;

                context.SaveChanges();


            }
        }
    }
