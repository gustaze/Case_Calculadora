using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();

            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            //Criei a pilha (Stack) solicitado para guardar os resultados 
            Stack<long> stack = new Stack<long>();

            
            while (filaOperacoes.Count > 0) //Alterei de ">=" para somente ">" pois a condição seria sempre verdadeira o que me impedia de imprimir a pilha ao final do código
            {
                Operacoes operacao = filaOperacoes.Dequeue(); // Alterei de "peek" para "dequeue" assim saiu do loop infinito de processar sempre o primeiro item da fila
                calculadora.calcular(operacao);
                stack.Push(operacao.resultado); // Aqui inclui essa variável para fazer a inclusão dos resultados na pilha
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

            }

            //E por fim fiz a impressão da pilha.
            Console.WriteLine(); // Coloquei esse console para pular uma linha e ficar melhor a visualização no console.
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
