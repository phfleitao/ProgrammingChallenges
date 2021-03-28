#include<iostream>
#include<queue>
using namespace std;

void mesa(long long int);

queue<long long int> resposta;
int main()
{
    long long int n;
    scanf("%lld", &n);
    while(n != 0){
        mesa(n);
        scanf("%lld", &n);
    }
    cout<<"\n";
    while(!resposta.empty()){
        cout<<resposta.front()<<"\n";
        resposta.pop();
    }
    return 0;
}

void mesa(long long int n){
    long long int soma = 0;
    while(n >= 1){
        soma += n*n;
        n--;
    }
    resposta.push(soma);
}
