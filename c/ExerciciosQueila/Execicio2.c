#include <stdio.h>
#include <stdlib.h>

/*Algorimo que converte medidas de velocidade.....*/
int
menu ()
{
  int opc;
  printf
    ("\n      --- MENU --- \n [1] - Conveter de KM/h para m/s\n [2] - Conveter de m/s para KM/h \n [3] - Sair do programa\n R: ");
  scanf ("%d", &opc);
  return opc;
}

void km ()
{
  float medida;
  printf ("Insira a medida para converter Km/H em M/s\n");
  scanf ("%f", &medida);
  printf ("\n\n Convertendo %.2fK Km/H  dC! %.2f M/S\n", medida,
	  medida / 3.6);
}

void ms ()
{
  float medida;
  printf ("Insira a medida para converter M/s em Km/H\n");
  scanf ("%f", &medida);
  printf ("\nConvertendo %.2fK M/S  dC! %.2f Km/H\n", medida, medida * 3.6);

}

void
main ()
{
  printf (" --- Conversor de medida --- ");

  while (1)
    {
      int opc = menu ();

      if (opc == 1)
      {
	    km ();
      }

      else if (opc == 2)
      {
	    ms ();
      }

      else if (opc == 3)
      {
	    exit (1);
      }

      else
      {
	    printf ("\n\nNC#o entendi, pode tentar novamente por favor \n?");
      }
    }


}
