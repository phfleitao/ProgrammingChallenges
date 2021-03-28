#include <iostream>
#include <algorithm>
#include<deque>
using namespace std;

int somavotos();

deque<int> eleitor;
int main()
{
    int n, m, temp;
    scanf("%d", &n);
    for(int i=0;i<n;i++){
        scanf("%d", &m);
        eleitor.push_back(m);
    }
    temp = somavotos();
    cout<<"\n"<<temp<<"\n";
    return 0;
}

int somavotos(){
    int tam = eleitor.size(), cont = 0, last = 0, maior, vencedor;
    sort(eleitor.begin(), eleitor.end());
    last = eleitor[0];
    cont = 1;
    maior = 1;
    vencedor = eleitor[0];
    for(int i=1; i<tam; i++){
        if(eleitor[i] == last) cont++;
        else{
            if(cont > maior){
                maior = cont;
                vencedor = last;
            }
                cont = 1;
                last = eleitor[i];
        }
    }
    if(cont > maior){
        maior = cont;
        vencedor = last;
    }
    cont = 1;
    return vencedor;
}
