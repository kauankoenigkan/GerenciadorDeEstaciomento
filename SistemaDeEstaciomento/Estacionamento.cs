using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeEstaciomento
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;                  
        private List <string> Veiculos = new List <string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("Digite sua placa para estacionar o carro..: ");
            string placaCadastrar = Console.ReadLine().ToUpper();

            if (Veiculos.Contains(placaCadastrar))
            {
                Console.WriteLine("O veículo já está estacionado aqui!");
            }
            else
            {
                Veiculos.Add(placaCadastrar);
                Console.WriteLine($"Veículo com a placa: '{placaCadastrar}' foi cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo() // Remover veículo e mostrar o valor da permanência no estacionamento.
        {
            Console.WriteLine("Digite a placa do veículo para remove-lo..: ");
            string placaRemocao = Console.ReadLine().ToUpper();

            if (Veiculos.Contains(placaRemocao))
            {
                int horas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Digite as horas que o veículo ficou estacionado..: ");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + (precoHora * horas);
                Veiculos.Remove(placaRemocao);

                Console.WriteLine();
                Console.WriteLine($"O veículo com a placa: '{placaRemocao}' foi removido e o preço total ficou: R$ {valorTotal} .");
            }
            else
            {
                Console.WriteLine("Placa de veículo não encontrada nesse estacionamento!");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("O estacionamento está vazio!");
            }
            else
            {
                for (int i = 0; i < Veiculos.Count; i++)
                {
                    Console.WriteLine($" Placa de Veículo {i + 1}: {Veiculos[i]}");
                }
            }
        }
    }
}