using System.Collections.Generic;

// Criando uma lista de produtos dinâmica (começa vazia e adiciona conforme o usuário digita)
List<double> precosProdutos = new List<double>();

Console.WriteLine("=== MERCADINHO: REGISTRO DE COMPRAS === ");
double precosDigitado = -1;

// Laço de repetição para a inserção de valores pelo usuário
while (precosDigitado != 0) 
{
    Console.WriteLine("Para finalizar digite '0'");
    Console.Write("Digite o preco do produto: R$ ");
    precosDigitado = double.Parse(Console.ReadLine());

    if (precosDigitado > 0) 
    {
        // Correção: C# usa o 'A' maiúsculo no método .Add()
        precosProdutos.Add(precosDigitado); 
    }
}

// Correção: Faltava o ponto e vírgula (;) no final desta linha
double valorTotal = CalcularTotalCompra(precosProdutos);

Console.WriteLine("============================================");
Console.WriteLine($"Quantidade de itens comprados : {precosProdutos.Count}");
Console.WriteLine($"Valor total a pagar           : R$ {valorTotal:F2}");
Console.WriteLine("============================================");

// Funçao que recebe a lista com os precos por parametro, soma-os e RETORNA o total
static double CalcularTotalCompra(List<double> listaPrecos) 
{
    double soma = 0;

    // O foreach percorre cada item da lista automaticamente
    foreach (double preco in listaPrecos) 
    {
        soma += preco;
    }

    return soma;
}
