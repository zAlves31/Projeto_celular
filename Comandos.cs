namespace Projeto_Celular_Class
{
    public class Celular
{
    public string Cor;
    public string Modelo;
    public double Tamanho;
    public bool Ligado;

    public void Ligar()
    {
        Ligado = true;
    }

    public void Desligar()
    {
        Ligado = false;
    }

    public void FazerLigacao(string numero)
    {
        if (!Ligado)
        {
             Console.WriteLine($"Ligando para {numero}...");
        }

        Console.WriteLine("O celular precisa estar ligado para fazer uma ligação.");
        return;
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        if (!Ligado)
        {
            Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
        }

        Console.WriteLine("O celular precisa estar ligado para enviar uma mensagem.");
        return;
    }
}

}