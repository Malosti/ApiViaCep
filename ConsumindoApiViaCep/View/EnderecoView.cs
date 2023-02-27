using ConsumindoApiViaCep.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiViaCep.View
{
    internal class EnderecoView
    {
        public void TelaInicial()
        {
            Console.WriteLine(" ===== Bem vindo ao ViaCEP ===== ");
            Console.Write(" Informe o CEP: ");
        }

        public void TelaEndereco(Endereco enderecoLocalizado)
        {
            Console.Clear();
            Console.WriteLine(" ===== Seu endereço ===== ");
            Console.WriteLine($" CEP: {enderecoLocalizado.cep}");
            Console.WriteLine($" Logradouro: {enderecoLocalizado.logradouro}");
            Console.WriteLine($" Bairro: {enderecoLocalizado.bairro}");
            Console.WriteLine($" Cidade: {enderecoLocalizado.localidade}");
            Console.WriteLine($" UF: {enderecoLocalizado.uf}");
            Console.WriteLine($" Código IBGE: {enderecoLocalizado.ibge}");
        }

        public void TelaCPFInvalido()
        {
            Console.WriteLine("CEP inválido... digite alguma tecla para tentar novamente");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
