using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio2.ProjetoCelular;

public abstract class Smartphone
{
    // Propriedades
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    // Método para ligar o smartphone
    public void Ligar()
    {
        Console.WriteLine("O está celular está ligando.");
    }

    // Método para receber uma ligação
    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo uma ligação.");
    }

    // Método para instalar um aplicativo
    public virtual void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no smartphone.");
    }
}
