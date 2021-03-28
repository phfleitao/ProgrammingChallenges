#include<iostream>
#include<string>
#include<sstream>
#include<deque>
using namespace std;

bool ePrimo(int);

int main()
{
    string nome;
    int valor_ch, tam, soma = 0;
    deque<int> resposta;
    bool teste = false;

    while(1){
        cin>>nome;
        if(cin.eof()) break;
        tam = nome.length();
        for(int i=0;i<tam;i++){
            valor_ch = (int)nome[i];
            if((valor_ch >= 97)&&(valor_ch <= 122))
                soma += (valor_ch - 96);
            else
                soma += (valor_ch - 38);
        }
        teste = ePrimo(soma);
        if(teste)
            resposta.push_back(1);
        else
            resposta.push_back(0);
        teste = false;
        soma = 0;
        cin.ignore();
    }
    tam = resposta.size();
    for(int i = 0; i < tam; i++){
        if(resposta[i] == 1)
            cout<<"It is a prime word."<<endl;
        else
            cout<<"It is not a prime word."<<endl;
    }
    return 0;
}

bool ePrimo(int num){
   if(num == 0) return false;
   if(num == 1) return true;
   for(int i = 2; i < num; i++){
        if(num % i == 0) return false;
   }
   return true;
}

