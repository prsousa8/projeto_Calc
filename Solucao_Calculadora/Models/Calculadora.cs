using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solucao_Calculadora.Models
{
    public class Calculadora
    {
        public int Somar(int num1, int num2){return num1+num2;}
        public int Subtrair(int num1, int num2){return num1-num2;}
        public int Multiplicar(int num1, int num2){return num1*num2;}
        public double Dividir(double num1, double num2){return num1 / num2;}
        public double RaizQuadrada(double num1){return Math.Sqrt(num1);}
    }
}