using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class SearchConfigurationEstafeta
    {
        //Objeto de entrada donde se especifica filtrar la informacion segun el estatus de los envios
        public FilterTypeEstafeta filterType { get; set; }

        //Objeto de entrada donde se especifica si se desea obtener datos de historia con las diferentes opciones disponibles
        public HistoryConfigurationEstafeta historyConfiguration { get; set; }


        //Indica si se desea obtener en la respuesta el grupo de datos que contiene las dimensiones de envio
        public bool includeDimensions { get; set; } 

        //Indica si se desea obtener en la respyesta el grupo de datos de la informacion de guias de remplazo(En caso de aplicar)
        public bool includeWallbillReplaceData { get; set; }

        //Indica si se desea obetener en la respuesta el grupo de datos de guia de documento de retorno(En caso de aplicar)
        public bool includeReturnDocumentData { get; set; }

        //Indica si se desea obtener la rewspuesta el grupo de datos de servicio multiple(En caso de aplicar)
        public bool includeMultipleServiceData { get; set; }

        //Indica si se desea obtener el grupo de datos de informacion internacional(En caso de aplicar)
        public bool includeInternationalData { get; set; }

        //Indica si se desea obtener en la respuesta la firma de confirmacion del envio si este se encuentra almacenada para envio
        public bool includeSignature { get; set; }

        //Indica si se desea obtener el en la respuesta el grupo de datos de informacion del cliente que incluye la referencia
        public bool includeCustomerInfo { get; set; }


        public SearchConfigurationEstafeta(bool includeDimensions, bool includeWallbillReplaceData, bool includeReturnDocumentData, bool includeMultipleServiceData, bool includeInternationalData, bool includeSignature, bool includeCustomerInfo, HistoryConfigurationEstafeta historyConfiguration, FilterTypeEstafeta filterType)
        {
            this.includeDimensions = includeDimensions;
            this.includeWallbillReplaceData = includeWallbillReplaceData;
            this.includeReturnDocumentData = includeReturnDocumentData;
            this.includeMultipleServiceData = includeMultipleServiceData;
            this.includeInternationalData = includeInternationalData;
            this.includeSignature = includeSignature;
            this.includeCustomerInfo = includeCustomerInfo;
            this.historyConfiguration = historyConfiguration;
            this.filterType = filterType;
        }
    }
}
