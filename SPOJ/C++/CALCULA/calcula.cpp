#include <iostream>
#include <cstdlib>
#include <string>
#include <cstring>
#include <queue>
#include <stack>
using namespace std;

int main()
{
    int n, num = 0, i = 0;
    queue<int> resposta;
    stack<char> sinal, valor;
    string str;

    while(scanf("%d",&n)!= EOF && n != 0){
        cin.ignore();
        getline(cin, str);
        for(int i= str.length() - 1;i >= 0;i--){
            if(str[i] != '+' && str[i] != '-'){
                num = atoi(&str[i]);
            }
            else{
                valor.push(num);
                sinal.push(str[i]);
                num = 0;
            }
        }
        while(!valor.empty()){
            if(sinal.top() == '+'){
                num += valor.top();
                valor.pop();
                sinal.pop();
            }
            else{
                num -= valor.top();
                valor.pop();
                sinal.pop();
            }
        }
        resposta.push(num);
        num = 0;
    }
    i = 0;
	while(!resposta.empty()){
        cout<<"\nTeste "<<++i<<"\n"<<resposta.front()<<"\n";
        resposta.pop();
	}
    return 0;
}
