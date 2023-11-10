using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPC_Calculadora_Servidor {
    internal class Calculadora {

        private static double Pi = 3.14159;

        public static double AreaDoQuadrado(double Lado) {
            return Math.Pow(Lado, 2);
        }

        public static double AreaDoTrianguloRetangulo(double Base, double Altura) {
            return (Base * Altura) / 2.0;
        }
        public static double AreaDaCircunferencia(double Raio) {
            return Pi * Math.Pow(Raio, 2);
        }

        public static double AreaDaEsfera(double Raio) {
            return 4.0 * AreaDaCircunferencia(Raio);
        }

        public static double VolumeDaEsfera(double Raio) {
            return (4.0/3.0) * Pi * Math.Pow(Raio, 3);
        }

        public static double AreaDoCilindro(double Raio, double Altura) {
            return (2.0 * Pi * Raio * Altura) + AreaDaCircunferencia(Raio);
        }

        public static double VolumeDoCilindro(double Raio, double Altura) {
            return Pi * Math.Pow(Raio, 2) * Altura;
        }

        public static double AreaSuperficieDoCubo(double Lado) {
            return 6.0 * Math.Pow(Lado, 2);
        }

        public static double VolumeDoCubo(double Lado) {
            return Math.Pow(Lado, 3);
        }
    }
}
