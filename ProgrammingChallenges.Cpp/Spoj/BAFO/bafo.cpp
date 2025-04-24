#include <iostream>
#include<string>
#include<queue>

using namespace std;

int main()
{
    int n, a, b, somaa = 0, somab = 0;
    queue<string> resposta;
    scanf("%d", &n);
    while(n != 0){
        for(int i=0; i < n; i++){
            scanf("%d %d", &a, &b);
            somaa += a;
            somab += b;
        }
        if(somaa > somab) resposta.push("Aldo");
        else resposta.push("Beto");
        somaa = 0;
        somab = 0;
        scanf("%d", &n);
    }
    n = 0;
    cout<<"\n";
    while(!resposta.empty()){
        printf("Teste %d\n",++n);
        cout<<resposta.front()<<"\n\n";
        resposta.pop();
	}
    return 0;
}
