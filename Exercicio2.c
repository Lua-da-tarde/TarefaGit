#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"");
    int raio, area;

    printf("Insira o valor do raio: ");
    scanf("%d",&raio);

    area = 3.14159 * (raio*raio);

    printf("\nO valor da área do círculo é %4.d\n\n",area);
    return 0;
}