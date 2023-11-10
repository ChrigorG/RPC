using System;
using System.IO;
using Nancy;
using Nancy.Owin;

namespace Projeto_RPC_Calculadora_Servidor
{
    internal class ServerRPC
    {
        public ServerRPC()
        {
            try
            {
                var uri = "http://localhost:8185";
                using (WebApp.Start<Startup>(uri))
                {
                    Console.WriteLine($"Servidor iniciado em {uri}. Pressione Enter para parar.");
                    Console.ReadLine();
                }

            } catch (Exception ex)
            {

            }
        }
    }
}
