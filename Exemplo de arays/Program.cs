using Exemplo_de_arays.Models;




List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MS");
listaString.Add("MT");
listaString.Add("RJ");



Console.WriteLine($"Item na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Item na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");

listaString.Remove("MT");

Console.WriteLine($"Item na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");


// Console.WriteLine("percorrendo a lista com FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posiçao N° {contador} - {listaString[contador]}");
// }



// Console.WriteLine("percorrendo a lista com FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posiçao N° {contadorForeach} - {item}");
//     contadorForeach++;
// }




















// int [] arrayInteiro = new int[4];

// arrayInteiro[0] = 2;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50;
// arrayInteiro[3] = 5;



// int[] arrayInteiroDobrado = new int[arrayInteiro.Length * 2];
// Array.Copy(arrayInteiro, arrayInteiroDobrado, arrayInteiro.Length);


// //Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);

// Console.WriteLine("Percorrendo o array com FOR");
// for(int contador = 0; contador < arrayInteiro.Length; contador++)
// {
//     Console.WriteLine($"Posiçao N° {contador} - {arrayInteiro[contador]}");
// }
















// int contadorForeach = 0;
// Console.WriteLine("percorrendo o array com FOREACH");
// foreach(int valor in arrayInteiro)
// {
//     Console.WriteLine($"Possiçao N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }