using ConsumindoApiViaCep.Entities;
using Newtonsoft.Json;

namespace ConsumindoApiViaCep.Services
{
    internal class EnderecoService
    {
        public async Task<Endereco> ConsultaEndereco(string cep)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json");
            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<Endereco>(jsonString);

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                return new Endereco
                {
                    erro = true
                };

            }
        }
    }
}
