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
            Console.ReadKey();
        }
    }
}
