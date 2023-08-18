#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    int n; // Número máximo para sorteio
    int aposta; // Aposta do usuário
    int resultado[5]; // Números sorteados para cada faixa de prêmio
    int i;
    int ganhou = 0; // Variável para verificar se o usuário ganhou algum prêmio

    // Inicializa a geração de números aleatórios com base no tempo atual
    srand(time(0));

    printf("Bem-vindo à Loteria!\n");
    printf("Digite o número máximo para o sorteio: ");
    scanf("%d", &n);

    // Gera números aleatórios para cada faixa de prêmio
    for (i = 0; i < 5; i++)
    {
        resultado[i] = rand() % n + 1;
    }

    printf("Faixas de prêmio:\n");
    for (i = 0; i < 5; i++)
    {
        printf("Faixa %d: %d\n", i + 1, resultado[i]);
    }

    printf("Faça sua aposta: ");
    scanf("%d", &aposta);

    // Verifica se a aposta está em alguma das faixas de prêmio
    for (i = 0; i < 5; i++)
    {
        if (aposta == resultado[i])
        {
            printf("Parabéns! Você ganhou na faixa %d!\n", i + 1);
            ganhou = 1;
            break;
        }
    }

    if (!ganhou)
    {
        printf("Que pena! Você não ganhou em nenhuma faixa de prêmio.\n");
    }

    return 0;
}
