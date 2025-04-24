#include<iostream>
#include<cstdlib>
#include<string>
#define MAX 1000000
using namespace std;

struct alunos{
	string nome;
	int problemas;
};

int main(){
    unsigned long long int j = 0, cont = 0;
    int qtd_alunos, num = 0, tam =0;
	alunos aluno[100], reprovado[MAX];
	string str;

    while(scanf("%d",&qtd_alunos)!=EOF){
        cin.ignore();
        reprovado[j].problemas = 11;
        for(int i=0; i<qtd_alunos;i++){
            getline(cin, str);
            tam = str.length();
            num = atoi(&str[tam - 1]);
            tam-=2;
            if(num == 0){
                if(str[tam] == '1'){
                    num = 10;
                    tam--;
                }
            }
            aluno[i].nome = str.substr(0,tam);
            aluno[i].problemas = num;

            if(aluno[i].problemas < reprovado[j].problemas){
                reprovado[j].nome = aluno[i].nome;
                reprovado[j].problemas = aluno[i].problemas;
            }
            else if(aluno[i].problemas == reprovado[j].problemas){
                if(aluno[i].nome > reprovado[j].nome){
                    reprovado[j].nome = aluno[i].nome;
                    reprovado[j].problemas = aluno[i].problemas;
                }
            }
        }
        j++;
        cont++;
	}

    for(unsigned long long int i=0;i<cont;i++){
        cout<<"\n"<<"Instancia "<<i + 1<<"\n";
        cout<<reprovado[i].nome<<"\n";
    }
    return 0;
}
