
int rows=19,n=(rows+1)/2,K=0;



for (int i=1; i<=rows; i++)
{
    K = (i <= n) ? K + 1 : K - 1;

    for (int j=1; j<=rows; j++)
    {
        if(j>=n+1-K&&j<=n+K-1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(' ');
        }
    }
   Console.WriteLine();
}


