#include <iostream>
#include <algorithm>
#include <iterator>
#include <functional>
using namespace std;

void sort(int[], int, int);
int main()
{
    int n, m, vet[10000];
    scanf("%d %d",&n, &m);
    for(int i = 0; i<n; i++){
        cin>>vet[i];
    }
    sort(vet, 0, n);
    for(int i=n - 1;i >= n - m;i--) cout<<"\n"<<vet[i];
    return 0;
}

void sort(int array[], int begin, int end) {
   int pivot = array[begin];
   int i = begin + 1, j = end, k = end;
   int t;

   while (i < j) {
      if (array[i] < pivot) i++;
      else if (array[i] > pivot) {
         j--; k--;
         t = array[i];
         array[i] = array[j];
         array[j] = array[k];
         array[k] = t; }
      else {
         j--;
         swap(array[i], array[j]);
   }  }
   i--;
   swap(array[begin], array[i]);
   if (i - begin > 1)
      sort(array, begin, i);
   if (end - k   > 1)
      sort(array, k, end);
}


