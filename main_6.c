//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
#include <stdio.h>
main()
{
	unsigned sum_squares=0, square_sum=0,sum=0,dif;
	int i;
	for (i=1;i<=100;i++)
	{
		sum_squares+=i*i;
	}
	for (i=1;i<=100;i++)
	{
		sum+=i;
	}
	square_sum=sum*sum;
	dif=square_sum-sum_squares;
	printf ("%u",dif);
}
