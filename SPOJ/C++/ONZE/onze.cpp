#include<iostream>
#include<cstdlib>
#include<cstring>
#include<deque>
#define MAX 1005
using namespace std;

int convertToInt(char);
void preencheNum(deque<int> &, char []);
bool eMultiplo(deque<int> &);

int main()
{
    char valor[MAX];
    bool teste = false;
    deque<int> num;

    scanf("%s", valor);
    while(strcmp(valor,"0") != 0){
        preencheNum(num, valor);
        teste = eMultiplo(num);
        if(teste)
            printf("%s is a multiple of 11.\n", valor);
        else
            printf("%s is not a multiple of 11.\n", valor);
        memset(valor, 1004, ' ');
        num.clear();
        scanf("%s", valor);
    }
    return 0;
}

int convertToInt(char c){
    switch(c){
        case '0': return 0; break;
        case '1': return 1; break;
        case '2': return 2; break;
        case '3': return 3; break;
        case '4': return 4; break;
        case '5': return 5; break;
        case '6': return 6; break;
        case '7': return 7; break;
        case '8': return 8; break;
        case '9': return 9; break;
        default: return -1; break;
    }
}

void preencheNum(deque<int> &d, char valor[]){
    int tam = strlen(valor);
    for(int i=0;i<tam;i++){
        d.push_back(convertToInt(valor[i]));
    }
}

bool eMultiplo(deque<int> &d){
    int tam = d.size(), soma = 0;
    for(int i=0;i<tam;i++){
        if(i%2==0)
            soma += d[i];
        else
            soma -= d[i];
    }
    if(soma%11 == 0) return true;
    else return false;
}
