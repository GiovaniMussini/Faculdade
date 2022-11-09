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

            Funcionario[] fun = new Funcionario[4];
                 
            fun[0]= new Funcionario();
            fun[0].nome = "Carlos";
            fun[0].matricula = 111;
            fun[0].salario = 11111;

            fun[1] = new Funcionario();
            fun[1].nome = "Pedro";
            fun[1].matricula = 222;
            fun[1].salario = 2222;

            fun[2] = new Funcionario();
            fun[2].nome = "Paulo";
            fun[2].matricula = 333;
            fun[2].salario = 3333;

            fun[3] = new Funcionario();
            fun[3].nome = "Anna";
            fun[3]. matricula = 4444;
            fun[3].salario = 444444;
    

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

            Funcionario[] fun = new Funcionario[4];
                 
            fun[0]= new Funcionario();
            fun[0].nome = "Carlos";
            fun[0].matricula = 111;
            fun[0].salario = 11111;

            fun[1] = new Funcionario();
            fun[1].nome = "Pedro";
            fun[1].matricula = 222;
            fun[1].salario = 2222;

            fun[2] = new Funcionario();
            fun[2].nome = "Paulo";
            fun[2].matricula = 333;
            fun[2].salario = 3333;

            fun[3] = new Funcionario();
            fun[3].nome = "Anna";
            fun[3]. matricula = 4444;
            fun[3].salario = 444444;
    

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
