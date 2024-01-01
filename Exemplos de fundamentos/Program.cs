using Exemplos_de_fundamentos.Models;





string opçao;
bool exibirMenu = true;


while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua opçao!");
    Console.WriteLine("1 - Cadrastrar cliente!");
    Console.WriteLine("2 - Buscar cliente!");
    Console.WriteLine("3 - Apagar cliente!");
    Console.WriteLine("4 - Encerrar!");

    opçao = Console.ReadLine();

    switch(opçao)
    {
        case "1":
        Console.WriteLine("Cadrastro de cliente!");
        break;

        case "2":
        Console.WriteLine("Busca de cliente!");
        break;

        case "3":
        Console.WriteLine("Apagar cliente!");
        break;

        case "4":
        Console.WriteLine("Encerrar!");
         exibirMenu = false;
        //Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Opçao invalida!");
        exibirMenu = false;
        break;
    }
}





















// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um numero! (0 para parar.)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);


// Console.WriteLine($"Total da soma registrado é: {soma}");





















// int numero = 5;
// int contador = 1;

// while(contador <= 10)
// {
//      Console.WriteLine($"{contador }ª Execuçao: {numero} x {contador} = {numero * contador}");
//      contador++;

//      if(contador == 6)
//      {
//         break;
//      }
// }



















// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



















//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.Raizquadrada(9);
























// int numeroDecremento = 10;
// Console.WriteLine(numeroDecremento);
// //numero = numero + 1
// numeroDecremento++; 
// Console.WriteLine(numeroDecremento);


// int numeroIncremento = 20;
// Console.WriteLine(numeroIncremento);
// //numero = numero - 1
// numeroIncremento--;
// Console.WriteLine(numeroIncremento);


















// bool choveu = false;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia!");
// }
















// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }
















// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDosPais = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDosPais)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada negada!");
// }

















// Console.WriteLine("Digíte uma letra");
// var letra = Console.ReadLine();



// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma Vogal");
//         break;
// }










// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma Vogal");
// }









// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é uma Vogal");
// }

















// int quantidadeEmEstoque = 3;

// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;



// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda?: {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpa. Não temos a quantidade dejejada em estoque.");
// }












// string a = "15-";

//int b = 0;
//int b = Convert.ToInt32(a);
// int.TryParse(a, out int b);

// Console.WriteLine(a);
// Console.WriteLine("Conversão realizada com sucesso!");
 








// double a = 4 / 2 + 2;
// Console.WriteLine(a);









// int a = 5;
// double b = a;

// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);










// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);







//cast -- casting

//int a = Convert.ToInt32("5);
//int a = int.Parse("5c");

//Console.WriteLine(a);








// int a = 10;
// int b = 20;

// int c = a + b;

//c = c -5;
// c -= 5;

// c += 5;
// c = c +5;

// Console.WriteLine(c);









// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá, seja Bem vindo.";

// int quantidade = 1;

// double altura = 1.60;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade:" + quantidade);
// Console.WriteLine("Valor da variavel altura:" + altura);
// Console.WriteLine("Valor da variavel preco:" + preco);
// Console.WriteLine("Valor da variavel condicao:" + condicao);



//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Dns";
//pessoa1.Idade = 27;
//pessoa1.Apresentar();


//Pessoa pessoaFisicaRepresentacao = new Pessoa();
