#include<iostream>
#include<deque>
using namespace std;

int main(){
    int n, m, temp = 0, maior = 0, tam;
    deque<long> respostas;

    scanf("%d",&n);
    while(n != 0){
        for(int i=0;i<n;i++){
            scanf("%d", &m);
            temp += m;
            if(temp < 0) temp = 0;
            else{
                if(temp > maior)
                    maior = temp;
            }
        }
        respostas.push_back(maior);
        temp = maior = 0;
        scanf("%d",&n);
    }
    tam = respostas.size();
    for (int i = 0;i < tam ; i++){
        if(respostas[i]>0)
            cout<<"The maximum winning streak is "<<respostas[i]<<"."<<endl;
        else
            cout<<"Losing streak."<<endl;
    }
return 0;
}
