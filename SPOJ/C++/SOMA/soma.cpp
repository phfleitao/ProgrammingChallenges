#include <iostream>

using namespace std;

int main()
{
    int n, m, soma = 0;
    scanf("%d", &n);
    for(int i= 0; i< n; i++){
        scanf("%d", &m);
        soma += m;
    }
    cout<<"\n";
    printf("%d", soma);
    return 0;
}
