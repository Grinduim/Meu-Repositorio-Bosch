#include <stdio.h>
#include <stdlib.h>
#define col 4
#define lin 4


int main ()
{
  char gabarito[col];
  char alunos[col][lin];
	char respostas[col][lin];
  int i,j;
 
  
  for(i = 0; i < col ; i ++)
  {
      char aux;
      printf("Preencha a resposta da questão numero %d do gabarito ",i+1);
        scanf(" %c",&aux);
       if(aux == 'a' || aux == 'b' || aux == 'c' ||  aux == 'd' || aux == 'A' || aux == 'B' || aux == 'C' ||  aux == 'D')
          {
            gabarito[i] = aux;
						continue;
          }
          else
          {
              printf(" A resposta que você inseriu está errado...Tente novamente \n\n");
              i--;
							continue;
          }
  }
  
  for(i = 0; i < col; i ++)
  {
      
      for(j = 0 ; j < lin ; j++)
      {
          char aux;
          printf("\nResposta do aluno numero %d para a a questão %d :  ", i+1 , j+1);
            scanf(" %c",&aux);
          if(aux == 'a' || aux == 'b' || aux == 'c' ||  aux == 'd' || aux == 'A' || aux == 'B' || aux == 'C' ||  aux == 'D')
					{

            alunos[i][j] = aux;
						if(gabarito[j] == alunos[i][j])
						{
							respostas[i][j] = 'V';
						}
						else{
								respostas[i][j] = 'F';
						}
            continue;
          }
          else
          {
		
              printf("\n A resposta que você inseriu está errado...Tente novamente \n\n");
              j --;
              continue;
          }
      }
  }
  
		printf("\nResultado final: [V] = Verdadeiro e [F] = Falso \n\n");
	 for(i = 0; i < col; i ++)
  {
      
      for(j = 0 ; j < lin ; j++)
      {
				printf("\nAluno %d Questão %d : %c", i+1, j+1, respostas[i][j]);
			}
			printf("\n\n");
	}
  return 0;
}
