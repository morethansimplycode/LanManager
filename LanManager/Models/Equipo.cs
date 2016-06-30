using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanManager.Models
{
    public class Equipo
    {
        public String Name { get; set; }
        public String IpAddress { get; set; }
        public String MacAddress { get; set; }

        public Equipo()
        {
            Name = String.Empty;
            IpAddress = String.Empty;
            MacAddress = String.Empty;
        }
    }
}