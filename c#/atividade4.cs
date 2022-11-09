class Aluno
    {
 
        private String nome;
        private int matricula;
        private String email;

        public String Nome {get => nome; set => nome = value;}
        

        // get e set nome
       public int Matricula { get => matricula; set => matricula = value; }

        // get e set matricula
        

        // get e set email
        public String Email { get => email; set => email = value; }

        public void imprimir()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
        }


    }
}

class Program
    {
                static void Main(string[] args)
                {
                    Aluno a1 = new Aluno();
                    a1.Nome = "Zé";
                    a1.Matricula = 234;
                    a1.Email = "ze@gmail.com";

                    Aluno a2 = new Aluno();
                    a2.Nome = "Ana";
                    a2.Matricula = 789;
                    a2.Email = "ana@xy.com";

                    Aluno a3 = new Aluno();
                    a3.Nome = "Paulo";
                    a3.Matricula = 989;
                    a3.Email = "paulo@ig.com";

                    a1.imprimir();
                    a2.imprimir();
                    a3.imprimir();

                    Console.ReadKey();
                }
                            }
    }
class Aluno
    {
 
        private String nome;
        private int matricula;
        private String email;

        public String Nome {get => nome; set => nome = value;}
        

        // get e set nome
       public int Matricula { get => matricula; set => matricula = value; }

        // get e set matricula
        

        // get e set email
        public String Email { get => email; set => email = value; }

        public void imprimir()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
        }


    }
}

class Program
    {
                static void Main(string[] args)
                {
                    Aluno a1 = new Aluno();
                    a1.Nome = "Zé";
                    a1.Matricula = 234;
                    a1.Email = "ze@gmail.com";

                    Aluno a2 = new Aluno();
                    a2.Nome = "Ana";
                    a2.Matricula = 789;
                    a2.Email = "ana@xy.com";

                    Aluno a3 = new Aluno();
                    a3.Nome = "Paulo";
                    a3.Matricula = 989;
                    a3.Email = "paulo@ig.com";

                    a1.imprimir();
                    a2.imprimir();
                    a3.imprimir();

                    Console.ReadKey();
                }
                            }
    }
