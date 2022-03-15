#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"");
    int cp1, qnt1, cp2, qnt2;
    float valor1, valor2, total;

    printf("Digite o código da primeira peça: ");
    scanf("%d",&cp1);
    printf("\nDigite a quantidade da peça 1: ");
    scanf("%d",&qnt1);
    printf("\nDigie o valor unitário da peça 1: ");
    scanf("%f",&valor1);
    printf("\nDigite o código da segunda peça: ");
    scanf("%d",&cp2);
    printf("\nDigite a quantidade da peça 2: ");
    scanf("%d",&qnt2);
    printf("\nDigie o valor unitário da peça 2: ");
    scanf("%f",&valor2);

    total = (qnt1*valor1)+(qnt2*valor2);

    printf("\n\nO código e valor da primeira peça são %d e %f \nO código e valor da segunda peça são %d e %f \n",cp1,valor1,cp2,valor2);
    printf("O valor da compra é %f \n",total);
    return 0;
}