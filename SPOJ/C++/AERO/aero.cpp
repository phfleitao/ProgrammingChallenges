#include<iostream>

int main()
{
    int aero[100];
    int a, v, x, y, maior = 0, k = 0;

    scanf("%d %d", &a, &v);
    while(a != 0){

        for(int i=0;i<a;i++){
            aero[i] = 0;
        }

        for(int i=0;i<v;i++){
            scanf("%d %d", &x, &y);
            if(++aero[x - 1] > maior) maior++;
            if(++aero[y - 1] > maior) maior++;
        }

        printf("Teste %d\n", ++k);
        for(int i=0; i<a; i++){
            if(aero[i] == maior) printf("%d ", i + 1);
        }
        printf("\n");

        scanf("%d %d", &a, &v);
        maior = 0;
    }
    return 0;
}