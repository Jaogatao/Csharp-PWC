//1° Exercício 

 string texto1 = "Hello, World OpenAI is amazing";
 string[] palavras = texto1.Split(' ');
 string textoInvertido = "";

 for (int i = palavras.Length - 1; i >= 0; i--)
 {
     textoInvertido += palavras[i];

    if (i != 0)
   {
       textoInvertido += " ";
   }
 }


//2° exercício 


string texto2 = "Hello, World!";
string novoTexto = "";

for(int i= 0; i <= texto2.Length - 1; i++)
{
if(novoTexto.IndexOf(texto2[i]) == -1)
{
    novoTexto += texto2[i];
}
}

Console.WriteLine(novoTexto);



//3° exercício









//4° Exercício

        string input = "hello, how are you ? i`m fine, thank you.";
        string output = (input.ToLower());
        
        Console.WriteLine(output);



