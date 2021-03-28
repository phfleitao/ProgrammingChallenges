#include<iostream>
using namespace std;

int main(){
    int n, h, htemp, inicio, cont = 0, flag = 0, flagini;
    
    scanf("%d", &n);
    while(n != 0){
            for(int i=0; i<n; i++){
                  scanf("%d", &h);
                  if(i == 0){
                       inicio = h;
                  }
                  else if(h >= htemp){
                       if(flag == -1)
                           cont++;    
                       flag = 1;
                       if(i == 1) flagini = flag;
                  }
                  else{
                       if(flag == 1)
                           cont++;
                       flag = -1;
                       if(i == 1) flagini = flag;
                  }
                       
                  htemp = h;                         
            }  
            if(h>inicio && flag == 1){
                  cont++;
                  flag = -1;            
            }
            else if(h < inicio && flag == -1){
                  cont++;
                  flag = 1;   
            }
            if(flagini != flag) cont++;
            printf("%d\n", cont); 
            cont = 0;
            flag = 0;         
            scanf("%d", &n);                
    }
    return 0;
}
