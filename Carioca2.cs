using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {

        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Vinicius";
            Console.WriteLine(p1.Nome);

            Aluno p2 = new Aluno();
            p2.Matricula = (584793);
            Console.WriteLine(p2.Matricula);

            Aluno p3 = new Aluno();
            p3.Email = "viniiccius11@gmail.com";
            Console.WriteLine(p3.Email);
        }
    }
}


++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aluno
    {
        private string nome;
        public string Nome { get; set; }

        private int matricula;
        public int Matricula { get; set; }

        private string email;
        public string Email { get; set; }

    }
}

