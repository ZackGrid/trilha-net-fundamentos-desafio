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

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string tempVeiculo = Console.ReadLine();
            veiculos.Add(tempVeiculo.ToUpper());
        }

        public void RemoverVeiculo()
        {   
            //verificar se há veiculos cadastrados primeiro
            if(veiculos.Count > 0)
            {   
                //Listar placas cadastradas para facilitar caso usuario não lembre na hora de remover
                Console.WriteLine("Veiculos cadastrados: ");
                for (int i = 0; i < veiculos.Count;i++){
                    Console.WriteLine(veiculos[i]);
                }
                Console.WriteLine("Digite a placa do veículo para remover:");

                // Pedir para o usuário digitar a placa e armazenar na variável placa
                string tempPlaca = Console.ReadLine();
                string placa = tempPlaca.ToUpper();

                // Verifica se o veículo existe, retorna valor total, e remove veiculo
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    int horas = 0;
                    horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = 0;
                    valorTotal = (horas * precoPorHora) + precoInicial;

                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui." + 
                    "Confira se digitou a placa corretamente.");
                }
            } else {
                Console.WriteLine("Não há veiculos cadastrados.");
            }
            
            
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int i = 0; i < veiculos.Count;i++){
                    Console.WriteLine(veiculos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
