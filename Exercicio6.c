#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"");
    float a, b, c, areat, areac, areatrap, areaq, arearet;

    printf("Insira um valor: ");
    scanf("%f",&a);
    printf("\nInsira outro valor: ");
    scanf("%f",&b);
    printf("\nInsira um últmo valor: ");
    scanf("%f",&c);

    areat = a*c/2;
    areac = 3.14159 * (c * c);
    areatrap = ((a+b)*c)/2;
    areaq = b * b;
    arearet = a * b;

    printf("\n\nA área do triângulo é igual a %2.f \n A área do círculo é igual a %2.f \n A área do trapézio é igual a %2.f \n A área do quadrado é igual a %2.f \n A área do retângulo é igual a %2.f \n",areat,areac,areatrap,areaq,arearet);
    return 0;
}