﻿using PROJETO.IHC.Domain.Enum;

namespace PROJETO.IHC.Domain.Entities
{
    internal class Colaborador : EntityBase
    {
        public Colaborador() { }

        public Colaborador(int id, string nome, DateTime dtNascimento, ESexo sexo, string documentoCPF, Contato contato, Endereco endereco) : base(id)
        {
            this.Nome = nome;
            this.DtNascimento = dtNascimento;
            this.Sexo = sexo;
            this.DocumentoCPF = documentoCPF;
            this.Contato = contato;
            Endereco = endereco;
        }

        public string Nome { get; set; }

        public DateTime DtNascimento { get; set; }

        public ESexo Sexo { get; set; }

        public string DocumentoCPF { get; set; }

        public Endereco Endereco { get; set; }

        public Contato Contato { get; set; }
    }
}
