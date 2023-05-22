using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.Models.Estafeta.Request
{
    public class Waybills
    {
        public List<string> @string { get; set; }

        public Waybills(List<string> String)
        {
            this.@string = String;
        }
    }
}
