#include<iostream>
#include<queue>
#include<deque>
#include<algorithm>
using namespace std;

int main()
{
    int n, m, j = 0;
    queue<int> resposta;
    deque<int> votos;

    scanf("%d", &n);

    while(n != 0){
        for(int i=0; i<n; i++){
            scanf("%d", &m);
            votos.push_back(m);
        }
        for(int i=0; i<((n*n)-n); i++){
            scanf("%d", &m);
            votos[j] += m;
            j++;
            if(j == n) j = 0;
        }
        sort(votos.begin(), votos.end());
        resposta.push(votos[n-1]);
        votos.clear();
        j=0;
        scanf("%d", &n);
    }
    while(!resposta.empty()){
        cout<<resposta.front()<<"\n";
        resposta.pop();
    }
    return 0;
}
