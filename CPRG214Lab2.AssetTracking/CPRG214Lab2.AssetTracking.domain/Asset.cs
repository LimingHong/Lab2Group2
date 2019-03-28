using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CPRG214Lab2.AssetTracking.domain
{
    public class Asset
    {
        public int Id { get; set; }
        [Required]
        public string TagNumber { get; set; }
        public int AssetTypeId { get; set; }
       
         public string Manufacturer { get; set; }
        public string Model { get; set; }
        
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        //navigation property
        public AssetType AssetType { get; set; }
      

    }
}
