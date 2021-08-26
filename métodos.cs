1 - Fatorial 

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 1: Calcular Fatorial");
    Console.WriteLine();
    
    int n=0;
    digite();
    n=int.Parse(Console.ReadLine());
    Console.Write("\n{0}!=1",n);
    fatorial(n);
  }

    static void digite() {
      Console.Write("Digite um número: ");
    }

    static void fatorial(int f, int res=1) {
      for (int x=2; x<=f; x++){
                               res = res * x;
                               Console.Write("*{0}", x);   
                              }
      Console.WriteLine("={0}",res);
  }
}

2 - Calculo da Diferença

using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine ("Exercício 2: Calculo diferença.");
    Console.WriteLine();
    int n1,n2,maiorN,menorN;
    digite();
    n1=int.Parse(Console.ReadLine());
    digite1();
    n2=int.Parse(Console.ReadLine());
    if (n1>n2){
      maiorN=n1;
      menorN=n2;
    } else{
      maiorN=n2;
      menorN=n1;
    }
    d(maiorN,menorN);
  }
    static void digite()
    {
      Console.WriteLine("Digite um número:");
    }

    static void digite1()
    {
      Console.WriteLine("Digite outro número:");
    }

    static void d(int a, int b)
    {
    int df=a-b;
    Console.WriteLine("{0} - {1} = {2}",a,b,df);
     Console.WriteLine("\n\nFim do Programa);
    }
  }
  
  3 - Triangulos 
  
  using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 3: triangulo");
    Console.WriteLine();
    int A,B,C;
    valor1();
    A=int.Parse(Console.ReadLine());
    valor2();
    B=int.Parse(Console.ReadLine());
    valor3();
    C=int.Parse(Console.ReadLine());
    tipo (A,B,C);
  }

  static void tipo (int X,int Y,int Z){
    if (X==Y && Y==Z){;
      Console.WriteLine("Esse é um Triângulo Equilatero\n\nFim do Programa");
    } else if (X==Y || X==Z || Y==Z){
      Console.WriteLine("Este é um Triângulo Isóceles\n\nFim do Programa");
    }else{
        Console.WriteLine("Este é um Triângulo Escaleno\n\nFim do Programa");
    }
  }

    static void valor1()
    {
      Console.WriteLine("Digite o primeiro valor:");
    }

    static void valor2()
    {
      Console.WriteLine("Digite o segundo valor:");
    }

    static void valor3()
    {
      Console.WriteLine("Digite o terceiro valor:");
    }
  }
  
  4 - IMC
  
  using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 4: Peso Ideal");
    Console.WriteLine();
    double hal;
    string sx;
    altura ();
    hal=double.Parse(Console.ReadLine());
    sexo();
    sx=Console.ReadLine();
    ideal(hal,sx);
  }
    static void ideal (double hall,string SXo){
    if (SXo=="H"){
      double peso=(72.7*hall) - 58;
      Console.WriteLine("Esse é seu peso ideal: {0}kg\n\nFim do Programa",peso);
    }else{
      double peso=(62.1 *hall) - 44.7;
      Console.WriteLine("Esse é seu peso ideal: {0}kg\n\nFim do Programa",peso);
    }
  }
    static void altura()
    {
      Console.WriteLine("Digite sua altura:");
    }
  
    static void sexo ()
    {
    Console.WriteLine("Você é homem ou mulher?:\n(Digite H para homem e M para mulher)");
    }
  }
  
  5 - Menu e calculadora
  
  using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Menu - Calculadora");
    Console.WriteLine();
    int menu;
	  double valor1=0,valor2=0;
	  do{
		Console.Clear();
		Console.WriteLine("CALCULADORA\n\n1-Somar\n2-Subtrair\n3-Multiplicar\n4-Dividir\n0-Sair\n\nDigite sua opção: ");
		menu=int.Parse(Console.ReadLine());
		if (menu>0 && menu<5){
			Console.Write("Digite o 1º valor: ");
			valor1=double.Parse(Console.ReadLine());
			Console.Write("Digite o 2º valor: ");
			valor2=double.Parse(Console.ReadLine());
		}
		switch (menu){
			case 1:
				Somar(valor1,valor2);
				break;
			case 2:
				Subtrair(valor1,valor2);
				break;
			case 3:
				Multiplicar(valor1,valor2);
				break;
			case 4:
				Dividir(valor1,valor2);
				break;
			default:
				if (menu!=0){
					Console.WriteLine("Opção inválida!");
				}
				break;
		}
    Console.ReadKey();
	}while(menu!=0);
}

static void Somar(double a,double b){
	double res;
	res=a+b;
	Console.Write("A soma é: {0}\n\nFim do Programa",res);
}

static void Subtrair(double a,double b){
	double res;
	res=a-b;
	Console.Write("A subtração é: {0}\n\nFim do Programa",res);
}

static void Multiplicar(double a,double b){
	double res;
	res=a*b;
	Console.Write("A multiplicação é: {0} \n\nFim do Programa",res);
}

static void Dividir(double a,double b){
	double res;
	res=a/b;
	Console.Write("A divisão é: {0} \n\nFim do Programa",res);
  }
}

6 - Quadrante

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercicío 6 - Quadrante");
    Console.WriteLine();
    int v1;
    digite();
    v1=int.Parse(Console.ReadLine());
    quadrante(v1);
  }
    static void quadrante(int valor){
    if (valor>=0 && valor<=90){
        Console.WriteLine("Esse valor está no 1° quadrante.\n\nFim do Programa");
      } else if (valor>=91 && valor<=180){
        Console.WriteLine("Esse valor está no 2° quadrante.\n\nFim do Programa");
      }else if (valor>=181 && valor<=270){
      Console.WriteLine("Esse valor está no 3° quadrante.\n\nFim do Programa");
      }else if (valor>=271 && <=270){
         Console.WriteLine("Esse valor está no 4° quadrante.\n\nFim do Programa");
      }
  }
    static void digite ()
    {
      Console.WriteLine("Digite o valor: ");
    }
  }
