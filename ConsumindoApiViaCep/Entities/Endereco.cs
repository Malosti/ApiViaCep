﻿
namespace ConsumindoApiViaCep.Entities
{
    internal class Endereco
    {
        public string? cep { get; set; }
        public string? logradouro { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? localidade { get; set; }
        public string? uf { get; set; }
        public string? ibge { get; set; }
        public string? gia { get; set; }
        public int ddd { get; set; }
        public int siafi { get; set; }
        public bool erro { get; set; }

    }
}
