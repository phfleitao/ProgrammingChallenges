#include <iostream>
#include <string>
#include <cstring>
#include <cstdlib>
#include <algorithm>
#include <deque>
#include <list>
#include <map>
#define TAM 1000000
using namespace std;

const long int MAX_INPUT_SIZE=25000000;
const char WORD_SEP[3]={' ','\n','\t'};
const char LINE_SEP[3]={'\n','\n','\n'};
char in[MAX_INPUT_SIZE];
char* inipos = in;
char* currpos = in;
long int fimPosIn;

void leEntrada() {
    fimPosIn = fread(in, 1, MAX_INPUT_SIZE, stdin)-1;
    while(in[fimPosIn]=='\n' || in[fimPosIn]=='\t' || in[fimPosIn]==' ') fimPosIn--;
    in[++fimPosIn]='\0';
}

bool fim(){return currpos - inipos >= fimPosIn;}

char* _getNextString(const char* seps){
    while(!fim() && (*currpos==' ' || *currpos=='\n' || *currpos=='\t'))currpos++;
    char* temp=currpos;
    while(!fim() && (*currpos!=seps[0]  && *currpos!=seps[1] && *currpos!=seps[2]))currpos++;
    *currpos++='\0';
    return temp;
}

char* getNextWord(){return _getNextString(WORD_SEP);}
char* getNextLine(){return _getNextString(LINE_SEP);}
long int getNextInt() {return strtol(currpos, &currpos, 10);}
double getNextDouble() {return strtod(currpos, &currpos);}


int main()
{
    int n, soma = 0, valor, flag = 0, result = 9999, k=0;

    leEntrada();

    while(!fim()){
        n = getNextInt();
        if(n == 1 || n == 2){
            if(n == 1)
               valor = getNextInt();
            else{
               valor = getNextInt();
               valor = getNextInt();
            }
            result = 0;
        }
        else{
            for(int i=0;i<n;i++){
                valor = getNextInt();
                if(soma != valor && flag == 0)
                    soma += valor;
                else{
                    if(soma == valor && flag == 0){
                        result = valor;
                        flag = 1;
                    }
                }
            }
        }
        if(result == 9999){
            printf("Instancia %d\n", ++k);
            printf("nao achei\n\n");
        }
        else{
            printf("Instancia %d\n", ++k);
            printf("%d\n\n", result);
        }
        soma = 0;
        flag = 0;
        result = 9999;
    }
    return 0;
}
