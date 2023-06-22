using ConsumindoApiViaCep.Entities;
using ConsumindoApiViaCep.Services;
using ConsumindoApiViaCep.View;
using System.Text.RegularExpressions;

namespace ConsumindoApiViaCep.Controller
{
    internal class EnderecoController
    {
        public async Task BuscadorCepAsync()
        {
        inicio:

            var enderecoService = new EnderecoService();
            var opcao = "S";

            while (opcao != "N") { 
            EnderecoView.TelaInicial();
            var cep = Console.ReadLine();
            Regex cepValido = new Regex("^[0-9]{8}$", RegexOptions.None);


            if (cep != null && !cepValido.IsMatch(cep))
            {
                EnderecoView.TelaCPFInvalido();
                goto inicio;
            }

            Endereco enderecoLocalizado = await enderecoService.ConsultaEndereco(cep);

            if (enderecoLocalizado.erro == true)
            {
                EnderecoView.TelaCPFNaoLocalizado();
                goto inicio;
            }
            else if (enderecoLocalizado.erro == false)
            {
                EnderecoView.TelaEndereco(enderecoLocalizado);
            }

                Console.WriteLine();
                Console.Write("Deseja pesquisar novamente? S/N ");
                opcao = Console.ReadLine().ToUpper();
                Console.Clear();
            }
        }
    }
}
