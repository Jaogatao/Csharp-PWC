//1° Exercício 

string texto = "Hello, World OpenAI is amazing";
string[] palavras = texto.Split(' ');
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



