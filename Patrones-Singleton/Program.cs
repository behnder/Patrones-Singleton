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


            if (c is Conexion)
            {
                Console.WriteLine("es conexion");
            }
            Console.ReadKey();


        }
    }
}
