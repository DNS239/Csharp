using  ExemplosExplorando.Models;
using System.Globalization;



Queue<int> fila = new Queue<int>();


fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}












































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