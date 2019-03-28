using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CPRG214Lab2.AssetTracking.domain
{
    public class AssetType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //navigation property
        public ICollection<Asset> Asset { get; set; }
    }
}
