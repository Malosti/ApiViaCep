﻿using ConsumindoApiViaCep.Entities;
using ConsumindoApiViaCep.Services;
using ConsumindoApiViaCep.View;
using System.Text.RegularExpressions;

inicio:

var telasInteracao = new EnderecoView();
var enderecoService = new EnderecoService();

telasInteracao.TelaInicial();
var cep = Console.ReadLine();
Regex cepValido = new Regex("^[0-9]{8}$", RegexOptions.None);


if (!cepValido.IsMatch(cep))
{
    telasInteracao.TelaCPFInvalido();
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






