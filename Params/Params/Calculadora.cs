using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculadora
    {
        public int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        //public int Triple(ref int x )
        //{
        //    return x *= 3;
        //}

        public int Triple(int origin, out int result)
        {
            return result = origin * 3;
        }
    }
}
