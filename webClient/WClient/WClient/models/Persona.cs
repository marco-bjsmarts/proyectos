using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WClient.models
{
    public class Persona
    {
        public int Id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }
    }
}