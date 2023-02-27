using ConsumindoApiViaCep.Entities;

namespace ConsumindoApiViaCep.View
{
    internal class EnderecoView
    {
        public static void TelaInicial()
        {
            Console.WriteLine(" ===== Bem vindo ao ViaCEP ===== ");
            Console.Write(" Informe o CEP: ");
        }

        public static void TelaEndereco(Endereco enderecoLocalizado)
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

        public static void TelaCPFInvalido()
        {
            Console.WriteLine("CEP inválido... digite alguma tecla para tentar novamente");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TelaCPFNaoLocalizado()
        {
            Console.WriteLine("CEP não encontrado... digite alguma tecla para tentar novamente");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
