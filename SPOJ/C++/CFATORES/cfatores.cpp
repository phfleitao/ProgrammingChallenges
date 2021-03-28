#include <iostream>
#include <algorithm>
#include <deque>
#define TAM 1000000
using namespace std;
static int p[1000000];

void eratosthenes();

int main()
{
    deque<long long int> fatores;
    deque<long long int>::iterator it;
    long long int num,valor,i=2;

    eratosthenes();

    scanf("%lld", &num);

    while(num != 0){
        valor = num;
        while(valor>1){
            if(p[i] == 1){
                if(valor%i==0){
                    valor /= i;
                    fatores.push_back(i);
                    i=2;
                }
                else
                    i++;
            }
            else
                i++;

        }
        sort(fatores.begin(), fatores.end());
        it = unique(fatores.begin(), fatores.end());
        fatores.resize(it - fatores.begin());
        printf("%lld : %d\n", num, fatores.size());
        i=0;
        fatores.clear();
        scanf("%lld", &num);
    }
    return 0;
}

void eratosthenes(){
  long long int i,j;
  for(i=0;i<TAM;i++)
    p[i] = 1;

  p[0]=0;
  p[1]=0;
  for(i=2;i<TAM;i++)
    if(p[i])
      for(j=i*i;j<TAM;j+=i)
        p[j]=0;
}

