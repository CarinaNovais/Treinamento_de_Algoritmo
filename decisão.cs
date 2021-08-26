1 - Mostra se o aluno foi aprovado ou reprovado

using System;

class MainClass {
  public static void Main (string[] args) {
    double N1,N2,N3,N4,media;
    string nome;
    Console.WriteLine ("Digite seu nome:");
    nome=(Console.ReadLine());
    Console.WriteLine ("Digite a primeira nota:");
    N1=double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a segunda nota:");
    N2=double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a terceira nota:");
    N3=double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a quarta nota:");
    N4=double.Parse(Console.ReadLine());
    media=(N1+N2+N3+N4)/4;
    if (media>=7) {
      Console.WriteLine (nome+"está aprovado!!");
    }
    else {
      Console.WriteLine (nome+ "está reprovado!");
    }
  }
}

2 - Mostra o maior número 

using System;

class MainClass {
  public static void Main (string[] args) {
    double N1,N2,N3,N4;
    Console.WriteLine ("Digite o primeiro valor:");
      N1=double.Parse(Console.ReadLine());
      Console.WriteLine ("Digite o segundo valor:");
        N2=double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o terceiro valor:");
          N3=double.Parse(Console.ReadLine());
          Console.WriteLine ("Digite o quarto valor:");
            N4=double.Parse(Console.ReadLine());
            if(N1>N2 && N1>N3 && N1>N4){
              Console.WriteLine(N1+"é o maior número.");
            }
            else if (N2>N1 && N2>N3 && N2>N4) {
              Console.WriteLine(N2+"é o maior número.");
            }
            else if (N3>N1 && N3>N2 && N3>N4){
              Console.WriteLine(N3+"é o maior número.");
            }
            else{
              Console.WriteLine(N4+"é o maior número.");
            }
  }
  
  3 - Mostra se é ímpar ou par
  
  using System;

class MainClass {
  public static void Main (string[] args) {
    int N1;
    Console.WriteLine ("Digite o número:");
    N1=int.Parse(Console.ReadLine());
    if (N1%2==0) {
          Console.WriteLine (N1+ "é par.");
    }
    else {
            Console.WriteLine (N1+ "é ímpar.");
    }
  }
}

4 - Mostra se o número é positivo ou negativo

using System;

class MainClass {
  public static void Main (string[] args) {
    int N1;
    Console.WriteLine ("Digite o valor");
    N1=int.Parse(Console.ReadLine());
    if (N1>=0) {
      Console.WriteLine (N1+"é posititvo.");
    }
    else {
      Console.WriteLine (N1+"é negativo.");
    }
  }
}
