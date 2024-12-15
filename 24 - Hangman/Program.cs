string palavra = "batata";
int vida = 6;
int vida_atual = vida;
 
List<char> letras = new List<char>();

bool vitoria = false;

while (vida_atual > 0 && !vitoria)
{
    
    foreach (char c in palavra)
    {
        if (letras.Contains(c)) Console.Write(c);
        else Console.Write("*");
    }
    
    Console.WriteLine("\nChuta uma letra aí");
    Console.WriteLine($"Vidas: {vida_atual}");
    char tentativa = Convert.ToChar(Console.ReadLine());

    if(palavra.Contains(tentativa) && !letras.Contains(tentativa)) letras.Add(tentativa);
    else vida_atual--;


    bool palavra_completa = true;
    foreach (char c in palavra) if (!letras.Contains(c)) palavra_completa = false;
    vitoria = palavra_completa;

}

if (vitoria) System.Console.WriteLine("Você venceu!");
else System.Console.WriteLine("Você perdeu");



