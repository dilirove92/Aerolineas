using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolineas.Datos
{
    public class SQLServer
    {
        public string CadenaConexion { get; set; }

        ////public string ObtenerDatos(int idAerolinea)
        ////{
        ////    if (idAerolinea == 1)
        ////        return "TAME";
        ////    if (idAerolinea == 2)
        ////        return "AEROGAL";
        ////    if (idAerolinea == 3)
        ////        return "ICARO";
        ////    else
        ////        return "LAN ECUADOR";
        ////}

        public List<string> ListaAerolinea()
        {
            List<string> ListaAerolinea = new List<string>();
            ListaAerolinea.Add("Tame");
            ListaAerolinea.Add("Aerogal");
            ListaAerolinea.Add("Icaro");
            ListaAerolinea.Add("Lan Ecuador");
            ListaAerolinea.Add("Air France");
            return ListaAerolinea;
        }

    }
}
