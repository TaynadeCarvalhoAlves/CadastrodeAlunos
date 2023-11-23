using CadastrodeAlunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
       Aluno aluno1 = new Aluno("Laura", 15, 8.5);

        Console.WriteLine($"Nome: {aluno1.Nome}, Idade: {aluno1.Idade}, Nota: {aluno1.Nota}");
    }
}