using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolineas.Datos;

namespace Aerolineas.Negocios
{
    public class Aerolinea
    {
        //public string ConsultarRutas(int idAerolinea)
        //{
        //    SQLServer objetoSQL = new SQLServer();
        //    string NombreAerolinea = objetoSQL.ObtenerDatos(idAerolinea;)

        //    if (NombreAerolinea == "TAME")
        //        return "La Aerolinea " + NombreAerolinea + " tiene 5 rutas: QUITO, CUENCA, GALÁPAGOS, COCA, LOJA";
        //    if (NombreAerolinea == "AEROGAL")
        //        return "La Aerolinea " + NombreAerolinea + " tiene 3 rutas: QUITO, CUENCA, GALÁPAGOS";
        //    if (NombreAerolinea == "ICARO")
        //        return "La Aerolinea " + NombreAerolinea + " tiene 1 ruta: QUITO";
        //    else
        //        return "La Aerolinea " + NombreAerolinea + " tiene 1 ruta: QUITO";
        //}
        Datos.SQLServer objLista = new SQLServer();

        public int ContarAerolineas()
        {
            int NumeroAerolineas=0;
            NumeroAerolineas=objLista.ListaAerolinea().Count;
            return NumeroAerolineas;
        }        
    }
}
