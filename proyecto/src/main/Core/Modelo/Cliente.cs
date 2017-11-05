using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Core.ConexionDB;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace PagoAgilFrba
{
    [Table(Name = "SQL_86.clientes")]
    public class Cliente
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
        [Column] public string Dni { get; set; }
        [Column] public string Apellido { get; set; }
        [Column] public string Nombre { get; set; }
        [Column(Name="fecha_nacimiento")] public DateTime FechaNacimiento { get; set; }
        [Column] public string Mail { get; set; }
        [Column] public string Direccion { get; set; }
        [Column] public string CP { get; set; }
        [Column] public string Piso { get; set; }
        [Column] public string Depto { get; set; }
        [Column] public string Telefono { get; set; }
        [Column] public string Localidad { get; set; }
        [Column] public char Estado { get; set; }

        public Cliente FindOneByID(int id)
        {

            GD2C2017 cDB = GD2C2017.Instancia;
            var cliente = (from registros in cDB.Clientes
                           where registros.Id == id
                           select registros).FirstOrDefault();
            return cliente;
        }

        public void Save()
        {
            if(Id == 0)
            {
                
                GD2C2017.Instancia.Clientes.InsertOnSubmit(this);
                GD2C2017.Instancia.SubmitChanges();
            } else {
                GD2C2017.Instancia.SubmitChanges();
            }
              
        }

    }

}
