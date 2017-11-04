using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PagoAgilFrba
{
    public class GD2C2017 : DataContext
    {
        public Table<Cliente> Clientes;
        public GD2C2017(string connection) : base(connection) { }
    }
}
