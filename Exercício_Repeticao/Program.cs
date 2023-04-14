using System;
using System.Runtime.InteropServices;

namespace Exercício_Repeticao 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício: Faça um programa que leia três valores (A, B, C) e mostre-os na ordem lida.
            // Em seguida, mostre-os em ordem crescente e decrescente.

            int[] numero = { 0, 0, 0 };
            int reserva = 0;

            Console.WriteLine("Programa para ler 3 números e mostrar na ordem que foram lidos, na ordem crescente e decrescente!\n\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um número: ");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Os números na ordem lida foram:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numero[i]);
            }
            Console.ReadKey();
            Console.Clear();

            // Laço de repetição para organizar os números em ordem crescente
            for (int i = 0; i < 2; i++)
            {
                if (numero[0] > numero[i])
                {
                    reserva = numero[0];
                    if (reserva > numero[2] || reserva > numero[1])
                    {
                        numero[0] = numero[1];
                        numero[1] = numero[2];
                        numero[2] = reserva;
                    }
                    
                }
                if (numero[1] > numero[2])
                {
                    reserva = numero[1];
                    numero[1] = numero[2];
                    numero[2] = reserva;
                }
            }
            Console.WriteLine("Os números na ordem crescente são:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n" + numero[i]);
            }
            Console.ReadKey();

            // Laço de repetição para organizar os números em ordem decrescente
            for (int i = 0; i < 2; i++)
            {
                if (numero[0] < numero[i])
                {
                    reserva = numero[0];
                    if (reserva < numero[2] || reserva < numero[1])
                    {
                        numero[0] = numero[1];
                        numero[1] = numero[2];
                        numero[2] = reserva;
                    }

                }
                if (numero[1] < numero[2])
                {
                    reserva = numero[1];
                    numero[1] = numero[2];
                    numero[2] = reserva;
                }
            }

            Console.Clear();
            Console.WriteLine("Os números na ordem decrescente são:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n" + numero[i]);
            }
        }
    }
}