#include<iostream>
#include<queue>

using namespace std;

int main()
{
    int n, p, q, j = 0;
    queue<string> resposta;
    string a, b;
    resposta.push("*");
    scanf("%d",&n);
    while(n != 0){
        cin.ignore();
        getline(cin, a);
        getline(cin, b);
        for(int i = 0; i < n; i++){
            scanf("%d %d",&p,&q);
            if((p + q) %2 == 0) resposta.push(a);
            else resposta.push(b);
        }
        scanf("%d",&n);
        if(n != 0) resposta.push("*");
    }
    while(!resposta.empty()){
		if(resposta.front() == "*"){
            printf("\nTeste %d\n", ++j);
            resposta.pop();
		}
		else{
            cout<<resposta.front()<<"\n";
            resposta.pop();
		}
    }
    return 0;
}
