#include<iostream>
#include<cstdlib>
#include<string>
#include<queue>
using namespace std;

int main(){
    int k, n, m, x, y;
    queue<string> resposta;

    scanf("%d", &k);
    while(k != 0){
        scanf("%d %d", &n, &m);
        for(int i=0; i<k; i++){
            scanf("%d %d", &x, &y);
            if((x<n)&&(y<m)) resposta.push("SO");
            else if((x<n)&&(y>m)) resposta.push("NO");
            else if((x>n)&&(y>m)) resposta.push("NE");
            else if((x>n)&&(y<m)) resposta.push("SE");
            else resposta.push("divisa");
        }
        scanf("%d", &k);
    }
    while(!resposta.empty()){
        cout<<resposta.front()<<"\n";
        resposta.pop();
    }
	return 0;
}

