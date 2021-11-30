using System;

namespace Patrones_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.GetInstancia();
            c.Conectar();
            c.Desconectar();

            Conexion c2 = Conexion.GetInstancia();
            c2.Conectar();
            c2.Desconectar();
        }
    }
}
