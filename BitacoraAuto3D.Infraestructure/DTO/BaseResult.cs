using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BitacoraAuto3D.Infraestructure.DTO
{
    public class BaseResult
    {
        public bool Saved { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
        public bool Error { get; set; }
        public HttpStatusCode StatusCode {get;set;}
    }
}