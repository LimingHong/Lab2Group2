using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPRG214Lab2.AssetTracking.App.Models
{
    public class AssetsViewModel
    {
        public int Id { get; set; }
        [Required]
        public string TagNumber { get; set; }
        [DisplayName("Asset Type")]
        public string AssetType { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public string Description { get; set; }
        public string SerialNumber { get; set; }
        //navigation property
    }
}
