using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta.Response
{

        public class RespuestaEstafeta
        {
            [JsonProperty("executeQueryResponse")]
            public ExecuteQueryResponse ExecuteQueryResponse { get; set; }
        }

        public class ExecuteQueryResponse
        {
            [JsonProperty("executeQueryResult")]
            public ExecuteQueryResult ExecuteQueryResult { get; set; }
        }

        public class ExecuteQueryResult
        {
            [JsonProperty("errorCodeDescriptionSPA")]
            public string ErrorCodeDescriptionSPA { get; set; }

            [JsonProperty("errorCode")]
            public string ErrorCode { get; set; }

            [JsonProperty("errorCodeDescriptionENG")]
            public string ErrorCodeDescriptionENG { get; set; }

            [JsonProperty("trackingData")]
            public TrackingData TrackingData { get; set; }
        }

        public class TrackingData
        {
            [JsonProperty("trackingData")]
            public TrackingDataDetails TrackingDataDetails { get; set; }
        }

        public class TrackingDataDetails
        {
            [JsonProperty("deliveryData")]
            public DeliveryData DeliveryData { get; set; }

            [JsonProperty("multipleServiceData")]
            public MultipleServiceData MultipleServiceData { get; set; }

            [JsonProperty("additionalInformation")]
            public string AdditionalInformation { get; set; }

            [JsonProperty("internationalData")]
            public InternationalData InternationalData { get; set; }

            [JsonProperty("signature")]
            public Signature Signature { get; set; }

            [JsonProperty("customerInfo")]
            public CustomerInfo CustomerInfo { get; set; }

            [JsonProperty("shortWaybillId")]
            public string ShortWaybillId { get; set; }

            [JsonProperty("statusSPA")]
            public string StatusSPA { get; set; }

            [JsonProperty("history")]
            public History History { get; set; }
        }

        public class DeliveryData
        {
            [JsonProperty("destinationAcronym")]
            public string DestinationAcronym { get; set; }

            [JsonProperty("zipCode")]
            public string ZipCode { get; set; }

            [JsonProperty("deliveryDateTime")]
            public string DeliveryDateTime { get; set; }

            [JsonProperty("receiverName")]
            public string ReceiverName { get; set; }

            [JsonProperty("destinationName")]
            public string DestinationName { get; set; }
        }

        public class MultipleServiceData
        {
            // Propiedades de acuerdo a la estructura de datos
        }

        public class InternationalData
        {
            // Propiedades de acuerdo a la estructura de datos
        }

        public class Signature
        {
            // Propiedades de acuerdo a la estructura de datos
        }

        public class CustomerInfo
        {
            // Propiedades de acuerdo a la estructura de datos
        }

        public class History
        {
            [JsonProperty("History")]
            public List<HistoryEntry> Entries { get; set; }
        }

        public class HistoryEntry
        {
            [JsonProperty("exceptionCodeDetails")]
            public string ExceptionCodeDetails { get; set; }

            [JsonProperty("eventDateTime")]
            public string EventDateTime { get; set; }

            [JsonProperty("eventId")]
            public string EventId { get; set; }

            [JsonProperty("eventPlaceName")]
            public string EventPlaceName { get; set; }

            [JsonProperty("eventDescriptionSPA")]
            public string EventDescriptionSPA { get; set; }

            [JsonProperty("exceptionCodeDescriptionSPA")]
            public string ExceptionCodeDescriptionSPA { get; set; }

            [JsonProperty("eventDescriptionENG")]
            public string EventDescriptionENG { get; set; }

            [JsonProperty("eventPlaceAcronym")]
            public string EventPlaceAcronym { get; set; }

            [JsonProperty("exceptionCode")]
            public string ExceptionCode { get; set; }

            [JsonProperty("exceptionCodeDescriptionENG")]
            public string ExceptionCodeDescriptionENG { get; set; }
        }
    }

