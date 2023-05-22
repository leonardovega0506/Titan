using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class SerachTypeEstafeta
    {
        //Indica el tipo de busqueda que se desea ejecutar, por rando o por lista
        public string type { get; set; }
        //Objeto para especificar la lista de guia que se desea consultar
        public WayBillsListEstafeta waybillList { get; set; }

        //Objeto para especificar el rango de guias que se desea consultar
        public WaybillRangeEstafeta waybillRange { get; set; }


        public SerachTypeEstafeta(string type, WayBillsListEstafeta wallBillsLists, WaybillRangeEstafeta wallbillRange)
        {
            this.type = type;
            this.waybillList = wallBillsLists;
            this.waybillRange = wallbillRange;
            
        }
    }
}
