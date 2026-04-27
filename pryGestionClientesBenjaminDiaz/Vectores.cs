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
            internal string NombreyApellido;
        }

        //vector 
        static public RegCliente[] Clientes = new RegCliente[10];

        //Indice
        static public Int32 IND = 0;

        static public void precarga()
        {
            IND = 0;
            Clientes[Vectores.IND].Codigo = 10;
            Clientes[Vectores.IND].Usuario = "Benjamin Diaz";
            Clientes[Vectores.IND].Deuda = 1000;
            Clientes[Vectores.IND].Limite = 10000;
            Vectores.IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
            Clientes[Vectores.IND].Codigo = 20;
            Clientes[Vectores.IND].Usuario = "Maria Gomez";
            Clientes[Vectores.IND].Deuda = 0;
            Clientes[Vectores.IND].Limite = 20000;
            Vectores.IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
            Clientes[Vectores.IND].Codigo = 30;
            Clientes[Vectores.IND].Usuario = "Juan Perez";
            Clientes[Vectores.IND].Deuda = 3000;
            Clientes[Vectores.IND].Limite = 30000;
            IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
        }
        static public void OrdenarCodigoAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarCodigoDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }

        }
        static public void OrdenarUsuarioAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarUsuarioDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }

        }
        static public void OrdenarLimiteAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarLimiteDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Limite < Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarDeudaAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarDeudaDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCliente Aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda < Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }

        }

    }
}