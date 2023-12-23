using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio2.ProjetoCelular;

   class Program
{
    static void Main()
    {
        // Criar uma instância de Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 8", "ABC123", 64);

        // Testar os métodos da classe Nokia
        Console.WriteLine($"Número do Nokia: {nokia.Numero}");
        Console.WriteLine($"Modelo do Nokia: {nokia.Modelo}");
        Console.WriteLine($"IMEI do Nokia: {nokia.IMEI}");
        Console.WriteLine($"Memória do Nokia: {nokia.Memoria}GB");

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criar uma instância de Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 12", "XYZ789", 128);

        // Testar os métodos da classe Iphone
        Console.WriteLine($"Número do iPhone: {iphone.Numero}");
        Console.WriteLine($"Modelo do iPhone: {iphone.Modelo}");
        Console.WriteLine($"IMEI do iPhone: {iphone.IMEI}");
        Console.WriteLine($"Memória do iPhone: {iphone.Memoria}GB");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
