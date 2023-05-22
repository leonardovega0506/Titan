using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Titan.Models.Estafeta.Request;

namespace Titan.Models.Estafeta
{
    public class WayBillsListEstafeta
    {
        //Indica el tipo de guias de la lista:Codigo de Rastreo o Numero de Guia
        public string waybillType { get; set; }

        public Waybills waybills { get; set; }

        //Lista de guias(de 22 caracteres o de codigos de rastreo segun lo indicado en el parametro waybillType)
        public WayBillsListEstafeta(string waybillType, Waybills waysbill)
        {
            this.waybillType = waybillType;
            this.waybills = waysbill;
        }
    }
}
