#include<iostream>
#include<queue>

using namespace std;

int f91(int);
int main()
{
    int n;
    queue<int> resp1, resp2;
    scanf("%d", &n);
    while(n != 0){
        resp1.push(n);
        n = f91(n);
        resp2.push(n);
        scanf("%d", &n);
    }
    cout<<"\n";
    while(!resp1.empty()){
        printf("f91(%d) = %d\n",resp1.front(), resp2.front());
        resp1.pop();
        resp2.pop();
    }
    return 0;
}

int f91(int n){
    if(n <= 100) n = f91(f91(n+11));
    if(n >= 101) n -= 10;
    return n;
}
