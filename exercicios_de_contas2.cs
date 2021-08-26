1 - 

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 1: Escreva um programa que exiba na tela em ordem crescente, apenas os números pares existentes de 11 a 250. ");
    Console.WriteLine();
    int x;
      for (x=11;x<=250;x++){
        if(x%2==0)
          Console.Write(x+",");
    }
  }
}

2 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 2: Escreva um programa que exiba na tela em ordem decrescente, apenas os números ímpares existentes entre dois números digitados pelo usuário (inclusive eles).");
    Console.WriteLine();
    int N1,N2,menor_numero,maior_numero,x;
            Console.Write("Digite um número: "); 
            N1=int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            N2=int.Parse(Console.ReadLine());
            if (N1<=N2){
                menor_numero=N1;
                maior_numero=N2;
            }else{
                menor_numero=N2;
                maior_numero=N1;
            }
            for (x=menor_numero; x<=maior_numero; x++){
                if (x%2!=0){
                  Console.Write(x+",");
              } 
            }
  }
}

3 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 3: Escreva um programa que exiba na tela a tabuada de um número que deverá ser informado pelo usuário (deverá ser usada qualquer estrutura de repetição). ");
    Console.WriteLine();
    int c,t;
    Console.Write("Qual tabuada? ");
    t=int.Parse(Console.ReadLine());
    for (c=1;c<=10;c++){
	    Console.WriteLine(c+"x"+t+"="+(t*c));
    }
  }
}

4 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 4: Escreva um programa que exiba na tela a quantidade de números ímpares existentes entre dois números que o usuário digitar (testar inclusive os números digitados).");
    Console.WriteLine();
    int N1,N2,menor_numero,maior_numero,x,impares=0;
            Console.Write("Digite um número: "); 
            N1=int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            N2=int.Parse(Console.ReadLine());
            if (N1<=N2){
                menor_numero=N1;
                maior_numero=N2;
            }else{
                menor_numero=N2;
                maior_numero=N1;
            }
            for (x=menor_numero; x<=maior_numero; x++){
                if (x%2!=0){
                  impares++;
              } 
            }
            Console.WriteLine("A quantidade de números ímpares entre {0} e {1} é: {2}",N1,N2,impares);
  }
}

5 -
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 5: Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o maior número que foi digitado pelo usuário");
    Console.WriteLine();
    int x,N, maior_numero;
            Console.Write("Digite o 1° número: ");
            maior_numero= int.Parse(Console.ReadLine());
              for (x=2; x<=15;x++){
                Console.Write("Digite o {0}° número: ",x);
                  N= int.Parse(Console.ReadLine());
                    if (N > maior_numero){
                      maior_numero=N;
                }
            }
            Console.WriteLine("\n O maior número digitado foi: {0}", maior_numero);
  }
}

6 - using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 6: Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo usuário. Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez). Se o usuário digitar algum valor inválido, deverá ser exibida uma mensagem informando o ocorrido. ");
    Console.WriteLine();
    double n,soma=0,media=0;
    int x;
      for (x=1;x<=10;x++){
        do{
          Console.Write("Digite a  {0}° nota:",x);
          n=double.Parse(Console.ReadLine());
          if ((n<0) || (n>10)) {
              Console.WriteLine("\nValor inválido, digite novamente:");
        } else{
           soma=soma+n;
           media=soma/10;
        }
      }while(n<0 || n>10);
      }
      Console.WriteLine("A média é de:"+media);
  }
}

7 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 7: Escreva um programa que exiba todos os números de 1 a 100 e a cada número que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”.");
    Console.WriteLine();
    int x;
    for (x=1;x<=100;x++){
      Console.WriteLine(x);
      if (x%10==0){ 
        Console.WriteLine("{0}= Múltiplo de 10",x);
    }
  }
  }
}

8 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 8: Escreva um programa que calcule o fatorial de um número informado pelo usuário. Dica: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N ");
    Console.WriteLine();
    int n=0,resultado=1,x;
    Console.Write("Digite um número: ");
      n=int.Parse(Console.ReadLine());
        Console.Write("\n{0}!=1",n);
          for (x=2; x<=n; x++){
            resultado = resultado * x;
            Console.Write("*{0}", x);
            }
            Console.WriteLine("={0}", resultado);
  }
}

9 - 
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 9: Escreva um programa que leia vários números inteiros e ao final informe quantos números pares, quantos números ímpares, quantos números positivos e quantos números negativos foram digitados pelo usuário. O programa só deve parar de rodar quando o usuário responder (S) na seguinte pergunta, (Deseja encerrar o programa?). ");
    Console.WriteLine();
    int n1, pares = 0, impares = 0, positivos = 0, negativos = 0;
		string s;

            do{
                Console.WriteLine("Digite um número (0-sair)");
                n1 = int.Parse(Console.ReadLine());
                if (n1 % 2 == 0){
                    pares++;
                }else{
                    impares++;
                }
                if (n1 >= 0){
                    positivos++;
                }else{
                    negativos++;
                }
                    
            }
		    while (n1 != 0);
		    Console.WriteLine("Deseja encerar o programa? (s - sim)");
		    s = Console.ReadLine();
		    while (s != "s");
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Ímares: " + impares);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
  }
}

10 -
using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 10: Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. Calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O programa só deve parar de rodar quando o usuário responder (S) na seguinte pergunta, (Deseja encerrar o programa?).");
    Console.WriteLine();
    double C,N,E,sal;  // C= valor das horas extras // N= horas trabalhadas
    string s;         // E= quantidade de horas extras // sal=salario

        do{
          Console.WriteLine("Quantas horas trabalhadas?");
          N=double.Parse(Console.ReadLine());
          if (N>50){
            E=N-50;
            C=E*20;
            sal=50*10+C;
            break;
          }else{
            E=0;
            C=0;
            sal=N*10;
          }
            } while (N!=0);
		                 Console.WriteLine("Deseja encerar o programa? (s - sim)");
		                 s = Console.ReadLine();
                     
		        while (s!= "s");
                     Console.WriteLine("Seu salário mais as horas extras é de: {0} reais \n O valor da sua hora extra é de: {1} reais",sal,C);
  }
}
