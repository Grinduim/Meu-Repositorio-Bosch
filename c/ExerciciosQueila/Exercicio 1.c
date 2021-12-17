#include <stdio.h>
#include <stdlib.h>

/*Uma empresa decide dar um aumento para os seus Funcionarios de acordo com a tabela.....*/

int
main ()
{
  double salario;
  float tempo;

  printf ("Insira o Salario Atual do Funcionario \n");
  scanf ("%lf", &salario);
  printf ("\nQuanto tempo de casa ?\n");
  scanf ("%f", &tempo);

  printf ("\nCalculando...");

  if (salario < 500)
    {
      salario = salario * 1.25;
    }
  else if (salario < 1000)
    {
      salario = salario * 1.20;
    }
  else if (salario < 1500)
    {
      salario = salario * 1.15;
    }
  else if (salario < 2000)
    {
      salario = salario * 1.10;
    }

  if (tempo >= 1 && tempo <= 3)
    {
      salario += 100;
    }
  else if (tempo <= 6)
    salario += 200;
  else if (tempo <= 10)
    salario += 300;
  else if (tempo > 10)
    salario += 500;

  printf ("\nO salario atual do Funcionario C) de : %.2lf", salario);
}
