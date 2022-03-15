#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"Portuguese");
    int valor1, valor2, soma;

    printf("Escreva um valor: ");
    scanf("%d",&valor1);
    printf("\nEscreva outro valor: ");
    scanf ("%d",&valor2);

    soma = valor1 + valor2;
    printf("\n\nA soma dos dois valores é igual a %d\n",soma);
    return 0;
}