using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Aluno
    {
        private int matricula;
        private string nome, email;
        private int numChamada;

        public int Matricula
        {
            set { this.matricula = value; }
            get { return this.matricula; }
        }

        public string Nome
        {
            set { this.nome = value.ToUpper(); }
            get { return this.nome; }
        }

        public string Email
        {
            set { this.email = value.ToLower(); }
            get { return this.email; }
        }

        public int NumChamada
        {
            set { this.numChamada = value; }
            get { return this.numChamada; }
        }
    }
}
