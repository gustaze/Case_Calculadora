using System;
namespace Calculadora
{
    public class Operacoes
    {
        // Fiz a alteração da variável "int" para variável "long", para suportar um número maior que 2147483647
        public long valorA {get;set;}
        public char operador { get; set; }
        public long valorB { get; set; }
        public long resultado { get; set; }

    }
}
