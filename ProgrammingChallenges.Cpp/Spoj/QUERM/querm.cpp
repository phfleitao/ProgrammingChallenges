#include<iostream>
#include<cstdlib>
#include<cstring>
#include<deque>
#include<queue>

using namespace std;

int verificaIngressos();

deque<int> vencedor;
int main(){
	int n, ingresso, j = 0;
	queue<int> resposta;

    scanf("%d", &n);
	while(n != 0){
		for(int i = 0; i < n; i++){
            scanf("%d", &ingresso);
            vencedor.push_back(ingresso);
		}
        resposta.push(verificaIngressos());
        vencedor.clear();
		scanf("%d", &n);
	}
	while(!resposta.empty()){
        cout<<"\nTeste "<<++j<<"\n"<<resposta.front()<<"\n";
        resposta.pop();
	}
	return 0;
}

int verificaIngressos(){
    int tam = vencedor.size();
    for(int i=0;i < tam;i++){
        if(vencedor[i] == i+1)
            return vencedor[i];
    }
    return -1;
}

