using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Core.ConexionDB;

namespace PagoAgilFrba
{
    class Estadisticas
    {
        public DataTable consultar_estadisticas(int anio, int trimestre, int reporteId)
        {
            string storeprocedure = GetStoreProcudere(reporteId);

            if (storeprocedure != string.Empty)
            {
                try
                {
                    return ConexionDB.SeleccionRegistrosSPReportes(anio, trimestre, storeprocedure);  
                }
                catch (SqlException)
                {
                    throw;
                }
            }

            return new DataTable();
        }

        private string GetStoreProcudere(object reporteId)
        {
            string storeprocedure = string.Empty;

            switch (reporteId)
            {
                case 1:
                    storeprocedure = "SQL_86.ClientesConMasPagos";
                    break;
                case 2:
                    storeprocedure = "SQL_86.EmpresasConMayorMontoRendido";
                    break;
                case 3:
                    storeprocedure = "SQL_86.ClientesConMasPagos";
                    break;
                case 4:
                    storeprocedure = "SQL_86.ClientesConMayorPorcentajeFacturasPagadas";
                    break;
                default:
                    break;
            }

            return storeprocedure;
        }
    }
}
