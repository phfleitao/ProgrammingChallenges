#include<iostream>
#include<string>
#include<deque>
using namespace std;

bool verificaSudoku(int [][9]);

int main()
{
    int n, cont = 0, val[9][9];
    bool teste = false;
    deque<string> resp;

    scanf("%d", &n);
    while(n != EOF && n != 0){
        while(n>0){
            for(int i=0;i<9;i++){
                for(int j=0;j<9;j++){
                    scanf("%d", &val[i][j]);
                }
            }
            teste = verificaSudoku(val);
            if(teste) resp.push_back("SIM");
            else resp.push_back("NAO");
            n--;
        }
        scanf("%d", &n);
    }
    for(int i=0;i<resp.size();i++){
        cout<<"Instancia "<<++cont<<endl;
        cout<<resp[i]<<"\n"<<endl;
    }
    return 0;
}

bool verificaSudoku(int val[][9]){
    int min1 = 0, min2 = 0, max1 = 3, max2 = 3, n_comp = 8, i_aux, j_aux;
    for(int i=0;i<9;i++){
        for(int j=0;j<9;j++){
            for(int k=0;k<9;k++){
                if(((j != k)&&(val[i][j]==val[i][k]))||((i != k)&(val[i][j]==val[k][j]))) return false;
            }
        }
    }

    for(int b=0;b<9;b++){
        for(int i=min1;i<max1;i++){
            for(int j=min2;j<max2;j++){
                i_aux = i;
                j_aux = j;
                for(int k=0;k<n_comp;k++){
                    if(j_aux< max2 - 1)
                        j_aux++;
                    else{
                        i_aux++;
                        j_aux = min2;
                    }
                    if(val[i][j] == val[i_aux][j_aux]) return false;
                }
                n_comp--;
            }
        }
        n_comp = 8;
        if(max2 == 9){
            min1 += 3;
            min2 = 0;
            max1 += 3;
            max2 = 3;
        }
        else{
            min2 += 3;
            max2 += 3;
        }
    }
    return true;
}
