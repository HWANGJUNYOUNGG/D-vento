using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class WarehouseLocationViewModel
    {
        public List<Warehouse> Warehouses { get; set; }
        public SelectList w_locations { get; set; }
        public string Warehousew_location { get; set; }
        public string SearchString { get; set; }
    }
}
