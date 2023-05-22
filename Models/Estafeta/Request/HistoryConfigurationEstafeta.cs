using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class HistoryConfigurationEstafeta
    {
        //ALL-Todos, ONLY_EXCPETION- Sólo los mobimientos que tengan exception, LAST_EVENT-Sólo el ultimo movimiento para envios que aun no esten confirmados
        public string historyType { get; set; }

        //Indica si se desea o no incluir algunos o todos los movimientos de la historia
        public bool includeHistory { get; set; }

        public HistoryConfigurationEstafeta(bool includeHistory, string historyType)
        {
            this.includeHistory = includeHistory;
            this.historyType = historyType;
        }
    }
}
