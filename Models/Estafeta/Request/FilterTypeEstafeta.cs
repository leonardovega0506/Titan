using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class FilterTypeEstafeta
    {
        //Indica si se desea filtrar la informacion segun su estatus de entrega
        public bool filterInformation { get; set; }

        //DELIVERED- Si sólo se desea obtener la informacion de los envios confirmados
        //ON_TRANSIT- Si sólo se desea obtener la informacion de los envios en transito
        //RETURNED. Si sólo se desea obtener la informacion de los envios devueltos
        public string filterType { get; set; }

        public FilterTypeEstafeta(bool filterInformation, string filterType)
        {
            this.filterInformation = filterInformation;
            this.filterType = filterType;
        }
    }
}
