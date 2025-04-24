#include<iostream>
#include<queue>

using namespace std;

int main()
{
    int n, m, contpar = 0, contimpar = 0, temp;
    queue<int> resposta;
    scanf("%d",&n);
    while(n != 0){
        for(int i = 0; i < n*2; i++){
            scanf("%d", &m);
            if(m%2 == 0) contpar++;
            else contimpar++;
        }
        if(contpar >= contimpar){
            temp = contpar - contimpar;
            temp /= 2;
        }
        else{
            temp = contimpar - contpar;
            temp /= 2;
        }
        resposta.push(temp);
        contimpar = contpar = 0;
        scanf("%d",&n);
    }
    cout<<"\n";
    while(!resposta.empty()){
		cout<<resposta.front()<<"\n";
        resposta.pop();
    }
    return 0;
}
