using System;

namespace dio2.ProjetoCelular;

public class Nokia : Smartphone
{
    // Construtor Nokia
    public Nokia(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo - {aplicativo} - no seu Nokia.");
    }
}

