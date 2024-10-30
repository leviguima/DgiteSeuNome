using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System;


class Program
{
    static void Main()
    {
        //Programa com 2 valores double definidos e faz operações matemáticas e na divisão verifica se numero2 é zero

        Console.Write("Digite o seu nome: ");
        string seuNome = Console.ReadLine();

        Console.WriteLine("Olá, " + seuNome + "! " +"Seja muito bem-vindo!");

        Console.Write("Digite o seu sobrenome: ");
        string seuSobrenome = Console.ReadLine();

        Console.WriteLine(seuNome + " " + seuSobrenome);

        Console.WriteLine();

        double numero1 = 3.14;
        double numero2 = 2.12;

        double soma = numero1 + numero2;
        Console.WriteLine("Soma = " + soma);

        double subtracao = numero1 - numero2;
        Console.WriteLine("Subtração = " + subtracao);

        double multiplicacao = numero1 * numero2;
        Console.WriteLine("Multiplicação = " + multiplicacao);

        double divisao = numero1 / numero2;
        if (numero2 == 0)
        {
            Console.WriteLine("Número Infinito");
        }
        else
        {
            Console.WriteLine("Divisão = " + divisao);
        }
        
        double media = (numero1 + numero2) / 2;
        Console.WriteLine("Média = " + media);

        // Operação com números aleatórios
        // Entrada dos números com cultura invariante para garantir o ponto como separador decimal
        
        Console.WriteLine();

        Console.Write("Digite o primeiro número: ");
        double aleatorio1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o segundo número: ");
        double aleatorio2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double somaaleatorios = aleatorio1 + aleatorio2;
        //Formata para duas casas decimais
        Console.WriteLine("Soma: " + somaaleatorios.ToString("F2", CultureInfo.InvariantCulture));  

        double subtracaoaleatorios = aleatorio1 - aleatorio2;
        //Formata para duas casas decimais
        Console.WriteLine("Subtração: " + subtracaoaleatorios.ToString("F2", CultureInfo.InvariantCulture));  

        double multiplicacaoaleatorios = aleatorio1 * aleatorio2;
        //Formata para duas casas decimais
        Console.WriteLine("Multiplicação: " + multiplicacaoaleatorios.ToString("F2", CultureInfo.InvariantCulture));  

        double divisaoaleatorios = aleatorio1 / aleatorio2;
        if (aleatorio2 == 0)
        {
            Console.WriteLine("Número Infinito");
        }
        else
        {
            //Formata para duas casas decimais
            Console.WriteLine("Divisão: " + divisaoaleatorios.ToString("F2", CultureInfo.InvariantCulture));  
        }

        //Programa que digita uma ou mais palavras e conta o números de caracteres digitados sem o espaço entre palavras
        
        Console.WriteLine();

        Console.Write("Digite uma ou mais palavras: ");
        string textoDigitado = Console.ReadLine();
        int contador = 0;

        // Conta os caracteres, ignorando espaços
        foreach (char c in textoDigitado)
        {
            if (!char.IsWhiteSpace(c)) 
            {
                contador++;
            }
        }
        Console.WriteLine("O que você digitou tem: " + contador + " caracteres sem espaço entre as palavras");

        // Programa para verificar se placa é ou não válida

        Console.WriteLine();

        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        // Expressão que verifica se a placa digitada está no padrão brasileiro até 2018
        bool placaValida = Regex.IsMatch(placa, @"^[A-Za-z]{3}[0-9]{4}$");

        // Exibe se a placa é válida ou não
        if (placaValida == true)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

        Console.WriteLine();

        //Programa que solicita ao usuário a exibição da data atual em diferentes formatos:

        DateTime dataAtual = DateTime.Now;
        CultureInfo culturaBR = new CultureInfo("pt-BR"); // Cultura brasileira para formatação

        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        Console.Write("Digite a opção desejada (1-4): ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                // Formato completo
                Console.WriteLine("Data completa: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", culturaBR));
                break;

            case 2:
                // Apenas a data no formato "01/03/2024"
                Console.WriteLine("Data: " + dataAtual.ToString("dd/MM/yyyy", culturaBR));
                break;

            case 3:
                // Apenas a hora no formato de 24 horas
                Console.WriteLine("Hora: " + dataAtual.ToString("HH:mm:ss", culturaBR));
                break;

            case 4:
                // Data com o mês por extenso
                Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", culturaBR));
                break;

            default:
                Console.WriteLine("Opção inválida. Escolha uma opção entre 1 e 4.");
                break;
        }
    }

}

