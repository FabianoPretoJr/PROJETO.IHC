﻿using PROJETO.IHC.Domain.Enum;

namespace PROJETO.IHC.Domain.DTOs.Proposta
{
    public class PropostaInsertDTO
    {
        public string NomeProposta { get; set; }

        public string DescricaoProposta { get; set; }

        public string DtInicio { get; set; }

        public string DtFim { get; set; }

        public decimal ValorProsposta { get; set; }

        public EStatusProposta StatusProposta { get; set; }

        public int IdColaborador { get; set; }

        public int IdProjeto { get; set; }
    }
}
