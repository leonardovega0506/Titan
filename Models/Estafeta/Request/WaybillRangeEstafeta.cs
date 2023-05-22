using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class WaybillRangeEstafeta
    {
        //Guia inicial del rango 
        public string initialWaybill { get; set; }

        //Guia final del rango
        public string finalWaybill { get; set; }

        public WaybillRangeEstafeta(string initialWaybill, string finalWaybill)
        {
            this.initialWaybill = initialWaybill;
            this.finalWaybill = finalWaybill;
        }
    }
}
