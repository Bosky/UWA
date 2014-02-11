using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UWA.Core.BL.Interfaces;

namespace UWA.Core.BL
{
    public class PlaceCategory : IBusinessEntity, IPlaceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
