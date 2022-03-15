#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"");
    int a, b, c, d, dif;

    printf("Insira um valor: ");
    scanf("%d",&a);
    printf("\nInsira um valor: ");
    scanf("%d",&b);
    printf("\nInsira um valor: ");
    scanf("%d",&c);
    printf("\nInsira um valor: ");
    scanf("%d",&d);

    dif = a*b - c*d;
    printf("\n\nA diferença é igual a %d",dif);
    return 0;
}