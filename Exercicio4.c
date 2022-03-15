#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL,"");
    int func, hr;
    float recebe, salario;

    printf("Insira o seu número: ");
    scanf("%d",&func);
    printf("\nQuantas horas você trabalhou esse mês? ");
    scanf("%d",&hr);
    print("\nQuanto você recebe por hora: ");
    scanf("%f",&recebe);

    salario = recebe*hr;
    printf("\n\nNÚMERO: %d \nSALÁRIO: %2.f\n",func,salario);
    return 0;
}