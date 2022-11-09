{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private string cpf;

        public Funcionario (string nome, int matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public string getNome (string nome)
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getMatricula (int matricula)
        {
            return this.matricula;
        }
        public void setMatricula (int matricula)
        {
            this.matricula = matricula;
        }

        public string getCpf (string cpf)
        {
            return this.cpf = cpf;
        }
        public void setCpf (string cpf)
        {
            this.cpf = cpf;
        }

        public void imprimeFuncionario()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.cpf);
        }
    }
}
—------------------------------------------------------------------------------------------------------------------------

{
    class Departamento
    {
        private string nome_;
        ArrayList listaFuncionario = new ArrayList();

        public Departamento(string nome) {
            nome_ = nome;

        }
        public string Nome

        {
            get
            {
                return nome_;
            }

            set
            {
                nome_ = value;
            }
        }
        public void AdicionaFuncionario(Funcionario f)
        {
           listaFuncionario.Add(f);
         }

        public void ImprimeDepartamento()
        {
            Console.WriteLine(".........Funcionarios do Departamento........" + nome_);
            foreach (Funcionario f in listaFuncionario)
            {
                Console.WriteLine(f.Nome + "\n");
            }
           
        }
     }
} 
—------------------------------------------------------------------------------------------------------------------------







{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario("maria", 123, "6765657");
            Funcionario F2 = new Funcionario("pedro", 789, "2213438");
            Departamento vendas = new Departamento("Vendas");

           
            vendas.AdicionaFuncionario(F1);
            vendas.AdicionaFuncionario(F2);
            vendas.ImprimeDepartamento();


        }
    }
}
