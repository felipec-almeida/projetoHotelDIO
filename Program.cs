using System.Security.AccessControl;
using System;
using System.Globalization;
using Desafio_Hotel_DIO.Models;

Console.Clear();
Console.WriteLine("Seja Bem-Vindo Ao Hotel.");

List<Pessoa> hospedes = new List<Pessoa>();
Console.WriteLine("<------ Etapa 1/3 | Cadastrar Hóspedes ------>");
Console.Write("Digite a Quantidade de Pessoas: ");
int numeroPessoas = 0;
bool verificacao = int.TryParse(Console.ReadLine(), out numeroPessoas);
if (!verificacao)
{

    throw new Exception("Não foi obter a Resposta, tente novamente.");

}
for (int cont = 0; cont < numeroPessoas; cont++)
{

    Console.WriteLine($"<------ Pessoa {cont + 1} ------>");
    Console.Write("Digite o Nome da Pessoa: ");
    string? nomePessoa = Console.ReadLine();
    Console.Write("Digite o Sobrenome da Pessoa: ");
    string? sobrenomePessoa = Console.ReadLine();
    hospedes.Add(new Pessoa(nomePessoa, sobrenomePessoa));

}

Console.WriteLine("<------ Etapa 2/3 | Cadastrar Suíte ------>");
Console.Write("Digite o Tipo da Suíte: ");
string? tipoSuite = Console.ReadLine();
bool verificacaoSuite = false;
int capacidade = 0;
while (!verificacaoSuite)
{

    Console.Write("Digite a Capacidade de Pessoas: ");
    bool respostaCapacidade = int.TryParse(Console.ReadLine(), out capacidade);
    if (capacidade < hospedes.Count)
    {

        Console.WriteLine("A capacidade da Suíte não pode ser menor que o número de Hóspedes.");
        verificacaoSuite = false;

    }
    else
    {

        verificacaoSuite = true;

    }
}
Console.Write("Digite o valor da Diária: ");
int valorDiaria = 0;
bool verificacaoDiaria = int.TryParse(Console.ReadLine(), out valorDiaria);
if (!verificacaoDiaria)
{
    throw new Exception("Erro ao obter a Resposta, tente novamente.");
}

Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

Console.WriteLine("<------ 3/3 | Criar Reserva ------>");
Console.Write("Digite o número de dias de hospedagem: ");
int respostaDias = 0;
bool verificacaoDias = int.TryParse(Console.ReadLine(), out respostaDias);
if(!verificacaoDias) {

    throw new Exception("Erro ao obter a Reposta, tente novamente.");

}
Reserva reserva = new Reserva(respostaDias);
Console.WriteLine("Criando Reserva...");
reserva.CadastrarHospedes(hospedes);
reserva.CadastrarSuite(suite);
Console.WriteLine("Reserva Criada com Sucesso! Acessando o Menu da Reserva...");

bool menuReserva = true;
while (menuReserva == true)
{
    Console.WriteLine("<------ Menu ------>");
    Console.WriteLine("1- Obter Quantidade de Hóspedes");
    Console.WriteLine("2- Receber o Valor Total da Hospedagem");
    Console.WriteLine("3- Encerrar");
    Console.Write("Resposta: ");
    int resposta = 0;
    bool verificacaoMenu = int.TryParse(Console.ReadLine(), out resposta);
    if (!verificacaoMenu)
    {

        throw new Exception("Não foi possível obter a Resposta, tente novamente.");

    }

    switch (resposta)
    {
        case 1:
            Console.WriteLine($"No total são {reserva.ObterQuantidadeHospedes()} hóspedes reservados no Hotel.");
            break;
        case 2:
            decimal valorTotal = reserva.CalcularValorHospedagem();
            if(reserva.DiasReservados > 10) {

                Console.WriteLine($"Valor Total da Hospedagem (10% desconto aplicado por ficar mais de 10 dias hospedado): {valorTotal.ToString("C")}");

            } else {

                Console.WriteLine($"Valor Total da Hospedagem: {valorTotal.ToString("C")}");

            }
            break;
        case 3:
            Console.WriteLine("Finalizando...");
            menuReserva = false;
            break;
        default:
            Console.WriteLine("Tente colocar novamente a reposta.");
            break;
    }

}
