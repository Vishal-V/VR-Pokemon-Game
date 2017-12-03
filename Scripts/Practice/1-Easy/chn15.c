#include <stdio.h>

int main()
{
    int i, t;
    scanf("%d", &t);
    for(i=0; i<t; i++)
    {
        int n,k;
        scanf("%d%d", &n, &k);
        int arr[n], j, sum=0;
        for(j=0; j<n; j++)
        {
            scanf("%d", &arr[j]);
            arr[j] += k;
            if((arr[j]%7) == 0)
                sum++;
        }
        printf("%d\n", sum);
    }
    
}