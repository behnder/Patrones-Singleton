using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Singleton
{
    class Conexion
    {

        private static Conexion instancia;
        private Conexion()
        {

        }
        public static Conexion GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Me conecté a la BD");
        }

        public void Desconectar()
        {
            Console.WriteLine("Me desconecté de la BD");
        }

    }
}
