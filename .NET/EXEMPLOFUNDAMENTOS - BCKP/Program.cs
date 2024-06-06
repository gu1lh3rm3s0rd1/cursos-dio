// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;
using EXEMPLOFUNDAMENTOS.models;



// sintaxe e identacao
// Pessoa pessoa = new Pessoa();
// pessoa.Nome = "Guilherme Machao";
// pessoa.Idade = 22;
// pessoa.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// declarando variaveis
// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;

// // double nao é usado para representar casas decimais
// double altura = 1.80;

// // usado para representar casas decimais
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// //tipo de data time
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// //cast 
// int a = Convert.ToInt32("5");
// int b = int.Parse("5c");

// //diferenca convert e parse - convert trata valores null melhor e nao interrompe o processo do programa

// Console.WriteLine(a);
// Console.WriteLine(b);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//operadores
//sao eles> operadores de atribuicao (=), operadores de condicao(IF/ELSE, SWITCH CASE, IF TERNALLY) e operadores logicos(AND, OR, NOT...), operadores aritimeticos sao os mesmos de qualquer linguagem de programaçao(+, -, /, *, ++, -- e %(modulo))



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(10, 50);
// calc.Dividir(10, 50);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);


// int numeroIncremento = 10;

// // Exibindo o valor original
// Console.WriteLine($"Valor original: {numeroIncremento}");

// // Incrementando o número
// numeroIncremento++;
// Console.WriteLine("Após incremento:");
// Console.WriteLine(numeroIncremento); // Exibindo o valor após incremento

// int numeroDecremento = 20;

// // Exibindo o valor original
// Console.WriteLine($"Valor original: {numeroDecremento}");

// // Decrementando o número
// numeroDecremento--;
// Console.WriteLine("Após decremento:");
// Console.WriteLine(numeroDecremento); // Exibindo o valor após decremento


// calc.RaizQuadrada(9);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//estrutura de repoeticao
//padrao igual em outroa linguagens

//exemplo com while
string opcao;

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opcao: ");
    Console.WriteLine("1: cadastro ");
    Console.WriteLine("2: busca cliente");
    Console.WriteLine("3: apagar cliente");
    Console.WriteLine("4: encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("cadastro cliente");
            break;

        case "2":
            Console.WriteLine("busca do cliente");
            break;

        case "3":
            Console.WriteLine("apagar cliente");
            break;

        case "4":
            Console.WriteLine("encerrar");
            Console.WriteLine("O programa se encerrou.");
            return;  // To exit the loop when option 4 is selected

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////