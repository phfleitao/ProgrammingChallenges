#include <iostream>
using namespace std;

int fat(int);
int main()
{
    int n;
    scanf("%d", &n);
    n = fat(n);
    cout<<"\n"<<n;
    return 0;
}

int fat(int n){
   if(n==0)
      return 1;
   else
      return n * fat(n - 1);
}