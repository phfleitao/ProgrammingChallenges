#include<iostream>

int main()
{    
    int a,b,c,d;
    int valor;
    int teste = 0;
    while(scanf("%d",&valor) != EOF && valor > 0)
    {
      a = valor / 50; 
      valor %= 50;
      b = valor / 10;
      valor %= 10;
      c = valor / 5;
      valor %= 5;
      d = valor;
      printf("Teste %d\n %d %d %d %d\n",++teste,a,b,c,d);                  
    }
     return 0;
}
