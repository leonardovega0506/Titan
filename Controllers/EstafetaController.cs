using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Titan.Models.Estafeta;
using Newtonsoft.Json;
using Titan.Models.Estafeta.Request;
using RestSharp;
using Titan.Models.Estafeta.Response;
using System.Net.Http;
using Titan.Services;

namespace Titan.Controllers
{
    [ApiController]
    public class EstafetaController : Controller
    {

        TokenGenerator token = new TokenGenerator();
        

        [HttpPost]
        [Route("ananda/jupiter/titan/estaftea/trackingByNumber")]
        public IActionResult findByNumeroGuia(string numeroGuia)
        {
            Task<string> tarea = token.GenerateTokenAsync();
            List<string> listaGuia = new List<string>();
            listaGuia.Add(numeroGuia);
            TrackingEstafeta tracking = new TrackingEstafeta("55", "WSCTrakingUser", "dh8>>S_PBj(a+MtQ",
                new SerachTypeEstafeta("L",
                new WayBillsListEstafeta("G", new Waybills(listaGuia)),
                new WaybillRangeEstafeta(numeroGuia, numeroGuia)),
                new SearchConfigurationEstafeta(true,true,true,true,true,true,true,
                new HistoryConfigurationEstafeta(true,"ALL"),
                new FilterTypeEstafeta(false,"")));
            var body = JsonConvert.SerializeObject(tracking);
            var client = new RestClient("https://csrestqa.estafeta.com/v3/CustShipmentTracking/ExecuteQuery");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("apiKey", "l78a868fb4191544939e722f38db1c821e");
            request.AddHeader("Authorization", "Bearer "+tarea.Result);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.Content != null)
            {
                RespuestaEstafeta respuesta = JsonConvert.DeserializeObject<RespuestaEstafeta>(response.Content);
                return StatusCode(StatusCodes.Status200OK, respuesta);
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound, "No hay registros");
            }
        }


    }

}
