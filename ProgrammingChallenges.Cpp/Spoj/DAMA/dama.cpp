#include<iostream>
#include<cmath>
using namespace std;

int main(){
    int x1, y1, x2, y2;
    scanf("%d %d %d %d", &x1, &y1, &x2, &y2);
    while(x1 + x2 + y1 + y2 != 0){
        if(x1 == x2 && y1 == y2)
              printf("0\n");
        else if((x1 == x2) || (y1 == y2) || (fabs(x2 - x1) == fabs(y2 - y1)))
             printf("1\n");
        else
             printf("2\n");
        scanf("%d %d %d %d", &x1, &y1, &x2, &y2);    
    }
    return 0;
}