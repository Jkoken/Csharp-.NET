using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;  
    raio = double.Parse(Console.ReadLine());
    volume = pi * (4.0/3.0) * Math.Pow( raio , 3 ); //Não foi utilizado o Math.Round(... ,3) pois em caso de retornos com valor zero após a vírgula, ele não iria trazer todas as casas, por exemplo ao desejar a saída "10.440", ele não funcionaria dessa forma, a saída seria "10.44"
    
    Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    //Acima foi utilizado o .ToString("F3"), pois era necessário, para o desafio, trazer, SEMPRE, três casas decimais, com isso esse comando foi encorpado na saída.

  }

}
