#include <iostream>
#include <stdio.h> // strandart in out
#include <stdlib.h>// strandart library 
#include <math.h> // funções math
#include <locale.h> // title case
#define LIN 6 
#define COL 6
#include <time.h>

void ClearTabuleiro(char tabuleiro[LIN][COL])
{
	
	for(int aux = 0; aux < LIN; aux++)
	{
		for(int aux2 = 0; aux2 < COL; aux2++)
		{
			tabuleiro[aux][aux2] = ' ';
		}
	}
}

void ImprimirTabuleiro(char tabuleiro[LIN][COL])
	{
		
 printf("   A     B    C    D    E    F ");
		for(int aux = 0; aux < LIN; aux++)
		{
			printf("\n --------------------------------\n");
			printf("%d", aux);
			for(int aux2 = 0; aux2 < COL; aux2++)
			{
				printf("| %c |", tabuleiro[aux][aux2]);
			}
		}
		printf("\n --------------------------------\n");
	
	}

int main() {
	

	srand(time(NULL));
	int ColunaRobo;
	int LinhaRobo;  // num aleatorio
	char Robo[COL][LIN];
	
	int linha;
	char coluna[1];
	char Jogador[COL][LIN];
	
	setlocale(LC_ALL, "Portuguese"); 
	char tabuleiro[LIN][COL];
	ClearTabuleiro(tabuleiro);
	
	char alpha[6]; //  colunas
	alpha[0] = 'A';
	alpha[1] = 'B';
	alpha[2] = 'C';
	alpha[3] = 'D';
	alpha[4] = 'E';
	alpha[5] = 'F';
	
	for(int aux = 0; aux < 6; aux++)
	{
		 ColunaRobo = rand()%6; 
		LinhaRobo = rand()%6; 
		
		Robo[LinhaRobo][ColunaRobo] = 'N'; // gera psoição aleatoria de navio
	
	}
	
	ImprimirTabuleiro(tabuleiro); 
	for(int aux = 0; aux < 6 ; aux++)
	{
		printf("\nInsira a posição do %dº navio", aux+1);
		printf("\nLinha:");
			scanf("%d", &linha);
		printf("\nColuna:");
			scanf("%d", &coluna[1]); 
		// inserir  navio jogador
			
		if(coluna[1] == 'A')
		{
			
		}
		}
	}