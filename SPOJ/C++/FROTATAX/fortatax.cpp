#include<iostream>

int main(){
    float a, g, ka, kg;
    scanf("%f %f %f %f", &a, &g, &ka, &kg);
    a = ka/a;
    g = kg/g;
    if(g >= a) printf("G\n");
    else printf("A\n");
}