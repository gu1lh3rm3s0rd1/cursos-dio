// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using EXEMPLOEXPLORANDO.models;
using Newtonsoft.Json;


// Pessoa p1 = new Pessoa();
// p1.Nome = "Guilherme";
// p1.Sobrenome = "Machao";
// p1.Idade = 22;
// p1.Apresentar();

// Pessoa p1 = new Pessoa("Guilherme", "Machao"); //construtores
// Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "Machao");
// p1.Nome = "Guilherme";
// p1.Sobrenome = "Machao";

// Pessoa p2 = new Pessoa("Benjamim", "Machao");
// Pessoa p2 = new Pessoa(nome: "Benjamim", sobrenome: "Machao");
// p2.Nome = "Benjamim";
// p2.Sobrenome = "Machao";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// concatenando valores
// string numero1 = "10";
// string numero2 = "20";
// string numero1 = "10";
// int numero2 = 20;
// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

//formatando valores monetarios
// decimal valorMonetario = 15182.40M;
// :C pega a localizacao de configuracao do sistema do computador
// Console.WriteLine($"{valorMonetario:C}");

// foramtando casa decimal personalizada
// existem diversasa maneiras, esses sao só alguns exemplos
// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C2"));
// Console.WriteLine(valorMonetario.ToString("N8"));

// representando porcentagem
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// mascaras
// int numero = 123456789;
// Console.WriteLine(numero.ToString("###-###-###"));


using System.Globalization;
using System.Net.Mail;

// formatando datas
// DateTime data = DateTime.Now;
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyy HH:mm"));
// Console.WriteLine(data.ToString("dd/mm/yyy HH:mm"));
// Console.WriteLine(data.ToString("dd/M/yyy HH:mm"));
// Console.WriteLine(data.ToString("dd/MM/yyy hh:mm"));
// Console.WriteLine(data.ToString("dd-MM-yyy HH:mm"));

// // convertendo datas
// DateTime data1 = DateTime.Parse("17/04/2022 20:00");
// // DateTime data1 = DateTime.Parse("37/04/2022 20:00"); // n funciona pq 37 nao é uma data valida
// Console.WriteLine(data1);



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// exceçao e coleçao
// lendo arquivos
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeituraaaa.txt"); // aqui ja gera excecao - condicao que quebra o prorama e encerra ele

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// uma excecao é qunado o programa nao tem mais saida, ele tenta executar o comando mas nao consegue


// tratando uma excecao 
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitur_a.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado." + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// Console.WriteLine("Chegou até aqui");



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//coleçoes
// fila na pratica
// // processa elementos em ordem
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Remove elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// // colecao do tipo pilha - stack
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Remove o elemento do topo:  {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// tuplas
// (int, string, string, decimal) tupla = (1, "Guilherme", "Machao", 1.89M);

// // outras sintaxes da tupla
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Guilherme", "Machao", 1.89M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Guilherme", "Machao", 1.89M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


// instacinado a classe leitura
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas: " + quantidadeLinhas);

//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Nao foi possivel ler o arquivo");
// }



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// desconstrutor
// Pessoa p1 = new Pessoa("tes", "te");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// if ternario / if ternally
//  usando if comum
// int numero = 15;

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"Nuemro {numero} eh par");
// }
// else
// {
//     Console.WriteLine($"Numero {numero} eh impar");
// }

// // usando if ternally
// bool par = false;
// par = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} eh " + (par ? "par" : "impar"));



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// //  serializacao de dados
// Venda v1 = new Venda(1, "Licenca de escritorio", 50.00M, dataAtual);
// Venda v2 = new Venda(2, "Material de escritorio", 25.00M, dataAtual);
// Venda v3 = new Venda(3, "Licenca Software", 125.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// // string serializado = JsonConvert.SerializeObject(v1); // exibe td numa linha só 
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// // CRIANDO UMA arqiuovo JSON para salvar a serializacao 
// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// deserializando um objeto
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" + $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd / MM / yyyy HH: mm")}");
}