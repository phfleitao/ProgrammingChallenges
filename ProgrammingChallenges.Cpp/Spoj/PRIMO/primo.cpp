#include <iostream>
#include<cmath>
#include <string>
using namespace std;

string testaNum(long int);
int main()
{
    long int n;
    string resp;
    scanf("%ld", &n);
    n = fabs(n);
    resp = testaNum(n);
    cout<<"\n"<<resp;
    return 0;
}

string testaNum(long int num){
   long int i;
   if(num == 0 || num == 1) return "nao";
   for(i = 2; i < num; i++){
        if(num % i == 0) return "nao";
   }
   return "sim";
}
