﻿using System;
using tabuleiro;
using tabuleiro.enums;
using tabuleiro.exceptions;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
            Console.ReadLine();
        }
    }
}
