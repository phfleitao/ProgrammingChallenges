#include <iostream>
#include<queue>
using namespace std;

int main()
{
    int n;
    int dobra[16] = {4,9,25,81,289,1089,4225,16641,66049,263169,1050625,4198401,16785409,67125249,268468225,1073807361} ;
    queue<int> resposta;
    scanf("%d", &n);
    while(n != -1){
        resposta.push(dobra[n]);
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
