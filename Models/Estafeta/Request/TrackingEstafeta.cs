using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta
{
    public class TrackingEstafeta
    {
        //Identificador de sucriptor al web service
        public string suscriberId { get; set; }

        //Nombre del usuario
        public string login { get; set; }

        //Contraseña
        public string password { get; set; }

        //Objeto Base
        public SerachTypeEstafeta searchType { get; set; }

        //Objeto Base
        public SearchConfigurationEstafeta searchConfiguration { get; set; }

        public TrackingEstafeta(string suscriberId, string login, string password, SerachTypeEstafeta searchType, SearchConfigurationEstafeta searchConfiguration)
        {
            this.suscriberId = suscriberId;
            this.login = login;
            this.password = password;
            this.searchType = searchType;
            this.searchConfiguration = searchConfiguration;
        }
    }
}
