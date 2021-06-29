1 - Tabuada do 4

using System;

class MainClass {
  public static void Main (string[] args) {
    int c;
    for (c=1;c<=10;c++) {
      Console.WriteLine("4x"+c+"="+(4*c));
    }
  }
}

2 - Qualquer tabuada

using System;

class MainClass {
  public static void Main (string[] args) {
    int c,t;
    Console.Write("Qual tabuada? ");
    t=int.Parse(Console.ReadLine());
    for (c=1;c<=10;c++){
	    Console.WriteLine(c+"x"+t+"="+(t*c));
    }
  }
}

3 - Média Aritimética de 15 números

using System;

class MainClass {
  public static void Main (string[] args) {
    double n,soma=0,media;
    int x;
    for (x=1;x<=15;x++){
	    Console.WriteLine("Digite o {0} valor: ",x);
	    n=double.Parse(Console.ReadLine());
	    soma=soma+n;
    }
      media=soma/15;
      Console.Write("A média é de: "+media);
  }
}

4 - Qual maior número ?

using System;

class MainClass {
  public static void Main (string[] args) {
    int n=1,maior=0;
      while (n!=0){
	      Console.Write("Digite um número (0-sair): ");
	      n=int.Parse(Console.ReadLine());
	      if (n>maior || maior==0){
	    	maior=n;
	}
}
Console.Write("O maior número digitado foi: "+maior);
  }
}

5 - O programa separa os números digitados pelo usuário em grupos de impares, pares, negativos e positivos (mostra apenas a quantidade)

using System;

class MainClass {
  public static void Main (string[] args) {
    int n,pares=0,impares=0,positivos=0,negativos=0;
      do{
	      Console.Write("Digite um número (0-sair): ");
      	n=int.Parse(Console.ReadLine());
	      if (n%2==0){
		      pares++;
	      }else{
		      impares++;
	      }
      	if (n>=0){
	      	positivos++;
      	}else{
	      	negativos++;
	      }
      }while(n!=0);
        Console.WriteLine("Pares: "+pares);
        Console.WriteLine("Ímpares: "+impares);
        Console.WriteLine("Positivos: "+positivos);
        Console.WriteLine("Negativos: "+negativos);
        Console.ReadKey();
  }
}
