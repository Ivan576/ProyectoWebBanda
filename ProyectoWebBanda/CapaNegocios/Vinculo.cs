using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebBanda.CapaNegocios
{
    /*Objeto de viculos
     * Usado para las actividades de vinculos
     * */
    public class Vinculo
    {
        public int idVinculo{get;set};
        public string nombreVinculo{get;set;}
        public string imagen{get;set;}

        public Vinculo(string nombreVinculo, string  imagen){
            this.nombreVinculo=nombreVinculo;
            this.imagen=imagen;
        }

        public Vinculo(int idVinculo){
            this.idVinculo=idVinculo;
        }

    }
}