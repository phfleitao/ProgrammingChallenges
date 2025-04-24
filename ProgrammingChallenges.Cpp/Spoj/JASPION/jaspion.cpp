#include<iostream>
#include<string>
#include<cstring>
#include<deque>
using namespace std;

int search(deque<string> &, string);

int main()
{
    int t, m, n, r, tam;
    string strp, strt, strm, str_resp;
    char str_aux[85], *tok;
    deque<string> palavra, traducao, resposta;
    str_resp.clear();
    scanf("%d", &t);
    for(int i=0;i<t;i++){
        scanf("%d %d", &m, &n);
        cin.ignore();
        for(int j=0;j<m;j++){
            getline(cin, strp);
            getline(cin, strt);
            palavra.push_back(strp);
            traducao.push_back(strt);
        }
        for(int j=0;j<n;j++){
            memset(str_aux, 85, ' ');
            cin.getline(str_aux, 85);
            tok = strtok(str_aux, " ");
            while(tok != NULL){
                strm = tok;
                r = search(palavra, strm);
                if(r == -1)
                    str_resp += strm+" ";
                else
                    str_resp += traducao[r]+" ";
                tok = strtok(NULL, " ");
            }
            resposta.push_back(str_resp);
            str_resp.clear();
        }
        palavra.clear();
        traducao.clear();
    }
    tam = resposta.size();
    for(int i=0;i<tam;i++)
        cout<<resposta[i]<<endl;
    return 0;
}

int search(deque<string> &d, string p){
    int tam = d.size();
    for(int i=0;i<tam;i++){
        if(p.compare(d[i])==0) return i;
    }
    return -1;
}
