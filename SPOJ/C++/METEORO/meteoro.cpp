#include<iostream>
#include<cstdlib>
#include<queue>
using namespace std;

int main(){
    int x1, y1, x2, y2, n, cont = 0, m1, m2;
    queue<int> resposta;
    scanf("%d %d %d %d", &x1, &y1, &x2, &y2);
    while(x1 != 0 && y1 != 0 && x2 != 0 && y2 != 0){
        scanf("%d", &n);
        for(int i=0; i<n; i++){
            scanf("%d %d", &m1, &m2);
            if((m1 >= x1)&&(m1 <= x2)&&(m2 <= y1)&&(m2 >= y2)) cont++;
        }
        resposta.push(cont);
        cont = 0;
        scanf("%d %d %d %d", &x1, &y1, &x2, &y2);
    }
    while(!resposta.empty()){
        cout<<"Teste "<<++cont<<"\n";
        cout<<resposta.front()<<"\n\n";
        resposta.pop();
    }
	return 0;
}