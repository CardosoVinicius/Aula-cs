Main;

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

            double media1, soma1;

            media1 = (7.255 + 1.696 + 4.986 + 5.662);
            soma1 = media1 / 4;

            Console.Write("Media Salarial= \r\n " + soma1);
            Console.Write(" \r\nOs funcionarios Alessando, Vinicius e Lucas recebem um salário acima da média ");



            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();
            Funcionario p3 = new Funcionario();
            Funcionario p4 = new Funcionario();

            p1.setNome("\r\nAlessandro");
            p2.setNome("Vitor");
            p3.setNome("Vinicius");
            p4.setNome("Lucas");

            p1.setMatricula(096421);
            p2.setMatricula(753294);
            p3.setMatricula(985303);
            p4.setMatricula(644521);

            p1.setSalario(7.255);
            p2.setSalario(1.696);
            p3.setSalario(4.986);
            p4.setSalario(5.662);

            Console.WriteLine(p1.getNome() + "A matrícula é: " + p1.getMatricula() + "  O salário é: " + p1.getSalario());
            Console.WriteLine(p2.getNome() + "A matrícula é: " + p2.getMatricula() + "  O salário é: " + p2.getSalario());
            Console.WriteLine(p3.getNome() + "A matrícula é: " + p3.getMatricula() + "  O salário é: " + p3.getSalario());
            Console.WriteLine(p4.getNome() + "A matrícula é: " + p4.getMatricula() + "  O salário é: " + p4.getSalario());

            Console.ReadKey();

            

          
        }
       
Main;


    }
}


Classe Funcionário: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private double salario; 
        


        public Funcionario(string nome, int matricula, float salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salario = salario;
        }

        public Funcionario()
        {
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return (this.nome);
        }


        //get e set matricula
        public void setMatricula(int matricula) { this.matricula = matricula; }
        public int getMatricula() { return this.matricula; }

        // get e set salario
        public void setSalario(double salario) { this.salario = salario; }
        public double getSalario() { return this.salario; }


       

    }
}

