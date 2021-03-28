#include<iostream>
#include<deque>
using namespace std;
const int MAX_ALUNOS = 1000;
int main()
{
  int i, maiorMedia = 0, n;
  int turma=1, tam;
  deque<int> resposta;
  struct
  {
    int codigo, media;
  } alunos[MAX_ALUNOS];
  cin >> n;
  while (n > 0)
  {
      resposta.push_back(-1);
      for (i = 0; i < n; i++){
         cin >> alunos[i].codigo >> alunos[i].media;
         if(alunos[i].media > maiorMedia) maiorMedia = alunos[i].media;
      }
      for (i = 0; i < n; i++){
         if (alunos[i].media == maiorMedia)
            resposta.push_back(alunos[i].codigo);
      }
      maiorMedia = 0;
      cin >> n;
  }
  tam = resposta.size();
  for(int i = 0; i < tam; i++){
      if(resposta[i] == -1)
          cout << "Turma " << turma++ << "\n";
      else{
          cout << resposta[i];
          if((resposta[i+1] != -1) && ((i + 1) < tam)) cout<<" ";
          else cout<<"\n\n";
      }
  }
  return 0;
}
