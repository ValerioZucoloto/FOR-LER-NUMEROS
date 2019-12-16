using System;

class MainClass {
  public static void Main (string[] args) {
    int n, x, soma;

    Console.WriteLine ("Informa a quantidade de números: ");

    n = int.Parse (Console.ReadLine());
    soma = 0;

    for (int i= 1; i<=n; i++) {
      x = int.Parse (Console.ReadLine());
      soma = soma + x;
    }
    
    
    Console.WriteLine ("A soma é: "+ soma);
    
  }
}