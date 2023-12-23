using System;

namespace dio2.ProjetoCelular;

public class Iphone : Smartphone
{
    //Construtor Iphone
    public Iphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo - {aplicativo} - em seu iPhone.");
    }
}