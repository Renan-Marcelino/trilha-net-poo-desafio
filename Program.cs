using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", emei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");
        Console.WriteLine("\n");

        Console.WriteLine("Smartphone IPhone:");
        Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", emei: "222222222", memoria: 128);
        iphone.ReceberLigacao();  // Corrigindo o nome do método
        iphone.InstalarAplicativo("Telegram");
    }
}