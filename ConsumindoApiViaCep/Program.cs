using ConsumindoApiViaCep.Entities;
using ConsumindoApiViaCep.Services;
using ConsumindoApiViaCep.View;

inicio:

var telasInteracao = new EnderecoView();
var enderecoService = new EnderecoService();

telasInteracao.TelaInicial();
var cep = Console.ReadLine();


if (cep == null || cep.Length > 8 || cep.Contains(" "))
{
    Console.WriteLine("CEP inválido... digite alguma tecla para tentar novamente");
    Console.ReadKey();
    goto inicio;
}

Endereco enderecoLocalizado = await enderecoService.ConsultaEndereco(cep);

if (enderecoLocalizado.erro == true)
{
    Console.WriteLine("CEP não localizado");
}
else if (enderecoLocalizado.erro == false)
{
    telasInteracao.TelaEndereco(enderecoLocalizado);
}






