1 - Verifica se o número é par
using System;

class MainClass {
  public static void Main (string[] args) {

    int [] n_par = new int [15];
    int i;

    for (i=0;i<15;i++) {
      Console.Write("Digite o {0}° número: ",i+1);
      n_par[i]=int.Parse(Console.ReadLine());
    }
    Console.Write("São pares: ");
    for (i=0;i<15;i++){
      if (n_par[i]%2==0){
        Console.Write(+n_par[i]+",");
      }
    }
  }
}

2 - Produto e preço/ Mostra os produtos abaixo do orçamento do usuário

using System;

class MainClass {
  public static void Main (string[] args) {

  int i;
  string[] nomes=new string[10];
  double[] precos=new double[10];
  double v;

  for (i=0;i<10;i++){   
    Console.Write("Digite o nome do {0}º produto: ",i+1);
    nomes[i]=Console.ReadLine();
    Console.Write("Digite o valor do {0}° produto: ",i+1);
    precos[i]=double.Parse(Console.ReadLine());
    }
    Console.WriteLine("\nDigite o quanto quer gastar: ");
    v=double.Parse(Console.ReadLine());

    for (i=0;i<10;i++){
      if(precos[i]<=v){
        Console.WriteLine("Produto: "+nomes[i]+" Preço: "+precos[i]);
      }
    }
  }
}

3 - Escreva um programa que leia uma matriz (3x5 ou 5x3) de 15 números inteiros e exiba ao final a soma dos valores de cada linha que estão armazenados nesta matriz. 

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 3");
    int l,c,res;
    int[,] numeros = new int[3,5];

    for (l=0;l<3;l++){
      for (c=0;c<5;c++){
        Console.Write("Digite o valor da posição [{0}][{1}]: ",l+1,c+1);
        numeros[l,c]=int.Parse(Console.ReadLine());
      }
    }

    for (l=0;l<3;l++){
      res=0;
      for (c=0;c<5;c++){
        res=res+numeros[l,c];
      }
      Console.WriteLine("\n{0}ª linha: {1}",l+1,res);
    }
  }
}

4 -  Escreva um programa que armazene os números de 1 a 25 em uma matriz 5x5 e ao final exiba apenas os valores das diagonais desta matriz.

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 4");

    int[,] matriz = {{1,2,3,4,5},{6,7,8,9,10},{11,12,13,14,15},{16,17,18,19,20},{21,22,23,24,25}};

    Console.WriteLine("\nDiagonal da esquerda para a direta: {0},{1},{2},{3},{4}",(matriz[0,0]),(matriz[1,1]),(matriz[2,2]),(matriz[3,3]),(matriz[4,4]));
    Console.WriteLine("\nDiagonal da direita para a esquerda: {0},{1},{2},{3},{4}",(matriz[0,4]),(matriz[1,3]),(matriz[2,2]),(matriz[3,1]),(matriz[4,0]));
  }
}

5 - Escreva um programa que leia o nome de 10 alunos (vetor). Para cada aluno devem ser registradas 3 notas (matriz). Calcular a média das notas de cada aluno e armazenar em um vetor. Ao final deverá ser exibido na tela um relatório com os dados de todos os alunos (nome, notas, media) e também a informação se o aluno foi aprovado ou reprovado (média para aprovação 7,0). Para o caso de aprovado exibir todos os dados do aluno na cor azul, caso contrário exibir os dados na cor vermelha.(Dica: usar os comandos Console.ForegroundColor = ConsoleColor.Red e Console.ForegroundColor = ConsoleColor.Blue);

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exercício 4");

    int[,] matriz = {{1,2,3,4,5},{6,7,8,9,10},{11,12,13,14,15},{16,17,18,19,20},{21,22,23,24,25}};

    Console.WriteLine("\nDiagonal da esquerda para a direta: {0},{1},{2},{3},{4}",(matriz[0,0]),(matriz[1,1]),(matriz[2,2]),(matriz[3,3]),(matriz[4,4]));
    Console.WriteLine("\nDiagonal da direita para a esquerda: {0},{1},{2},{3},{4}",(matriz[0,4]),(matriz[1,3]),(matriz[2,2]),(matriz[3,1]),(matriz[4,0]));
  }
}

6 - Jogo da velha 

using System;

class MainClass {
  public static void Main (string[] args) {

    int jogador = 1, jogadas=0; 
    char[,] velha = new char[3, 3];
    int l,c; 
    int jogada; // variável da posição da jogada do jogador
    char simbolo; // guarda o caracter X ou O para mostrar no jogo da velha
    bool valida, vencedor=false; // valida --> (true) jogada válida ou (false) jogada inválida, vencedor --> se há vencedor no jogo (true) ou não (false)

        for (l = 0; l < 3; l++) {
            for (c = 0; c < 3; c++) {
                velha[l, c] = Convert.ToChar((l*3+(c+1)).ToString());
              }
          }
            do {
                Console.Clear(); 

                // mostra o jogo da velha
                for (l = 0; l < 3; l++) {
                    for (c = 0; c < 3; c++) {
                        Console.Write(velha[l, c] + (c < 2 ? "|" : ""));
                      }
                        if (l < 2) {
                          Console.WriteLine("\n-----");
                          }
                  }

                Console.Write("\n\n");
        
                Console.Write("Jogador {0}, escolha uma posição: ", jogador);
                jogada = int.Parse(Console.ReadLine());

                simbolo = jogador == 1 ? 'X' : 'O'; // determina se é X ou O que irá aparecer

                valida = false; // inicializa como jogada inválida

                // verifica se a jogada é válida
                if (jogada==1 && velha[0,0]!='X' && velha[0, 0] != 'O')
                {
                    velha[0, 0] = simbolo; // coloca o símbolo na posição escolhida
                    valida = true; // jogada válida
                }
                if (jogada == 2 && velha[0, 1] != 'X' && velha[0, 1] != 'O')
                {
                    velha[0, 1] = simbolo;
                    valida = true;
                }
                if (jogada == 3 && velha[0, 2] != 'X' && velha[0, 2] != 'O')
                {
                    velha[0, 2] = simbolo;
                    valida = true;
                }
                if (jogada == 4 && velha[1, 0] != 'X' && velha[1, 0] != 'O')
                {
                    velha[1, 0] = simbolo;
                    valida = true;
                }
                if (jogada == 5 && velha[1, 1] != 'X' && velha[1, 1] != 'O')
                {
                    velha[1, 1] = simbolo;
                    valida = true;
                }
                if (jogada == 6 && velha[1, 2] != 'X' && velha[1, 2] != 'O')
                {
                    velha[1, 2] = simbolo;
                    valida = true;
                }
                if (jogada == 7 && velha[2, 0] != 'X' && velha[2, 0] != 'O')
                {
                    velha[2, 0] = simbolo;
                    valida = true;
                }
                if (jogada == 8 && velha[2, 1] != 'X' && velha[2, 1] != 'O')
                {
                    velha[2, 1] = simbolo;
                    valida = true;
                }
                if (jogada == 9 && velha[2, 2] != 'X' && velha[2, 2] != 'O')
                {
                    velha[2, 2] = simbolo;
                    valida = true;
                }

                Console.Clear(); 

                // mostra o jogo da velha
                for (l = 0; l < 3; l++)
                {
                    for (c = 0; c < 3; c++)
                    {
                        Console.Write(velha[l, c] + (c < 2 ? "|" : ""));
                    }
                    if (l < 2)
                    {
                        Console.WriteLine("\n-----");
                    }
                }

                if (valida)
                {
                    jogador = jogador == 1 ? 2 : 1; // troca de jogador
                    jogadas++;

                    // Verifica se houve vencedor
                    if (velha[0, 0] == velha[0, 1] && velha[0, 0] == velha[0, 2]) vencedor = true;
                    if (velha[1, 0] == velha[1, 1] && velha[1, 0] == velha[1, 2]) vencedor = true;
                    if (velha[2, 0] == velha[2, 1] && velha[2, 0] == velha[2, 2]) vencedor = true;
                    if (velha[0, 0] == velha[1, 0] && velha[0, 0] == velha[2, 0]) vencedor = true;
                    if (velha[0, 1] == velha[1, 1] && velha[0, 1] == velha[2, 1]) vencedor = true;
                    if (velha[0, 2] == velha[1, 2] && velha[0, 2] == velha[2, 2]) vencedor = true;
                    if (velha[0, 0] == velha[1, 1] && velha[0, 0] == velha[2, 2]) vencedor = true;
                    if (velha[0, 2] == velha[1, 1] && velha[0, 2] == velha[2, 0]) vencedor = true;

                    if (vencedor) Console.Write("\n\nJogador {0} venceu!!!", simbolo == 'X' ? 1 : 2);
                }
                else
                {
                    Console.Write("\n\nJogada inválida!!! Pressione uma tecla...");
                    Console.ReadKey();
                }

            } while (jogadas < 9 && !vencedor);

            if (!vencedor) Console.Write("\n\nVelha!!!");
  }
}
