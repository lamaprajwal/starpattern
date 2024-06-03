int n = 7;


for(int i=1;i<=n;i++)
{
    if(i==1 || i==n)
    {
        for(int j=1;j<=n;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    if(i>=2&&i<=n-1)
    {
        for (int j=1;j<=n; j++)
        {
            if(j==1 || j==n)
            {
                Console.Write("*");
            }

            else if(j>=2&&j<=n-1)
                {
                Console.Write(' ');

            }
        }
        Console.WriteLine();
    }
}
