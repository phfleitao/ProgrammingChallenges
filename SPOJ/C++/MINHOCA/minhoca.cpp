#include<iostream>
using namespace std;

int main(){
    int n, m, celula, soma = 0,bloco[100][100], result = 0;
    
    scanf("%d %d", &n, &m);
    for(int i=0;i<n;i++){
        for(int j=0;j<m;j++){
           scanf("%d", &celula);
           bloco[i][j] = celula;
           soma += celula; 
        }
        if(soma > result) result = soma;
        soma = 0;        
    }
    for(int j=0;j<m;j++){
        for(int i=0;i<n;i++){
           soma += bloco[i][j]; 
        }
        if(soma > result) result = soma;
        soma = 0;        
    }
    
    printf("%d\n",result);
    return 0;
}
