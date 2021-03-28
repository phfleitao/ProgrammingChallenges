#include<iostream>
#include<queue>
using namespace std;

int main(){
	int n, j, z, somaj = 0, somaz = 0; 
	long long t = 0;
	queue<int> resposta; 
	while(scanf("%d",&n) != EOF && n != 0){
		resposta.push(-9999);
		for(int i = 0;i < n; i++){
			scanf("%d %d",&j,&z);
			somaj += j; somaz += z;
			resposta.push(somaj - somaz);
		}
		somaj = somaz = 0;		
	}
	while(!resposta.empty()){
		if(resposta.front() == -9999){
			cout<<"\nTeste "<<++t<<"\n";
			resposta.pop();
		}
		else{
			cout<<resposta.front()<<"\n";
			resposta.pop();
		}
	}
	return 0;
}