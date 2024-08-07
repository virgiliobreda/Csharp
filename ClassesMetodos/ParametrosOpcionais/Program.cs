Console.WriteLine("Parâmetros opcionais");


var destino = Console.ReadLine();
var titulo = Console.ReadLine();
var assunto = Console.ReadLine();

Email email = new Email();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino,titulo);
email.Enviar(destino,titulo,assunto);
email.Enviar(destino,titulo:titulo,assunto:assunto);
public class Email
{
    public void Enviar(string destino= "Destino Padrão", string titulo = "Reunião", string assunto = "Avaliação")
    {
        Console.WriteLine($"\nDestino = {destino} - Titulo {titulo}\n Assunto: {assunto}");
    }
}