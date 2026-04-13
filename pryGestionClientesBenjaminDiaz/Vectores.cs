using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGestionClientesBenjaminDiaz
{
    internal class Vectores
    {
        //Registro
        public struct RegCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }
        
        //vector 
        static public RegCliente[] Clientes = new RegCliente[10];
        
        //Indice
        static public Int32 IND = 0;
    }
}
