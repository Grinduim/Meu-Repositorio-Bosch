/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int *vetor,count,i;
    /* 1500 * o tamanho do inteiro*/
    // o malloc aloca  o vetor e insere o valor 0 em todas as posições
    vetor =  (int*)calloc(1500, sizeof(int));
    
    count =0;
    for(i = 0; i < 1500; i ++)
    {
        // validacao
        if(vetor[i] != 0)
        {
        printf("erro");
        }
        else
        {
            count +=1;;
        }
    }
    
    printf("\n Quantidade de valores alocados : %d\n\n",count);
    if(count ==1500)
    {
        // cada item do vetor recebe a sua key
        for(i = 0; i < 1500; i ++)
        {
            vetor[i] = i;
        }
    }
    
    printf("Os primeiros 10 valores : ");
    
    for(i = 0 ; i < 10; i ++)
    {
        printf("%6d", vetor[i]);
    }
    
    printf("\n\nOs ultimos 10 valores : ");
    
    /*size_t n = sizeof(vetor)/sizeof(vetor[1]);*/
    
    for(i = 1499 ; i > ( 1499- 10); i--)
    {
        printf("%6d",vetor[i]);
    }
    
    /*int number[16];
    
    size_t n = sizeof(number)/sizeof(number[0]);
    printf("Total elements the array can hold is: %d\n",n);*/
    
    return 0;
    
}
