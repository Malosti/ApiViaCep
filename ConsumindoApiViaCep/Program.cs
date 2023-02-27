using ConsumindoApiViaCep.Entities;
using ConsumindoApiViaCep.Services;
using ConsumindoApiViaCep.View;
using System.Text.RegularExpressions;

inicio:

var enderecoService = new EnderecoService();

EnderecoView.TelaInicial();
var cep = Console.ReadLine();
Regex cepValido = new Regex("^[0-9]{8}$", RegexOptions.None);


if (!cepValido.IsMatch(cep))
{
    EnderecoView.TelaCPFInvalido();
    goto inicio;
}

Endereco enderecoLocalizado = await enderecoService.ConsultaEndereco(cep);

if (enderecoLocalizado.erro == true)
{
    Console.WriteLine("CEP não localizado");
}
else if (enderecoLocalizado.erro == false)
{
    EnderecoView.TelaEndereco(enderecoLocalizado);
}






