using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetorFuncionario
{
    class Funcionario
    {
        private string nome, matricula, email;
        private double salario;
        public Funcionario(string nome, string matricula, string email, double salario)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.email = email;
            this.salario = salario;
        }
        public double GetSalario()
        {
            return salario;
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {matricula}\nSalário: R${salario}";
        }
    }
    class Setor
    {
        private string nome, sigla;
        private Funcionario[] funcionarios = new Funcionario[1];
        int k = 0;
        public Setor(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        public void Inserir(Funcionario f)
        {
            if (funcionarios.Length == k)
            {
                Array.Resize(ref funcionarios, funcionarios.Length + 1);
            }
            funcionarios[k] = f;
            k++;
        }
        public Funcionario[] Listar()
        {
            Funcionario[] lista = new Funcionario[k];
            Array.Copy(funcionarios, lista, k);
            return lista;
        }
        public double MediaSalario()
        {
            double total = 0;
            foreach (Funcionario f in funcionarios)
            {
                total += f.GetSalario();
            }
       
            return total / k;
        }
        public override string ToString()
        {
            return $"{sigla} - {nome}";
        }
    }
}
