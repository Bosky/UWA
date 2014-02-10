using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UWA.Core.BL.Interfaces;

namespace UWA.Core.BL
{
    class Classroom : IBusinessEntity, IMapsObject
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Campus { get; set; }
        public int Building { get; set; }


        double IMapsObject.Longitude { get; set; }
        double IMapsObject.Latitude { get; set; }
    }
}
