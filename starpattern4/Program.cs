int rows = 18, k = rows;

for (int i=1; i <=rows; i++)
{
    for (int j = 1; j <= rows; j++)
    {
        if(j>=k)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(' ');
        }

    }
    Console.WriteLine();
    k--;

}