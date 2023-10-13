namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
             /*<summary>
             entrada cadastro de veiculos pela placa
            </summary>*/
        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
           Console.WriteLine("<<<<MENU CADASTRO VEICULO>>>>");
           Console.WriteLine("Digite a placa do veículo para estacionar:");
           string cadastroPlacaVeiculo = Console.ReadLine();
           veiculos.Add(cadastroPlacaVeiculo);
           Console.WriteLine($"Veículo de placa {cadastroPlacaVeiculo} cadastrado com sucesso!");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("<<<<<MENU REMOVER VEICULO>>>>");
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placaVeiculo = Console.ReadLine();            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                Console.WriteLine("<<<<<Comanda de controle Saida>>>>");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Int32.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 
                veiculos.Remove(placaVeiculo);    
                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("<<<<<LISTA DE VEICULOS>>>>>");
                Console.WriteLine("Os veículos estacionados são:");
                int lista = 0;
                while (lista < veiculos.Count)
                {
                    Console.WriteLine($"{lista + 1}º Veículo  de placa: {veiculos[lista]}");
                    lista++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
