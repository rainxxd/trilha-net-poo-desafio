using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("99999-1111", "Nokia Tijolão", "123456789", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("98888-2222", "iPhone 13", "987654321", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
