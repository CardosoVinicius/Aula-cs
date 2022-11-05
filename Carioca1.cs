using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario[] f = new Funcionario[4];
                 
            f[0]= new Funcionario();
            f[0].nome = "Murilo";
            f[0].matricula = 123;
            f[0].salario = 1000;

            f[1] = new Funcionario();
            f[1].nome = "Gabriel";
            f[1].matricula = 321;
            f[1].salario = 1680;

            f[2] = new Funcionario();
            f[2].nome = "André";
            f[2].matricula = 12;
            f[2].salario = 4000;

            f[3] = new Funcionario();
            f[3].nome = "Fernando";
            f[3]. matricula = 1945;
            f[3].salario = 1000000;
    

            int somaMedia=0;

            for(int i = 0; i<4;i++)
            {
                somaMedia += f[i].salario;
            }
            float mediaFinal = somaMedia / 4;

            for (int i = 0; i< 4; i++)
            {
                if (f[i].salario > mediaFinal)
                {
                    f[i].imprimir();
                }
            }
            Console.ReadKey();
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Funcionario
    {
        public String nome { get; set; }
        public int matricula { get; set; }
        public int salario { get; set; }


        public void imprimir()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.salario);
        }
    }
}
