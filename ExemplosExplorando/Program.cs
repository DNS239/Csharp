﻿using  ExemplosExplorando.Models;
using System.Globalization;





(int, string, string, decimal) tupla = (1, "Dns", "Ajala", 1.68m);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"SobreNome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");




















// Dictionary<string, string> estados = new Dictionary<string, string>();


// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MS", "Mato Grosso do Sul");


// Console.WriteLine(estados["MS"]);


// foreach(var item in estados)            
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Moodificado";


// Console.WriteLine("-------------------");

// foreach(var item in estados)            
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave  = "BA";

// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



















// Stack<int> pilha = new Stack<int>();


// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }






















// Queue<int> fila = new Queue<int>();


// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }












































//new ExmploExecao().metodo1();
















// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/darquivoestrutura.txt");
//     foreach(string linha in linhas)
//     {
//     Console.WriteLine(linha);
//     }

// }catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivos. Aquivo não encontrado{ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivos. Caminho de pasta não encontrado" + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou ate aq");
// }























// string dataString = "2023-11-01 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// //DateTime data = DateTime.Parse(dataString);


// if(sucesso)
// {
//     Console.WriteLine($"Conversao com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} nao e uma data valida!");
// }

//Console.WriteLine(data);


























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");



// decimal valorMonetario = 1582.40M;


// Console.WriteLine(valorMonetario.ToString("N2")); //CultureInfo.CreateSpecificCulture("en-US")

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));























// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);































// Pessoa p1 = new Pessoa("Dns", "Ajala");

// Pessoa p2 = new Pessoa("Tony", "Sterco");



// Curso coursoDeIngles = new Curso();
// coursoDeIngles.Nome = "Ingles";
// coursoDeIngles.Alunos = new List<Pessoa>();

// coursoDeIngles.AdicionarAluno(p1);
// coursoDeIngles.AdicionarAluno(p2);
// coursoDeIngles.ListaAlunos();




















// Pessoa p1 = new Pessoa();
// p1.Nome = "Dns";
// p1.SobreNome = "Ajala";
// p1.Idade = 27;
// p1.Apresentar();