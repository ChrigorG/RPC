using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Projeto_RPC_Calculadora_Cliente {
    internal class ClientRPC {
        public ClientRPC(string urlServer) {
            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            var client = new MyService.MyServiceClient(channel);
        } 
    }
}
