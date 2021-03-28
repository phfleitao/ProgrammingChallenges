#include<iostream>
#include<queue>
#include<algorithm>
#include<deque>
using namespace std;

int main(){
    int a, d, atk, def, m_atk = 999999;
    deque<int> m_def;
    queue<char> resposta;

    scanf("%d %d", &a, &d);
    while(a != 0 && d != 0){
        for(int i=0;i<a;i++){
            scanf("%d", &atk);
            if(atk < m_atk) m_atk = atk;
        }
        for(int i=0;i<d;i++){
            scanf("%d", &def);
            m_def.push_back(def);
        }
        sort(m_def.begin(),m_def.end());
        if((m_atk >= m_def[1])||((m_atk == m_def[1])&&(m_atk == m_def[0])))
            resposta.push('N');
        else
            resposta.push('Y');
        m_def.clear();
        m_atk = 999999;
        scanf("%d %d", &a, &d);
    }
    while(!resposta.empty()){
        cout<<resposta.front()<<"\n";
        resposta.pop();
    }
}
