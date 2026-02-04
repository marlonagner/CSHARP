using System;
using Models;


class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Id = 1;
        p1.Nome = "Agner";
        p1.Endereco = "Av Ind";


        Pessoa p2 = new Pessoa()
        p2.Id = 2;
        p2.Nome = "Maria";
        p2.Endereco = "Rua B";

        Pessoa p3 = new Pessoa()
        p3.Id = 3;
        p3.Nome = "João";
        p3.Endereco = "Rua C";
        


    }
}